using stade.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stade.models {

	internal class Reservation {
		public string Id { get; set; }
		public string Des { get; set; }
		public string NumCh { get; set; }
		public DateTime Date { get; set; }
		public string Zone { get; set; }
		public int NbChaise { get; set; }

		public Reservation() {
		}

		public Reservation(string des, string numChaise, string date, string zone) {
			this.Des = des;
			this.NumCh = numChaise;
			this.Date = Tools.GetDate(date);
			this.Zone = zone;
			this.NbChaise = Tools.GetNumChaise(numChaise).Length;
		}
	}
}