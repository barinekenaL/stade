using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stade.models {

	internal class Stade {

		public Stade() {
		}

		public Stade(string des, string points) {
			this.Des = des;
			this.Points = points;
		}

		public string Id { get; set; }
		public string Des { get; set; }
		public string Points { get; set; }
		internal Dictionary<string, Evenement> Evenmts { get; set; }
	}
}