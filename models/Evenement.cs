using stade.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stade.models {

	internal class Evenement {

		public Evenement() {
		}

		public Evenement(string des, string date, string stade) {
			this.Des = des;
			this.Date = Tools.GetDate(date);
			this.Stade = stade;
		}

		public DateTime Date { get; set; }
		public string Des { get; set; }
		public string Id { get; set; }
		public string Stade { get; set; }
		internal Zone[] Zones { get; set; }
	}
}