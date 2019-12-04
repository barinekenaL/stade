using stade.dao;
using stade.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stade.services {

	internal class InsertService {

		public static int InsertEvent(string date, string des, string stade) {
			Evenement evenement = new Evenement(des, date, stade);
			return Crud.Insert("evenement", evenement);
		}
	}
}