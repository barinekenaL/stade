using stade.models;
using stade.services;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace stade.views {

	public partial class InsertView : Form {

		public InsertView() {
			InitializeComponent();
		}

		private void Insertion_Load(object sender, EventArgs e) {
			this.BindCB();
		}

		private void BindCB() {
			Tools.BindData(this.stadeEvent, "stade", new Stade(), null, "id", "des", "0");
			Tools.BindData(this.stades, "stade", new Stade(), null, "id", "des", "0");
			Tools.BindData(this.evnmts, "evenement", new Stade(), "stade = '" + Tools.GetKey(this.stades) + "'", "id", "des", "0");
		}

		private void insererEvent_Click(object sender, EventArgs e) {
			string err = "";
			if (this.dateEvent.Text == "") {
				err += "Date de l'evenement obligatoire !\n";
			}
			if (this.desEvent.Text == "") {
				err += "Nom de l'evenement obligatoire !\n";
			}
			if (this.stadeEvent.SelectedValue == null) {
				err += "Aucun stade selectioné !\n";
			}
			if (err != "") {
				MessageBox.Show(err, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			InsertService.InsertEvent(this.dateEvent.Text, this.desEvent.Text, Tools.GetKey(this.stadeEvent));
			this.BindCB();
			MessageBox.Show("Evenement inseré avec succès", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void insertZone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			new ZoneView().Show();
		}
	}
}