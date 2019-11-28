using stade.models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stade.services {
    class StadeService {
        public static Zone simuler(PointF[] points, int num1, string dir, string sens, float lngCh, float largCh, float espAv, float espCote) {
            List<PointF> pts = points.OfType<PointF>().ToList();
            float minX = pts.Min<PointF>(point => point.X);
            float minY = pts.Min<PointF>(point => point.Y);
            float maxX = pts.Max<PointF>(point => point.X);
            float maxY = pts.Max<PointF>(point => point.Y);
            GraphicsPath path = new GraphicsPath();
            path.AddPolygon(points);
            Region region = new Region(path);
            Zone zone = new Zone("", "", "", num1, dir, sens, lngCh, largCh, espAv, espCote);
            typeof(StadeService).GetMethod(dir + "_" + sens).Invoke(null, new object[] { 
                region,
                path.GetBounds(),
                zone,
                num1,
                lngCh,
                largCh,
                espAv,
                espCote
            });
            return zone;
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
    }
}
