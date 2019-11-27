using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stade
{
    public partial class Zone : Form
    {
        private Dictionary<int, string> dir;
        private Dictionary<int, string> sens1;
        private Dictionary<int, string> sens2;
        public Zone()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            this.dir = new Dictionary<int, string>();
            dir.Add(0, "G a D");
            dir.Add(1, "D a G");
            dir.Add(2, "B en H");
            dir.Add(3, "H en B");
            this.sens1 = new Dictionary<int, string>();
            sens1.Add(0, "G a D");
            sens1.Add(1, "D a G");
            this.sens2 = new Dictionary<int, string>();
            sens2.Add(2, "B en H");
            sens2.Add(3, "H en B");
        }
        private void Zone_Load(object sender, EventArgs e)
        {
            this.direction.DataSource = new BindingSource(this.dir, null);
            this.direction.DisplayMember = "Value";
            this.direction.ValueMember = "key";
            this.direction.SelectedIndex = 0;

            this.sens.DataSource = new BindingSource(this.sens2, null);
            this.sens.DisplayMember = "Value";
            this.sens.ValueMember = "key";
            this.sens.SelectedIndex = 0;
        }

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            points.Items.Add(e.X+ ";" +e.Y);
            DrawZone(this.panel.CreateGraphics());
        }

        private PointF[] GetPoints(ListBox liste)
        {
            int nbPts = liste.Items.Count;
            PointF[] points = new PointF[nbPts];
            string[] point = null;
            float x = 0, y = 0;
            for (int i = 0; i < nbPts; i++)
            {
                point = this.points.Items[i].ToString().Split(';');
                x = float.Parse(point[0]);
                y = float.Parse(point[1]);
                points[i] = new PointF(x, y);
            }
            return points;
        }

        private void DrawZone(Graphics g)
        {
            int nbPts = this.points.Items.Count;
            this.panel.Refresh();
            if(nbPts == 0)
            {
                return;
            }
            PointF[] points = this.GetPoints(this.points);
            if (nbPts == 1)
            {
                g.DrawRectangle(Pens.Gray, points[0].X, points[0].Y, 2, 2);
                return;
            }
            g.DrawPolygon(Pens.Gray, points);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.points.Items.Clear();
            this.panel.Refresh();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {

        }

        private void points_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.ToString().Equals("delete", StringComparison.CurrentCultureIgnoreCase) && this.points.SelectedIndex >= 0)
            {
                this.points.Items.RemoveAt(this.points.SelectedIndex);
                this.DrawZone(this.panel.CreateGraphics());
            }
        }

        private void points_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.points.SelectedIndex >= 0)
            {
                string[] point = this.points.SelectedItem.ToString().Split(';');
                this.panel.Refresh();
                Graphics g = this.panel.CreateGraphics();
                this.DrawZone(g);
                g.DrawRectangle(Pens.Red, float.Parse(point[0]), float.Parse(point[1]), 3, 3);
            }
        }

        private void simuler_Click(object sender, EventArgs e)
        {
            if(this.points.Items.Count < 3)
            {
                return;
            }
            List<PointF> points = this.GetPoints(this.points).OfType<PointF>().ToList();
            float minX = points.Min<PointF>(point => point.X);
            float minY = points.Min<PointF>(point => point.Y);
            float maxX = points.Max<PointF>(point => point.X);
            float maxY = points.Max<PointF>(point => point.Y);

            Graphics g = this.panel.CreateGraphics();
            this.DrawZone(g);
            g.DrawRectangle(Pens.Red, minX, minY, maxX - minX, maxY - minY);
            float x = 0;
            float y = 0;
            float lng = (float)(this.lngCh.Value);
            float larg = (float)(this.largCh.Value);
            float espAv = (float)(this.espAv.Value);
            float espCote = (float)(this.espCote.Value);
            y = minY + espAv;
            while (y + lng <= maxY)
            {
                x = minX + espCote;
                while(x + larg <= maxX)
                {
                    g.DrawRectangle(Pens.Red, x, y, lng, larg);
                    x += lng + espCote;
                }
                y += larg + espAv;
            }
        }

        private void direction_SelectedValueChanged(object sender, EventArgs e)
        {
            if(((KeyValuePair<int, string>)this.direction.SelectedItem).Key > 1)
            {
                this.sens.DataSource = new BindingSource(this.sens1, null);
            } else
            {
                this.sens.DataSource = new BindingSource(this.sens2, null);
            }
        }
    }
}