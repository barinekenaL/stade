using stade.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stade.models {

	internal class Evenement {
		private string id;
		private string des;
		private DateTime date;
		private string stade;

		public string Id { get => id; set => id = value; }
		public string Des { get => des; set => des = value; }
		public DateTime Date { get => date; set => date = value; }
		public string Stade { get => stade; set => stade = value; }

		public Evenement() {
		}

		public Evenement(string des, string date, string stade) {
			this.Des = des;
			this.Date = Tools.GetDate(date);
			this.Stade = stade;
		}
	}
}