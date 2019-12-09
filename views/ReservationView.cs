using stade.dao;
using stade.models;
using stade.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stade.views {

	public partial class ReservationView : Form {

		public ReservationView() {
			InitializeComponent();
		}

		private void reserverBtn_Click(object sender, EventArgs e) {
			string err = "";
			if (this.dateRes.Text == "") {
				err += "Date de reservation requis !\n";
			}

			if (this.des.Text == "") {
				err += "Designation requis !\n";
			}
			if (this.numChaise.Text == "") {
				err += "Numero chaise requis !\n";
			}
			try {
				if (err != "") {
					MessageBox.Show(err, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				string msg = StadeService.CheckChaise(this.numChaise.Text, Tools.GetKey(this.zoneRes));
				if (msg != "") {
					err += msg + "\n";
				}
				if (err != "") {
					MessageBox.Show(err, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				InsertService.Reserver(this.des.Text, this.numChaise.Text, this.dateRes.Text, Tools.GetKey(this.zoneRes));
				MessageBox.Show("Reservation enregistré", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ReservationView_Load(object sender, EventArgs e) {
			// reservation
			Tools.BindData(this.evnm, "evenement", new Evenement(), null, "id", "des", "0");
			Tools.BindData(this.zoneRes, "zone", new Zone(), "evenm = '" + Tools.GetKey(this.evnm) + "'", "id", "des", "0");
			this.dateRes.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
			// raprochement
			Tools.BindData(this.evenement, "evenement", new Evenement(), null, "id", "des", "0");
			Tools.BindData(this.zone, "zone", new Zone(), "evenm = '" + Tools.GetKey(this.evenement) + "'", "id", "des", "0");
			this.date.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
		}

		private void evnm_SelectedIndexChanged(object sender, EventArgs e) {
			Tools.BindData(this.zoneRes, "zone", new Zone(), "evenm = '" + Tools.GetKey(this.evnm) + "'", "id", "des", "0");
			this.dateRes.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
		}

		private void evenement_SelectedIndexChanged(object sender, EventArgs e) {
			Tools.BindData(this.zone, "zone", new Zone(), "evenm = '" + Tools.GetKey(this.evenement) + "'", "id", "des", "0");
			this.date.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
		}

		private void voir_Click(object sender, EventArgs e) {
			Zone zone = Crud.Select("zone", new Zone(), "", "id = '" + Tools.GetKey(this.zone) + "'")[0];
			zone.Reservations = Crud.Select("reservation", new Reservation(), "", "zone = '" + Tools.GetKey(this.zone) + "' and date <= '" + Tools.GetDate(this.date.Text).ToString() + "'").ToList();
			this.table.Rows.Clear();
			this.table.Rows.Add(zone.Pu.ToString(), zone.Estimation.ToString(), zone.GetPrixEst().ToString(), zone.GetSituationActuel().ToString(), zone.GetPrixActuel());
		}
	}
}