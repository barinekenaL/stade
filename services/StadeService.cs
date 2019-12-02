using stade.dao;
using stade.models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace stade.services {

	internal class StadeService {

		public static void Bh_dg(Region region, RectangleF bounds, Zone zone, int num1, float lngCh, float largCh, float espAv, float espCote) {
			float x = 0, dx = lngCh + espCote;
			float y = 0, dy = largCh + espAv;
			x = bounds.Right - espCote;
			int num = 1;
			while (x - largCh >= bounds.X) {
				y = bounds.Bottom - espAv;
				while (y - lngCh >= bounds.Y) {
					if (region.IsVisible(x, y) && region.IsVisible(x, y + largCh) &&
						region.IsVisible(x + lngCh, y) && region.IsVisible(x + lngCh, y + largCh)
					) {
						zone.AddChaise(new Chaise(x, y, num1++, num++));
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
			int num = 1;
			while (x + largCh <= bounds.Right) {
				y = bounds.Bottom - espAv;
				while (y - lngCh >= bounds.Y) {
					if (region.IsVisible(x, y) && region.IsVisible(x, y + largCh) &&
						region.IsVisible(x + lngCh, y) && region.IsVisible(x + lngCh, y + largCh)
					) {
						zone.AddChaise(new Chaise(x, y, num1++, num++));
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
			int num = 1;
			while (y - lngCh >= bounds.Top) {
				x = bounds.Right - espCote;
				while (x - largCh >= bounds.X) {
					if (region.IsVisible(x, y) && region.IsVisible(x, y + largCh) &&
						region.IsVisible(x + lngCh, y) && region.IsVisible(x + lngCh, y + largCh)
					) {
						zone.AddChaise(new Chaise(x, y, num1++, num++));
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
			int num = 1;
			while (y + lngCh <= bounds.Bottom) {
				x = bounds.Right - espCote;
				while (x - largCh >= bounds.X) {
					if (region.IsVisible(x, y) && region.IsVisible(x, y + largCh) &&
						region.IsVisible(x + lngCh, y) && region.IsVisible(x + lngCh, y + largCh)
					) {
						zone.AddChaise(new Chaise(x, y, num1++, num++));
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
			int num = 1;
			while (y - lngCh >= bounds.Top) {
				x = bounds.X + espCote;
				while (x + largCh <= bounds.Right) {
					if (region.IsVisible(x, y) && region.IsVisible(x, y + largCh) &&
						region.IsVisible(x + lngCh, y) && region.IsVisible(x + lngCh, y + largCh)
					) {
						zone.AddChaise(new Chaise(x, y, num1++, num++));
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
			int num = 1;
			while (y + lngCh <= bounds.Bottom) {
				x = bounds.X + espCote;
				while (x + largCh <= bounds.Right) {
					if (region.IsVisible(x, y) && region.IsVisible(x, y + largCh) &&
						region.IsVisible(x + lngCh, y) && region.IsVisible(x + lngCh, y + largCh)
					) {
						zone.AddChaise(new Chaise(x, y, num1++, num++));
					}
					x += lngCh + espCote;
				}
				y += largCh + espAv;
			}
		}

		public static Chaise GetChaise(Zone zone, int[] point) {
			Chaise[] chaises = zone.chaises.ToArray();
			PointF[] points = new PointF[4];
			for (int i = 0; i < chaises.Length; i++) {
				points[0] = new PointF(chaises[i].X, chaises[i].Y);
				points[1] = new PointF(chaises[i].X + zone.LngCh, chaises[i].Y);
				points[2] = new PointF(chaises[i].X + zone.LngCh, chaises[i].Y + zone.LargCh);
				points[3] = new PointF(chaises[i].X, chaises[i].Y + zone.LargCh);
				if (StadeService.inPolygon(points, point)) {
					return zone.chaises[i];
				}
			}
			return null;
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
				if (StadeService.inPolygon(zones[i].Points, point)) {
					return zones[i];
				}
			}
			return null;
		}

		public static Zone[] getZones(string idStade) {
			DbConnection connection = DbConnect.Connect();
			Zone[] zones = Crud.Select("zone", new Zone(), null, "stade = '" + idStade + "'", connection);
			int numChaise = 0;
			Chaise[] chaises = null;
			for (int i = 0; i < zones.Length; i++) {
				zones[i] = (Zone)zones[i];
				chaises = Crud.Select("chaise", new Chaise(), null, "zone = '" + zones[i].Id + "' order by num asc");
				numChaise = zones[i].Num1 - 1;
				for (int j = 0; j < chaises.Length; j++) {
					if (chaises[j].Etat != 0) {
						numChaise += chaises[j].Dp;
						chaises[j].numZone = numChaise;
					} else {
						chaises[j].numZone = -1;
					}
					zones[i].chaises.Add(chaises[j]);
				}
			}
			return zones;
		}

		public static void Hb_dg(Region region, RectangleF bounds, Zone zone, int num1, float lngCh, float largCh, float espAv, float espCote) {
			float x = 0, dx = lngCh + espCote;
			float y = 0, dy = largCh + espAv;
			x = bounds.Right - espCote;
			int num = 1;
			while (x - largCh >= bounds.X) {
				y = bounds.Y + espAv;
				while (y + lngCh <= bounds.Bottom) {
					if (region.IsVisible(x, y) && region.IsVisible(x, y + largCh) &&
						region.IsVisible(x + lngCh, y) && region.IsVisible(x + lngCh, y + largCh)
					) {
						zone.AddChaise(new Chaise(x, y, num1++, num++));
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
			int num = 1;
			while (x + largCh <= bounds.Right) {
				y = bounds.Y + espAv;
				while (y + lngCh <= bounds.Bottom) {
					if (region.IsVisible(x, y) && region.IsVisible(x, y + largCh) &&
						region.IsVisible(x + lngCh, y) && region.IsVisible(x + lngCh, y + largCh)
					) {
						zone.AddChaise(new Chaise(x, y, num1++, num++));
					}
					y += dy;
				}
				x += dx;
			}
		}

		public static bool inPolygon(string pointString, int[] point) {
			GraphicsPath path = new GraphicsPath();
			path.AddPolygon(StadeService.GetPoints(pointString));
			Region region = new Region(path);
			return region.IsVisible(point[0], point[1]);
		}

		public static bool inPolygon(PointF[] points, int[] point) {
			GraphicsPath path = new GraphicsPath();
			path.AddPolygon(points);
			Region region = new Region(path);
			return region.IsVisible(point[0], point[1]);
		}

		public static int insertStade(string des, string points) {
			try {
				Stade stade = new Stade(des, points);
				return Crud.Insert("stade", stade);
			} catch (Exception) {
				throw;
			}
		}

		public static bool insertZone(string stade, string des, ListBox points, string direction, string sens, string categ, int num1, float lngCh, float largCh, float espAv, float espCote) {
			DbConnection connection = null;
			try {
				connection = DbConnect.Connect();
				Zone zone = null;
				zone = StadeService.simuler(StadeService.GetPoints(points), num1, direction, sens, lngCh, largCh, espAv, espCote);
				zone.Stade = stade;
				zone.Des = des;
				zone.Categ = categ;
				Crud.Insert("zone", zone, connection);
				string idZone = Crud.CurrentId("zone");
				zone.chaises.Select(c => { c.Zone = idZone; return c; }).ToList();
				Crud.Insert("chaise", zone.chaises.ToArray(), connection);
				return true;
			} catch (Exception) {
				throw;
			} finally {
				if (connection != null)
					connection.Close();
			}
		}

		public static Zone simuler(PointF[] points, int num1, string dir, string sens, float lngCh, float largCh, float espAv, float espCote) {
			List<PointF> pts = points.OfType<PointF>().ToList();
			float minX = pts.Min<PointF>(point => point.X);
			float minY = pts.Min<PointF>(point => point.Y);
			float maxX = pts.Max<PointF>(point => point.X);
			float maxY = pts.Max<PointF>(point => point.Y);
			GraphicsPath path = new GraphicsPath();
			RectangleF b = new RectangleF(minX, minY, maxX, maxY);
			path.AddPolygon(points);
			Region region = new Region(path);
			Zone zone = new Zone("", "", StadeService.GetPointString(points), num1, dir, sens, lngCh, largCh, espAv, espCote);
			typeof(StadeService).GetMethod(dir + "_" + sens).Invoke(null, new object[] {
				region, b, zone, num1, lngCh, largCh, espAv, espCote
			});
			return zone;
		}
	}
}