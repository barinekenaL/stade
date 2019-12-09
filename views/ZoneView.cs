using stade.dao;
using stade.models;
using stade.services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace stade {

	public partial class ZoneView : Form {
		private Stade stade;
		private Pen pen = new Pen(Color.DarkGray);

		public ZoneView() {
			InitializeComponent();
		}

		private void enr_Click(object sender, EventArgs e) {
			string err = "";
			if (this.evenm.SelectedValue == null) {
				err += "Aucun evenement selectioné !\n";
			}
			if (this.desZone.Text == "") {
				err += "Saisir un nom pour la zone\n";
			}
			if (this.points.Items.Count < 3) {
				err += "3 points au minimum pour desinner une zone\n";
			}
			if (err != "") {
				MessageBox.Show(err, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			StadeService.InsertZone(
				Tools.GetKey(this.evenm),
				this.desZone.Text, this.points,
				this.direction.SelectedValue.ToString(),
				Tools.GetKey(this.sens),
				Convert.ToInt32(this.num1.Value),
				Convert.ToSingle(this.lngCh.Value), Convert.ToSingle(this.largCh.Value),
				Convert.ToSingle(this.espAv.Value), Convert.ToSingle(this.espCote.Value),
				Convert.ToSingle(this.estimation.Value), Convert.ToSingle(this.pu.Value)
			);
			this.stade.Evenmts[Tools.GetKey(this.evenm)].Zones = StadeService.GetZones(Tools.GetKey(this.evenm));
			this.points.Items.Clear();
		}

		private void clear_Click(object sender, EventArgs e) {
			this.points.Items.Clear();
			this.panel.Refresh();
			this.showCurrZones();
		}

		private void couleur_Click(object sender, EventArgs e) {
			this.pen.Color = DrawService.getColor(this.pen);
			this.panel.Refresh();
			this.showCurrZones();
			DrawService.DrawPolygon(this.panel, this.points, this.pen);
		}

		private void direction_SelectedValueChanged(object sender, EventArgs e) {
			if (Position.SensV().Keys.ToList().FindIndex(x => x.Equals(Tools.GetKey(this.direction), StringComparison.OrdinalIgnoreCase)) < 0) {
				this.sens.DataSource = new BindingSource(Position.SensV(), null);
			} else {
				this.sens.DataSource = new BindingSource(Position.SensH(), null);
			}
		}

		private void panel_MouseClick(object sender, MouseEventArgs e) {
			int[] point = new int[] { e.X, e.Y };
			// click outside stade
			if (!StadeService.InPolygon(this.stade.Points, point)) {
				return;
			}
			// get clicked zone
			Zone zone = StadeService.GetZone(this.stade.Evenmts[Tools.GetKey(this.evenm)].Zones, point);
			// get clicked chair
			Chaise chaise = null;
			if (zone != null) {
				chaise = StadeService.GetChaise(zone, point);
			}
			if (e.Button == MouseButtons.Right) {
				if (chaise != null) {
					this.panel.Refresh();
					this.showCurrZones();
					// Hightligh clicked chair
					DrawService.FillChaise(this.panel, new Pen(Color.DarkOliveGreen), zone, chaise);
					// line 84 can be deleted !!!!!!!!!!! with refresh at line 80
					DrawService.DrawPolygon(this.panel, this.points, this.pen);
					ContextMenu cm = new ContextMenu();
					if (chaise.Etat == 0) {
						cm.MenuItems.Add("Réparer", new EventHandler((s, ev) => Reparer_Click(sender, e, chaise)));
					} else {
						cm.MenuItems.Add("Endommager", new EventHandler((s, ev) => Endommage_Click(sender, e, chaise)));
					}
					cm.Show(this.panel, new Point(e.X, e.Y));
				}
			} else {
				if (zone != null) {
					return;
				}
				// check zone intersection
				// add point to new zone points
				this.points.Items.Add(e.X + ";" + e.Y);
				this.panel.Refresh();
				this.showCurrZones();
				DrawService.DrawPolygon(this.panel, this.points, this.pen);
			}
		}

		private void showCurrZones() {
			if (this.stade.Evenmts.Count == 0) {
				MessageBox.Show("Aucun eevenement trouvé !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				this.Close();
				return;
			}
			if (this.stade != null) {
				DrawService.DrawPolygon(this.panel, StadeService.GetListBox(this.stade.Points), new Pen(Color.Green));
				DrawService.ShowZone(this.panel, this.stade.Evenmts[Tools.GetKey(this.evenm)].Zones, this.pen);
			}
		}

		private void points_KeyUp(object sender, KeyEventArgs e) {
			DrawService.removePoint(e.KeyCode, this.points, this.panel, this.pen);
		}

		private void points_MouseClick(object sender, MouseEventArgs e) {
			this.panel.Refresh();
			this.showCurrZones();
			DrawService.markPoint(this.points, this.panel, this.pen);
		}

		private void simuler_Click(object sender, EventArgs e) {
			string err = "";
			if (this.evenm.SelectedValue == null) {
				err += "Aucun evenement selectioné !\n";
			}
			if (this.points.Items.Count < 3) {
				err += "3 points au minimum pour desinner une zone\n";
			}
			if (err != "") {
				MessageBox.Show(err, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			Zone zone = StadeService.Simuler(
				StadeService.GetPoints(this.points),
				Convert.ToInt32(this.num1.Value),
				Tools.GetKey(this.direction),
				Tools.GetKey(this.sens),
				Convert.ToSingle(this.lngCh.Value),
				Convert.ToSingle(this.largCh.Value),
				Convert.ToSingle(this.espAv.Value),
				Convert.ToSingle(this.espCote.Value),
				Convert.ToSingle(this.pu.Value),
				Convert.ToSingle(this.estimation.Value)

			);
			this.prixEstimer.Value = Convert.ToDecimal(zone.GetPrixEstimer());
			this.nbPlace.Value = Convert.ToDecimal(zone.GetPlaceEstimer());
			this.panel.Refresh();
			this.showCurrZones();
			DrawService.ShowZone(this.panel, zone, new Pen(Color.BurlyWood));
		}

		private void Zone_Load(object sender, EventArgs e) {
			Tools.BindData(this.stades, "stade", new Stade(), null, "id", "des", "0");
			this.stade = StadeService.GetStade(Tools.GetKey(this.stades));
			Tools.BindData(this.evenm, "evenement", new Evenement(), "stade = '" + Tools.GetKey(this.stades) + "'", "id", "des", "0");
			StadeService.SetCBSource(this.direction, Position.Dir(), 0);
			StadeService.SetCBSource(this.sens, Position.SensV(), 0);
			this.Zone_Resize(sender, e);
			Console.WriteLine("Load");
		}

		private void Zone_Resize(object sender, EventArgs e) {
			int margin = 60;
			int w = this.Size.Width - this.insertion.Width - margin + 10;
			int h = this.Size.Height - margin;
			this.panel.Size = new Size(w, h);
		}

		private void Endommage_Click(object sender, EventArgs e, Chaise chaise) {
			Crud.Update("chaise", "etat = 0", "Id = '" + chaise.Id + "'");
			refreshData();
		}

		private void Reparer_Click(object sender, EventArgs e, Chaise chaise) {
			Crud.Update("chaise", "etat = 1", "Id = '" + chaise.Id + "'");
			refreshData();
		}

		private void refreshData() {
			this.stade.Evenmts[Tools.GetKey(this.evenm)].Zones = StadeService.GetZones(Tools.GetKey(this.evenm));
			this.panel.Refresh();
		}

		private void stades_SelectedIndexChanged(object sender, EventArgs e) {
			this.stade = StadeService.GetStade(Tools.GetKey(this.stades));
			Tools.BindData(this.evenm, "evenement", new Evenement(), "stade = '" + Tools.GetKey(this.stades) + "'", "id", "des", "0");
			this.panel.Refresh();
		}

		private void panel_Paint(object sender, PaintEventArgs e) {
			DrawService.DrawPolygon(this.panel, this.points, this.pen);
			this.showCurrZones();
		}

		private void evenm_SelectedIndexChanged(object sender, EventArgs e) {
			this.points.Items.Clear();
			this.panel.Refresh();
		}
	}
}