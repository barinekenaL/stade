using stade.dao;
using stade.models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stade.services {

	internal class InsertService {

		public static void Reserver(string des, string numChaise, string date, string zone) {
			DbConnection connection = null;
			try {
				connection = DbConnect.Connect();
				Reservation res = new Reservation(des, numChaise, date, zone);
				Crud.Insert("reservation", res, connection);
				int[] numCh = Tools.GetNumChaise(numChaise);
				for (int i = 0; i < numCh.Length; i++) {
					Crud.Update("chaise", "etat = 2", "zone = '" + zone + "' and num = " + numCh[i], connection);
				}
			} catch (Exception) {
				throw;
			} finally {
				if (connection != null) {
					connection.Close();
				}
			}
		}

		public static int InsertEvent(string date, string des, string stade) {
			Evenement evenement = new Evenement(des, date, stade);
			return Crud.Insert("evenement", evenement);
		}
	}
}