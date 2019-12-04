using stade.models;
using stade.services;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace stade.views {

	public partial class Insertion : Form {

		public Insertion() {
			InitializeComponent();
		}

		private void Insertion_Load(object sender, EventArgs e) {
			// TODO: cette ligne de code charge les données dans la table 'dbDataSet.stade'. Vous pouvez la déplacer ou la supprimer selon les besoins.
			this.stadeTableAdapter.Fill(this.dbDataSet.stade);
		}

		private void insererEvent_Click(object sender, EventArgs e) {
			if (this.dateEvent.Text == "") {
				MessageBox.Show("Date de l'evenement obligatoire !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (this.desEvent.Text == "") {
				MessageBox.Show("Nom de l'evenement obligatoire !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			Stade el = new Stade();
			DialogResult result = MessageBox.Show("Valider les données ?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes) {
				InsertService.InsertEvent(this.dateEvent.Text, this.desEvent.Text, this.stadeEvent.SelectedValue.ToString());
			}
		}
	}
}