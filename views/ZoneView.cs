using stade.models;
using stade.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stade {
    public partial class ZoneView : Form {
        private Dictionary<string, string> dir;
        private Dictionary<string, string> sens1;
        private Dictionary<string, string> sens2;
        private Pen pen = new Pen(Color.DarkGray);
        public ZoneView() {
            InitializeComponent();
            InitData();
        }

        private void InitData() {
            this.dir = new Dictionary<string, string>();
            dir.Add("Gd", "G a D");
            dir.Add("Dg", "D a G");
            dir.Add("Bh", "B en H");
            dir.Add("Hb", "H en B");
            this.sens1 = new Dictionary<string, string>();
            sens1.Add("gd", "G a D");
            sens1.Add("dg", "D a G");
            this.sens2 = new Dictionary<string, string>();
            sens2.Add("hb", "H en B");
            sens2.Add("bh", "B en H");
        }
        private void Zone_Load(object sender, EventArgs e) {
            this.direction.DataSource = new BindingSource(this.dir, null);
            this.direction.DisplayMember = "Value";
            this.direction.ValueMember = "key";
            this.direction.SelectedIndex = 0;

            this.sens.DataSource = new BindingSource(this.sens2, null);
            this.sens.DisplayMember = "Value";
            this.sens.ValueMember = "key";
            this.sens.SelectedIndex = 0;
            this.Zone_Resize(sender, e);
        }

        private void panel_MouseClick(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Right) {
                
            } else {
                points.Items.Add(e.X + ";" + e.Y);
                DrawService.DrawZone(this.panel, this.points, this.pen);
            }
        }

        private void clear_Click(object sender, EventArgs e) {
            this.points.Items.Clear();
            this.panel.Refresh();
        }

        private void ajouter_Click(object sender, EventArgs e) {
            
        }

        private void points_KeyUp(object sender, KeyEventArgs e) {
            DrawService.removePoint(e.KeyCode, this.points, this.panel, this.pen);
        }

        private void points_MouseClick(object sender, MouseEventArgs e) {
            DrawService.markPoint(this.points, this.panel, this.pen);
        }

        private void simuler_Click(object sender, EventArgs e) {
            if (this.points.Items.Count < 3) {
                return;
            }
            Zone zone = StadeService.simuler(
                DrawService.GetPoints(this.points),
                Convert.ToInt32(this.num1.Value),
                ((KeyValuePair<string, string>)this.direction.SelectedItem).Key,
                ((KeyValuePair<string, string>)this.sens.SelectedItem).Key,
                Convert.ToSingle(this.lngCh.Value),
                Convert.ToSingle(this.largCh.Value),
                Convert.ToSingle(this.espAv.Value),
                Convert.ToSingle(this.espCote.Value)
            );
            DrawService.DrawZone(this.panel, this.points, this.pen);
            DrawService.Show(this.panel, zone, new Pen(Color.Red));
        }

        private void direction_SelectedValueChanged(object sender, EventArgs e) {
            string key = ((KeyValuePair<string, string>)this.direction.SelectedItem).Key;
            if (key.Equals("Bh") || key.Equals("Hb")) {
                this.sens.DataSource = new BindingSource(this.sens1, null);
            } else {
                this.sens.DataSource = new BindingSource(this.sens2, null);
            }
        }

        private void Zone_Resize(object sender, EventArgs e) {
            int margin = 60;
            int w = this.Size.Width - this.insertion.Width - margin + 10;
            int h = this.Size.Height - margin;
            this.panel.Size = new Size(w, h);
            DrawService.DrawZone(this.panel, this.points, this.pen);
        }

        private void couleur_Click(object sender, EventArgs e) {
            this.pen.Color = DrawService.getColor(this.pen);
            DrawService.DrawZone(this.panel, this.points, this.pen);
        }
    }
}