using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stade.models {

	internal class Zone {

		public float GetSituationActuel() {
			return 100 * this.Reservations.Sum(x => x.NbChaise) / this.NbChaise;
		}

		public float GetPrixActuel() {
			return this.Pu * this.Reservations.Sum(x => x.NbChaise);
		}

		public float GetPrixEstimer() {
			return this.Pu * this.GetPlaceEstimer();
		}

		public float GetPrixEst() {
			return this.Pu * this.NbChaise;
		}

		public float GetPlaceEstimer() {
			return Convert.ToSingle(Math.Floor(this.Chaises.Count * Estimation / 100));
		}

		public void SetData(string evenm, string des, float estimation, float pu) {
			this.Evenm = evenm;
			this.Des = des;
			this.Estimation = estimation;
			this.Pu = pu;
		}

		public void AddChaise(Chaise ch) {
			this.Chaises.Add(ch);
		}

		public Zone() {
		}

		public Zone(string evenm, string des, string points, int num1, string dir, string sens, float lngCh, float largCh, float espAv, float espCote, float pu, float estimation) {
			this.Evenm = evenm;
			this.Des = des;
			this.Points = points;
			this.Num1 = num1;
			this.Dir = dir;
			this.Sens = sens;
			this.LngCh = lngCh;
			this.LargCh = largCh;
			this.EspAv = espAv;
			this.EspCote = espCote;
			this.Pu = pu;
			this.Estimation = estimation;
		}

		public string Id { get; set; }
		public string Des { get; set; }
		public string Points { get; set; }
		public int Num1 { get; set; }
		public string Dir { get; set; }
		public string Sens { get; set; }
		public float LngCh { get; set; }
		public float LargCh { get; set; }
		public float EspAv { get; set; }
		public float EspCote { get; set; }
		public string Evenm { get; set; }
		public float Estimation { get; set; }
		internal List<Chaise> Chaises { get; set; } = new List<Chaise>();
		internal List<Reservation> Reservations { get; set; } = new List<Reservation>();
		public float Pu { get; set; }

		public int NbChaise { get; set; }
	}
}