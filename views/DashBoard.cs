using stade.dao;
using stade.models;
using stade.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stade.views {

	public partial class DashBoard : Form {

		public DashBoard() {
			InitializeComponent();
		}

		private void DashBoard_Load(object sender, EventArgs e) {
			Tools.BindData(this.evenm, "evenement", new Evenement(), "", "id", "des", "0");
			this.bindData();
			this.grph.Show();
		}

		private void bindData() {
			DbConnection connection = null;
			try {
				connection = DbConnect.Connect();
				Evenement evenement = Crud.Select("evenement", new Evenement(), "", "id = '" + Tools.GetKey(this.evenm) + "'", connection)[0];
				List<Jour> jours = new List<Jour>();
				Jour j = null;
				// check date debut / fin
				DateTime[] interval = new DateTime[2];
				int nbInterval = 6;
				if (this.dateDebut.Text == "") {
					if (this.dateFin.Text == "") {
						interval[0] = evenement.Date.AddDays(-nbInterval);
						interval[1] = evenement.Date;
					} else {
						interval[1] = Tools.GetDate(this.dateFin.Text);
						interval[0] = interval[1].AddDays(-nbInterval);
					}
				} else {
					if (this.dateFin.Text == "") {
						interval[0] = Tools.GetDate(this.dateDebut.Text);
						interval[1] = interval[0].AddDays(nbInterval);
					} else {
						if (Tools.GetDate(this.dateDebut.Text).Millisecond > Tools.GetDate(this.dateFin.Text).Millisecond) {
							MessageBox.Show("Date entrée invalide", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return;
						}
						interval[0] = Tools.GetDate(this.dateDebut.Text);
						interval[1] = Tools.GetDate(this.dateFin.Text);
					}
				}
				for (DateTime d = interval[0]; d <= interval[1]; d = d.AddDays(1)) {
					j = new Jour();
					j.Res = Crud.Select("ReservationEvent", new Reservation(), "", "idEvenm = '" + evenement.Id + "' AND dateRes BETWEEN '" + d.ToString() + "' AND '" + d.AddDays(1).ToString() + "'", connection).ToList();
					if (j.Res.Count == 0) {
						j.Res.Add(new Reservation(d));
					}
					j.Medias = Crud.Select("mediaEv", new Media(), "", "idEvent = '" + evenement.Id + "' AND date BETWEEN '" + d.ToString() + "' AND '" + d.AddDays(1).AddSeconds(-5).ToString() + "'", connection).ToList();
					jours.Add(j);
				}

				// set top media
				List<Media> medias = Crud.Select("mediaEv", new Media(), "distinct des, prix", "idEvent = '" + evenement.Id + "'", connection).ToList();
				for (int i = 0; i < medias.Count; i++) {
					for (int k = 0; k < jours.Count; k++) {
						for (int m = 0; m < jours[k].Medias.Count; m++) {
							if (jours[k].Medias[m].Des.Equals(medias[i].Des, StringComparison.OrdinalIgnoreCase)) {
								medias[i].NbRes += jours[k].GetMediaRes();
							}
						}
					}
				}
				medias.Sort((x1, x2) => x2.NbRes.CompareTo(x1.NbRes));
				this.topList.Items.Clear();
				for (int i = 0; i < medias.Count; i++) {
					this.topList.Items.Add(medias[i].Des + " - " + medias[i].NbRes);
				}
				// end
				List<string> xAxis = new List<string>();
				List<float> yAxis = new List<float>();
				float nbRes = StadeService.GetNbRes(interval[0], evenement.Id);
				for (int i = 0; i < jours.Count; i++) {
					nbRes += jours[i].GetNbRes();
					xAxis.Add(jours[i].GetInfo());
					yAxis.Add(nbRes);
				}
				this.grph.Series[0].Points.DataBindXY(xAxis, yAxis);
				if (interval[1].Millisecond - interval[0].Millisecond > 0) {
				}
			} catch (Exception) {
				throw;
			} finally {
				if (connection != null) {
					connection.Close();
				}
			}
		}

		private void voir_Click(object sender, EventArgs e) {
			this.bindData();
		}
	}
}