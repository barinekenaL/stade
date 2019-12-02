﻿using stade.models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stade.services {

	internal class DrawService {

		public static void FillChaise(Panel panel, Pen pen, Zone zone, Chaise chaise) {
			Graphics g = panel.CreateGraphics();
			g.FillRectangle(pen.Brush, chaise.X, chaise.Y, zone.LngCh, zone.LargCh);
		}

		public static void setComboboxSource<K, V>(ComboBox c, Dictionary<K, V> source, int selected) {
			c.DataSource = new BindingSource(source, null);
			c.DisplayMember = "Value";
			c.ValueMember = "key";
			c.SelectedIndex = selected;
		}

		public static void ShowZone(Panel panel, Zone[] zones, Pen pen) {
			for (int i = 0; i < zones.Length; i++) {
				DrawService.ShowZone(panel, zones[i], pen);
			}
		}

		public static void ShowZone(Panel panel, Zone zone, Pen pen) {
			Graphics g = panel.CreateGraphics();
			RectangleF[] rect = new RectangleF[1];
			DrawService.DrawPolygon(panel, StadeService.GetListBox(zone.Points), pen);
			for (int i = 0; i < zone.chaises.Count; i++) {
				rect[0] = new RectangleF(zone.chaises[i].X, zone.chaises[i].Y, zone.LngCh, zone.LargCh);
				if (zone.chaises[i].numZone < 0) {
					g.DrawString("X", new Font(FontFamily.GenericSansSerif, 8), Brushes.Black, rect[0]);
				} else {
					g.DrawString((zone.chaises[i].numZone).ToString(), new Font(FontFamily.GenericSansSerif, 8), Brushes.Black, rect[0]);
				}
				g.DrawRectangles(new Pen(Color.Red), rect);
			}
		}

		public static void DrawPolygon(Panel panel, ListBox data, Pen pen) {
			Graphics g = panel.CreateGraphics();
			int nbPts = data.Items.Count;
			if (nbPts == 0) {
				return;
			}
			PointF[] points = StadeService.GetPoints(data);
			if (nbPts == 1) {
				int dim = 5;
				int moitie = dim / 2;
				g.FillRectangle(pen.Brush, points[0].X - moitie, points[0].Y - moitie, dim, dim);
				return;
			}
			g.DrawPolygon(pen, points);
		}

		public static void markPoint(ListBox points, Panel panel, Pen pen) {
			if (points.SelectedIndex >= 0) {
				string[] point = points.SelectedItem.ToString().Split(';');
				DrawService.DrawPolygon(panel, points, pen);
				int dim = 5;
				int moitie = dim / 2;
				panel.CreateGraphics().FillRectangle(Brushes.Red, float.Parse(point[0]) - moitie, float.Parse(point[1]) - moitie, dim, dim);
			}
		}

		public static void removePoint(Keys keyCode, ListBox points, Panel panel, Pen pen) {
			if (keyCode.ToString().Equals("delete", StringComparison.CurrentCultureIgnoreCase) && points.SelectedIndex >= 0) {
				points.Items.RemoveAt(points.SelectedIndex);
				panel.Refresh();
				DrawService.DrawPolygon(panel, points, pen);
			}
		}

		public static Color getColor(Pen pen) {
			ColorDialog colDialog = new ColorDialog();
			colDialog.ShowHelp = true;
			colDialog.Color = pen.Color;
			colDialog.FullOpen = true;
			if (colDialog.ShowDialog() == DialogResult.OK) {
				return colDialog.Color;
			}
			return pen.Color;
		}
	}
}