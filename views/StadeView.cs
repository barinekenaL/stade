using stade.dao;
using stade.models;
using stade.services;
using stade.views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace stade {

	public partial class StadeView : Form {
		private Pen pen = new Pen(Color.DarkBlue);

		public StadeView() {
			InitializeComponent();
		}

		private void ajouter_Click(object sender, EventArgs e) {
			if (this.points.Items.Count < 3) {
				this.err.Text = "3 points au min";
				return;
			}
			if (this.desStade.Text == "") {
				this.err.Text = "Designation requis";
				return;
			}
			StadeService.InsertStade(this.desStade.Text, StadeService.GetPointString(this.points));
			MessageBox.Show("Stade inserée avec succès!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void choisir_Click(object sender, EventArgs e) {
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

		private void panel_MouseClick(object sender, MouseEventArgs e) {
			this.points.Items.Add(e.X + ";" + e.Y);
			this.panel.Refresh();
			DrawService.DrawPolygon(this.panel, this.points, this.pen);
		}

		private void points_KeyUp(object sender, KeyEventArgs e) {
			DrawService.removePoint(e.KeyCode, this.points, this.panel, this.pen);
		}

		private void points_MouseClick(object sender, MouseEventArgs e) {
			this.panel.Refresh();
			DrawService.markPoint(this.points, this.panel, this.pen);
		}

		private void Stade_Load(object sender, EventArgs e) {
			this.Stade_Resize(sender, e);
		}

		private void Stade_Resize(object sender, EventArgs e) {
			int margin = 60;
			int w = this.Size.Width - this.insertion.Width - margin + 10;
			int h = this.Size.Height - margin;
			this.panel.Size = new Size(w, h);
			this.panel.Refresh();
			DrawService.DrawPolygon(this.panel, this.points, this.pen);
		}

		private void insert_Click(object sender, EventArgs e) {
			InsertView insertion = new InsertView();
			insertion.Show();
		}

		private void reservation_Click(object sender, EventArgs e) {
			ReservationView reservation = new ReservationView();
			reservation.Show();
		}

		private void graphe_Click(object sender, EventArgs e) {
			new DashBoard().Show();
		}
	}
}