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
		private Dictionary<string, string> categories = new Dictionary<string, string>();
		private Dictionary<string, string> dir;
		private int mode = 0;
		private Pen pen = new Pen(Color.DarkGray);
		private Dictionary<string, string> sens1;
		private Dictionary<string, string> sens2;
		private Stade stadeData;
		private Dictionary<string, string> stades = new Dictionary<string, string>();
		private Zone[] zones;

		public ZoneView(string idStade) {
			this.Mode = 0;
			this.StadeData = Crud.Select("stade", new Stade(), null, "id = '" + idStade + "'")[0];
			Stade[] st = Crud.Select("stade", new Stade(), null, null);
			for (int i = 0; i < st.Length; i++) {
				this.stades.Add(st[i].Id, st[i].Des);
			}
			Categ[] ct = Crud.Select("categ", new Categ(), null, null);
			for (int i = 0; i < ct.Length; i++) {
				this.categories.Add(ct[i].Id, ct[i].Des);
			}
			this.zones = StadeService.getZones(idStade);
			InitializeComponent();
			InitData();
		}

		public int Mode { get => mode; set => mode = value; }
		internal Stade StadeData { get => stadeData; set => stadeData = value; }

		private void ajouter_Click(object sender, EventArgs e) {
			if (this.desZone.Text == "") {
				this.err.Text = "Saisir un nom pour la zone";
				return;
			}
			if (this.points.Items.Count < 3) {
				this.err.Text = "3 points au minimum pour desinner une zone";
				return;
			}
			StadeService.insertZone(
				((KeyValuePair<string, string>)this.stade.SelectedItem).Key,
				this.desZone.Text, this.points,
				((KeyValuePair<string, string>)this.direction.SelectedItem).Key,
				((KeyValuePair<string, string>)this.sens.SelectedItem).Key,
				((KeyValuePair<string, string>)this.categ.SelectedItem).Key,
				Convert.ToInt32(this.num1.Value),
				Convert.ToSingle(this.lngCh.Value), Convert.ToSingle(this.largCh.Value),
				Convert.ToSingle(this.espAv.Value), Convert.ToSingle(this.espCote.Value)
			);
			this.zones = StadeService.getZones(this.StadeData.Id);
			this.points.Items.Clear();
		}

		private void clear_Click(object sender, EventArgs e) {
			this.points.Items.Clear();
			this.panel.Refresh();
		}

		private void couleur_Click(object sender, EventArgs e) {
			this.pen.Color = DrawService.getColor(this.pen);
			this.panel.Refresh();
			DrawService.DrawPolygon(this.panel, this.points, this.pen);
		}

		private void direction_SelectedValueChanged(object sender, EventArgs e) {
			string key = ((KeyValuePair<string, string>)this.direction.SelectedItem).Key;
			if (key.Equals("Bh") || key.Equals("Hb")) {
				this.sens.DataSource = new BindingSource(this.sens1, null);
			} else {
				this.sens.DataSource = new BindingSource(this.sens2, null);
			}
		}

		private void InitData() {
			this.dir = new Dictionary<string, string>();
			dir.Add("Gd", "G a D");
			dir.Add("Dg", "D a G");
			dir.Add("Bh", "B en H");
			dir.Add("Hb", "H en B");
			this.sens1 = new Dictionary<string, string>();
			sens1.Add("gd", "G a D");
			sens1.Add("dg", "D a G");
			this.sens2 = new Dictionary<string, string>();
			sens2.Add("hb", "H en B");
			sens2.Add("bh", "B en H");
		}

		private void mode_CheckedChanged(object sender, EventArgs e) {
			RadioButton rb = (RadioButton)sender;
			if (rb.Checked) {
				// This is the correct control.
				this.desZone.Text = rb.Text;
			}
		}

		private void panel_MouseClick(object sender, MouseEventArgs e) {
			int[] point = new int[] { e.X, e.Y };
			// click outside stade
			if (!StadeService.inPolygon(stadeData.Points, point)) {
				return;
			}
			// get clicked zone
			Zone zone = StadeService.GetZone(this.zones, point);
			// get clicked chair
			Chaise chaise = null;
			if (zone != null) {
				chaise = StadeService.GetChaise(zone, point);
			}
			if (e.Button == MouseButtons.Right) {
				if (chaise != null) {
					this.panel.Refresh();
					DrawService.FillChaise(this.panel, new Pen(Color.DarkOliveGreen), zone, chaise);
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
				DrawService.DrawPolygon(this.panel, this.points, this.pen);
			}
		}

		private void panel_Paint(object sender, PaintEventArgs e) {
			DrawService.DrawPolygon(this.panel, StadeService.GetListBox(this.stadeData.Points), new Pen(Color.Green));
			this.zones = StadeService.getZones(this.StadeData.Id);
			DrawService.ShowZone(this.panel, this.zones, this.pen);
		}

		private void points_KeyUp(object sender, KeyEventArgs e) {
			DrawService.removePoint(e.KeyCode, this.points, this.panel, this.pen);
		}

		private void points_MouseClick(object sender, MouseEventArgs e) {
			this.panel.Refresh();
			DrawService.markPoint(this.points, this.panel, this.pen);
		}

		private void simuler_Click(object sender, EventArgs e) {
			if (this.points.Items.Count < 3) {
				return;
			}
			Zone zone = StadeService.simuler(
				StadeService.GetPoints(this.points),
				Convert.ToInt32(this.num1.Value),
				((KeyValuePair<string, string>)this.direction.SelectedItem).Key,
				((KeyValuePair<string, string>)this.sens.SelectedItem).Key,
				Convert.ToSingle(this.lngCh.Value),
				Convert.ToSingle(this.largCh.Value),
				Convert.ToSingle(this.espAv.Value),
				Convert.ToSingle(this.espCote.Value)
			);
			this.panel.Refresh();
			DrawService.ShowZone(this.panel, zone, new Pen(Color.BurlyWood));
		}

		private void Zone_Load(object sender, EventArgs e) {
			if (this.dir.Count > 0) {
				DrawService.SetComboboxSource(this.direction, this.dir, 0);
			}

			if (this.sens2.Count > 0) {
				DrawService.SetComboboxSource(this.sens, this.sens2, 0);
				this.sens.DataSource = new BindingSource(this.sens2, null);
			}

			if (this.categories.Count > 0) {
				DrawService.SetComboboxSource(this.categ, this.categories, 0);
			}

			if (this.stades.Count > 0) {
				DrawService.SetComboboxSource(this.stade, this.stades, this.stades.Keys.ToList<string>().IndexOf(this.stadeData.Id));
			}

			this.Zone_Resize(sender, e);
		}

		private void Zone_Resize(object sender, EventArgs e) {
			int margin = 60;
			int w = this.Size.Width - this.insertion.Width - margin + 10;
			int h = this.Size.Height - margin;
			this.panel.Size = new Size(w, h);
			this.panel.Refresh();
			DrawService.DrawPolygon(this.panel, this.points, this.pen);
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
			this.panel.Refresh();
			this.zones = StadeService.getZones(this.StadeData.Id);
			DrawService.ShowZone(this.panel, this.zones, this.pen);
			DrawService.DrawPolygon(this.panel, this.points, this.pen);
		}
	}
}