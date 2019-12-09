using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stade.models {

	internal class Jour {
		public List<Reservation> Res { get; set; } = new List<Reservation>();
		public List<Media> Medias { get; set; } = new List<Media>();

		public float GetNbRes() {
			if (this.Res.Count == 0) {
				return 0;
			}
			return this.Res.Sum(x => x.NbChaise);
		}

		public float GetMediaRes() {
			return this.GetNbRes() / (float)this.Medias.Count();
		}

		public string GetInfo() {
			string info = this.Res[0].Date.ToString("dd/MM/yyyy") + "\n";
			for (int i = 0; i < this.Medias.Count; i++) {
				info += this.Medias[i].Des + "\n";
			}
			return info;
		}
	}
}