using stade.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stade {
    public partial class StadeView : Form {
        private Pen pen = new Pen(Color.DarkBlue);
        public StadeView() {
            InitializeComponent();
        }

        private void ajouter_Click(object sender, EventArgs e) {
            if(this.points.Items.Count < 3) {
                return;
            }
            ZoneView zone = new ZoneView();
            zone.Show();
        }

        private void Stade_Resize(object sender, EventArgs e) {
            int margin = 60;
            int w = this.Size.Width - this.insertion.Width - margin + 10;
            int h = this.Size.Height - margin;
            this.panel.Size = new Size(w, h);
            DrawService.DrawZone(this.panel, this.points, this.pen);
        }

        private void panel_MouseClick(object sender, MouseEventArgs e) {
            this.points.Items.Add(e.X + ";" + e.Y);
            DrawService.DrawZone(this.panel, this.points, this.pen);
        }

        private void Stade_Load(object sender, EventArgs e) {
            this.Stade_Resize(sender, e);
        }

        private void points_MouseClick(object sender, MouseEventArgs e) {
            DrawService.markPoint(this.points, this.panel, this.pen);
        }

        private void points_KeyUp(object sender, KeyEventArgs e) {
            DrawService.removePoint(e.KeyCode, this.points, this.panel, this.pen);
        }

        private void clear_Click(object sender, EventArgs e) {
            this.points.Items.Clear();
            this.panel.Refresh();
        }

        private void couleur_Click(object sender, EventArgs e) {
            this.pen.Color = DrawService.getColor(this.pen);
            DrawService.DrawZone(this.panel, this.points, this.pen);
        }
    }
}
