using stade.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stade.models {

	internal class MediaEvent {

		public MediaEvent() {
		}

		public MediaEvent(string date, string media, string evenm) {
			this.Media = media;
			this.Evenm = evenm;
			this.Date = Tools.GetDate(date);
			this.Date = this.Date.AddSeconds(2);
		}

		public string Id { get; set; }
		public DateTime Date { get; set; }
		public string Media { get; set; }
		public string Evenm { get; set; }
	}
}