using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stade.models {

	internal class Media {

		public Media() {
		}

		public Media(string des, float prix) {
			this.Des = des;
			this.Prix = prix;
		}

		public string Id { get; set; }
		public string Des { get; set; }
		public float Prix { get; set; }
	}
}