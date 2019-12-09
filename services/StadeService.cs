using stade.dao;
using stade.models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace stade.services {

	internal class StadeService {

		public static string CheckChaise(string numChaise, string idZone) {
			DbConnection connection = null;
			try {
				connection = DbConnect.Connect();
				string notIn = "";
				string reserved = "";
				int[] numCh = Tools.GetNumChaise(numChaise);
				Chaise[] temp = null;
				for (int i = 0; i < numCh.Length; i++) {
					temp = Crud.Select("chaise", new Chaise(), "", "zone = '" + idZone + "' and num = " + numCh[i].ToString() + "", connection);
					if (temp.Length == 0) {
						notIn += numCh[i].ToString() + ", ";
					} else if (temp[0].Etat == 2) {
						reserved += numCh[i].ToString() + ", ";
					}
				}
				string result = "";
				if (notIn != "") {
					result += "Numero invalid >" + notIn.Substring(0, notIn.Length - 1) + "\n";
				}
				if (reserved != "") {
					result += "Numero dejà reservé >" + reserved;
				}
				return result;
			} catch (Exception) {
				throw;
			} finally {
				if (connection != null) {
				}
			}
		}

		public static void Bh_dg(Region region, RectangleF bounds, Zone zone, int num1, float lngCh, float largCh, float espAv, float espCote) {
			float x = 0, dx = lngCh + espCote;
			float y = 0, dy = largCh + espAv;
			x = bounds.Right - espCote;
			while (x - largCh >= bounds.X) {
				y = bounds.Bottom - espAv;
				while (y - lngCh >= bounds.Y) {
					if (region.IsVisible(x, y) && region.IsVisible(x, y + largCh) &&
						region.IsVisible(x + lngCh, y) && region.IsVisible(x + lngCh, y + largCh)
					) {
						zone.AddChaise(new Chaise(x, y, num1++));
					}
					y -= dy;
				}
				x -= dx;
			}
		}

		public static void Bh_gd(Region region, RectangleF bounds, Zone zone, int num1, float lngCh, float largCh, float espAv, float espCote) {
			float x = 0, dx = lngCh + espCote;
			float y = 0, dy = largCh + espAv;
			x = bounds.X + espCote;
			while (x + largCh <= bounds.Right) {
				y = bounds.Bottom - espAv;
				while (y - lngCh >= bounds.Y) {
					if (region.IsVisible(x, y) && region.IsVisible(x, y + largCh) &&
						region.IsVisible(x + lngCh, y) && region.IsVisible(x + lngCh, y + largCh)
					) {
						zone.AddChaise(new Chaise(x, y, num1++));
					}
					y -= dy;
				}
				x += dx;
			}
		}

		public static void Dg_bh(Region region, RectangleF bounds, Zone zone, int num1, float lngCh, float largCh, float espAv, float espCote) {
			float x = 0, dx = lngCh + espCote;
			float y = 0, dy = largCh + espAv;
			y = bounds.Bottom - espAv;
			while (y - lngCh >= bounds.Top) {
				x = bounds.Right - espCote;
				while (x - largCh >= bounds.X) {
					if (region.IsVisible(x, y) && region.IsVisible(x, y + largCh) &&
						region.IsVisible(x + lngCh, y) && region.IsVisible(x + lngCh, y + largCh)
					) {
						zone.AddChaise(new Chaise(x, y, num1++));
					}
					x -= dx;
				}
				y -= dy;
			}
		}

		public static void Dg_hb(Region region, RectangleF bounds, Zone zone, int num1, float lngCh, float largCh, float espAv, float espCote) {
			float x = 0, dx = lngCh + espCote;
			float y = 0, dy = largCh + espAv;
			y = bounds.Y + espAv;
			while (y + lngCh <= bounds.Bottom) {
				x = bounds.Right - espCote;
				while (x - largCh >= bounds.X) {
					if (region.IsVisible(x, y) && region.IsVisible(x, y + largCh) &&
						region.IsVisible(x + lngCh, y) && region.IsVisible(x + lngCh, y + largCh)
					) {
						zone.AddChaise(new Chaise(x, y, num1++));
					}
					x -= dx;
				}
				y += dy;
			}
		}

		public static void Gd_bh(Region region, RectangleF bounds, Zone zone, int num1, float lngCh, float largCh, float espAv, float espCote) {
			float x = 0, dx = lngCh + espCote;
			float y = 0, dy = largCh + espAv;
			y = bounds.Bottom - espAv;
			while (y - lngCh >= bounds.Top) {
				x = bounds.X + espCote;
				while (x + largCh <= bounds.Right) {
					if (region.IsVisible(x, y) && region.IsVisible(x, y + largCh) &&
						region.IsVisible(x + lngCh, y) && region.IsVisible(x + lngCh, y + largCh)
					) {
						zone.AddChaise(new Chaise(x, y, num1++));
					}
					x += dx;
				}
				y -= dy;
			}
		}

		public static void Gd_hb(Region region, RectangleF bounds, Zone zone, int num1, float lngCh, float largCh, float espAv, float espCote) {
			float x = 0;
			float y = 0;
			y = bounds.Y + espAv;
			while (y + lngCh <= bounds.Bottom) {
				x = bounds.X + espCote;
				while (x + largCh <= bounds.Right) {
					if (region.IsVisible(x, y) && region.IsVisible(x, y + largCh) &&
						region.IsVisible(x + lngCh, y) && region.IsVisible(x + lngCh, y + largCh)
					) {
						zone.AddChaise(new Chaise(x, y, num1++));
					}
					x += lngCh + espCote;
				}
				y += largCh + espAv;
			}
		}

		public static Chaise GetChaise(Zone zone, int[] point) {
			Chaise[] chaises = zone.Chaises.ToArray();
			PointF[] points = new PointF[4];
			for (int i = 0; i < chaises.Length; i++) {
				points[0] = new PointF(chaises[i].X, chaises[i].Y);
				points[1] = new PointF(chaises[i].X + zone.LngCh, chaises[i].Y);
				points[2] = new PointF(chaises[i].X + zone.LngCh, chaises[i].Y + zone.LargCh);
				points[3] = new PointF(chaises[i].X, chaises[i].Y + zone.LargCh);
				if (StadeService.InPolygon(points, point)) {
					return zone.Chaises[i];
				}
			}
			return null;
		}

		public static Dictionary<string, Evenement> GetEvnmts(string idStade) {
			DbConnection connection = null;
			try {
				connection = DbConnect.Connect();
				Dictionary<string, Evenement> result = new Dictionary<string, Evenement>();
				result = Crud.SelectFrom("evenement", new Evenement(), null, "where stade = '" + idStade + "' order by date asc", connection).ToDictionary(item => item.Id);
				foreach (KeyValuePair<string, Evenement> item in result) {
					item.Value.Zones = Crud.Select("zone", new Zone(), null, "evenm = '" + item.Key + "'", connection);
					for (int i = 0; i < item.Value.Zones.Length; i++) {
						item.Value.Zones[i].Chaises = Crud.Select("chaise", new Chaise(), null, "zone = '" + item.Value.Zones[i].Id + "'", connection).ToList();
					}
				}
				return result;
			} catch (Exception) {
				throw;
			} finally {
				if (connection != null) {
					connection.Close();
				}
			}
		}

		public static Stade GetStade(string idStade) {
			DbConnection connection = null;
			try {
				connection = DbConnect.Connect();
				Stade stade = Crud.Select("stade", new Stade(), null, "id = '" + idStade + "'", connection)[0];
				stade.Evenmts = Crud.SelectFrom("evenement", new Evenement(), null, "where stade = '" + idStade + "' order by date asc", connection).ToDictionary(item => item.Id);
				foreach (KeyValuePair<string, Evenement> item in stade.Evenmts) {
					item.Value.Zones = Crud.Select("zone", new Zone(), null, "evenm = '" + item.Key + "'", connection);
					for (int i = 0; i < item.Value.Zones.Length; i++) {
						item.Value.Zones[i].Chaises = Crud.Select("chaise", new Chaise(), null, "zone = '" + item.Value.Zones[i].Id + "'", connection).ToList();
					}
				}
				return stade;
			} catch (Exception) {
				throw;
			} finally {
				if (connection != null) {
					connection.Close();
				}
			}
		}

		public static ListBox GetListBox(string data) {
			string[] pts = data.Split('/');
			ListBox result = new ListBox();
			for (int i = 0; i < pts.Length; i++) {
				result.Items.Add(pts[i]);
			}
			return result;
		}

		public static PointF[] GetPoints(ListBox data) {
			int nbPts = data.Items.Count;
			PointF[] points = new PointF[nbPts];
			string[] point = null;
			float x = 0, y = 0;
			for (int i = 0; i < nbPts; i++) {
				point = data.Items[i].ToString().Split(';');
				x = float.Parse(point[0]);
				y = float.Parse(point[1]);
				points[i] = new PointF(x, y);
			}
			return points;
		}

		public static PointF[] GetPoints(string points) {
			string[] pts = points.Split('/');
			PointF[] result = new PointF[pts.Length];
			float x = 0, y = 0;
			string[] point = null;
			for (int i = 0; i < pts.Length; i++) {
				point = pts[i].Split(';');
				x = float.Parse(point[0]);
				y = float.Parse(point[1]);
				result[i] = new PointF(x, y);
			}
			return result;
		}

		public static string GetPointString(ListBox data) {
			string result = "";
			for (int i = 0; i < data.Items.Count; i++) {
				result += data.Items[i].ToString().Trim();
				result += i == data.Items.Count - 1 ? "" : "/";
			}
			return result;
		}

		public static string GetPointString(PointF[] data) {
			string result = "";
			for (int i = 0; i < data.Length; i++) {
				result += data[i].X + ";" + data[i].Y;
				result += i == data.Length - 1 ? "" : "/";
			}
			return result;
		}

		public static Zone GetZone(Zone[] zones, int[] point) {
			for (int i = 0; i < zones.Length; i++) {
				if (StadeService.InPolygon(zones[i].Points, point)) {
					return zones[i];
				}
			}
			return null;
		}

		public static Zone[] GetZones(string idEvnm) {
			DbConnection connection = DbConnect.Connect();
			Zone[] zones = Crud.Select("zone", new Zone(), null, "evenm = '" + idEvnm + "'", connection);
			for (int i = 0; i < zones.Length; i++) {
				zones[i].Chaises = Crud.Select("chaise", new Chaise(), null, "zone = '" + zones[i].Id + "' order by num asc").ToList();
			}
			return zones;
		}

		public static void Hb_dg(Region region, RectangleF bounds, Zone zone, int num1, float lngCh, float largCh, float espAv, float espCote) {
			float x = 0, dx = lngCh + espCote;
			float y = 0, dy = largCh + espAv;
			x = bounds.Right - espCote;
			while (x - largCh >= bounds.X) {
				y = bounds.Y + espAv;
				while (y + lngCh <= bounds.Bottom) {
					if (region.IsVisible(x, y) && region.IsVisible(x, y + largCh) &&
						region.IsVisible(x + lngCh, y) && region.IsVisible(x + lngCh, y + largCh)
					) {
						zone.AddChaise(new Chaise(x, y, num1++));
					}
					y += dy;
				}
				x -= dx;
			}
		}

		public static void Hb_gd(Region region, RectangleF bounds, Zone zone, int num1, float lngCh, float largCh, float espAv, float espCote) {
			float x = 0, dx = lngCh + espCote;
			float y = 0, dy = largCh + espAv;
			x = bounds.X + espCote;
			while (x + largCh <= bounds.Right) {
				y = bounds.Y + espAv;
				while (y + lngCh <= bounds.Bottom) {
					if (region.IsVisible(x, y) && region.IsVisible(x, y + largCh) &&
						region.IsVisible(x + lngCh, y) && region.IsVisible(x + lngCh, y + largCh)
					) {
						zone.AddChaise(new Chaise(x, y, num1++));
					}
					y += dy;
				}
				x += dx;
			}
		}

		public static bool InPolygon(string pointString, int[] point) {
			GraphicsPath path = new GraphicsPath();
			path.AddPolygon(StadeService.GetPoints(pointString));
			Region region = new Region(path);
			return region.IsVisible(point[0], point[1]);
		}

		public static bool InPolygon(PointF[] points, int[] point) {
			GraphicsPath path = new GraphicsPath();
			path.AddPolygon(points);
			Region region = new Region(path);
			return region.IsVisible(point[0], point[1]);
		}

		public static int InsertStade(string des, string points) {
			try {
				Stade stade = new Stade(des, points);
				return Crud.Insert("stade", stade);
			} catch (Exception) {
				throw;
			}
		}

		public static bool InsertZone(string evenm, string des, ListBox points, string direction, string sens, int num1, float lngCh, float largCh, float espAv, float espCote, float estimation, float pu) {
			DbConnection connection = null;
			try {
				connection = DbConnect.Connect();
				Zone zone = null;
				zone = StadeService.Simuler(StadeService.GetPoints(points), num1, direction, sens, lngCh, largCh, espAv, espCote, estimation, pu);
				zone.SetData(evenm, des, estimation, pu);
				Crud.Insert("zone", zone, connection);
				string idZone = Crud.CurrentId("zone");
				zone.Chaises.Select(c => { c.Zone = idZone; return c; }).ToList();
				Crud.Insert("chaise", zone.Chaises.ToArray(), connection);
				return true;
			} catch (Exception) {
				throw;
			} finally {
				if (connection != null)
					connection.Close();
			}
		}

		public static void SetCBSource<K, V>(ComboBox c, Dictionary<K, V> source, int selected) {
			c.DataSource = new BindingSource(source, null);
			c.DisplayMember = "Value";
			c.ValueMember = "key";
			c.SelectedIndex = selected;
		}

		public static Zone Simuler(PointF[] points, int num1, string dir, string sens, float lngCh, float largCh, float espAv, float espCote, float prix, float estimation) {
			List<PointF> pts = points.OfType<PointF>().ToList();
			float minX = pts.Min<PointF>(point => point.X);
			float minY = pts.Min<PointF>(point => point.Y);
			float maxX = pts.Max<PointF>(point => point.X);
			float maxY = pts.Max<PointF>(point => point.Y);
			GraphicsPath path = new GraphicsPath();
			RectangleF b = new RectangleF(minX, minY, maxX, maxY);
			path.AddPolygon(points);
			Region region = new Region(path);
			Zone zone = new Zone("", "", StadeService.GetPointString(points), num1, dir, sens, lngCh, largCh, espAv, espCote, prix, estimation);
			typeof(StadeService).GetMethod(dir + "_" + sens).Invoke(null, new object[] {
				region, b, zone, num1, lngCh, largCh, espAv, espCote
			});
			return zone;
		}
	}
}