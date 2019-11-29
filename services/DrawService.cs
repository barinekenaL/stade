using stade.models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stade.services {
    class DrawService {

        public static void Show(Panel panel, Zone zone, Pen pen) {
            Graphics g = panel.CreateGraphics();
            RectangleF[] rect = new RectangleF[1];
            for (int i = 0; i < zone.chaises.Count; i++) {
                rect[0] = new RectangleF(zone.chaises[i].X, zone.chaises[i].Y, zone.LngCh, zone.LargCh);
                g.DrawString((zone.chaises[i].Num).ToString(), new Font(FontFamily.GenericSansSerif, 8), Brushes.Black, rect[0]);
                g.DrawRectangles(pen, rect);
            }
        }
        public static void DrawZone(Panel panel, ListBox data, Pen pen) {
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
                DrawService.DrawZone(panel, points, pen);
                int dim = 5;
                int moitie = dim / 2;
                panel.CreateGraphics().FillRectangle(Brushes.Red, float.Parse(point[0]) - moitie, float.Parse(point[1]) - moitie, dim, dim);
            }
        }

        public static void removePoint(Keys keyCode, ListBox points, Panel panel, Pen pen) {
            if (keyCode.ToString().Equals("delete", StringComparison.CurrentCultureIgnoreCase) && points.SelectedIndex >= 0) {
                points.Items.RemoveAt(points.SelectedIndex);
                panel.Refresh();
                DrawService.DrawZone(panel, points, pen);
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
