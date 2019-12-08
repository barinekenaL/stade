using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stade.models {

	internal class Chaise {

		public Chaise() {
		}

		public Chaise(int etat) {
			this.Etat = etat;
		}

		public Chaise(string id) {
			this.Id = id;
		}

		public Chaise(float x, float y, int num) {
			this.X = x;
			this.Y = y;
			this.Num = num;
		}

		public int Etat { get; set; } = 1;
		public string Id { get; set; }
		public int Num { get; set; }
		public float X { get; set; }
		public float Y { get; set; }
		public string Zone { get; set; }
	}
}