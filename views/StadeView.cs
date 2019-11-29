using stade.dao;
using stade.models;
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
        private Dictionary<string, string> stds = new Dictionary<string, string>();
        public StadeView() {
            InitializeComponent();
            object[] temp = new CRUD().select("stade", new Stade(), null, null);
            Stade st = null;
            for (int i = 0; i < temp.Length; i++) {
                st = (Stade)temp[i];
                this.stds.Add(st.Id, st.Des);
            }
        }

        private void ajouter_Click(object sender, EventArgs e) {
            if(this.points.Items.Count < 3) {
                this.err.Text = "3 points au min";
                return;
            }
            if(this.desStade.Text == "") {
                this.err.Text = "Designation requis";
                return;
            }
            StadeService.insertStade(this.desStade.Text, StadeService.GetPointString(this.points));
            ZoneView zone = new ZoneView(CRUD.currentId("stade"));
            zone.Show();
            object[] temp = new CRUD().select("stade", new Stade(), null, null);
            Stade st = null;
            this.stds = new Dictionary<string, string>();
            for (int i = 0; i < temp.Length; i++) {
                st = (Stade)temp[i];
                this.stds.Add(st.Id, st.Des);
            }
            this.stades.DataSource = new BindingSource(this.stds, null);
        }

        private void Stade_Resize(object sender, EventArgs e) {
            int margin = 60;
            int w = this.Size.Width - this.insertion.Width - margin + 10;
            int h = this.Size.Height - margin;
            this.panel.Size = new Size(w, h);
            this.panel.Refresh();
            DrawService.DrawPolygon(this.panel, this.points, this.pen);
        }

        private void panel_MouseClick(object sender, MouseEventArgs e) {
            this.points.Items.Add(e.X + ";" + e.Y);
            this.panel.Refresh();
            DrawService.DrawPolygon(this.panel, this.points, this.pen);
        }

        private void Stade_Load(object sender, EventArgs e) {
            this.stades.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Stade_Resize(sender, e);
            if(this.stds.Count > 0) {
                this.stades.DataSource = new BindingSource(this.stds, null);
                this.stades.DisplayMember = "Value";
                this.stades.ValueMember = "key";
                this.stades.SelectedIndex = 0;
            }
        }

        private void points_MouseClick(object sender, MouseEventArgs e) {
            this.panel.Refresh();
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
            this.panel.Refresh();
            DrawService.DrawPolygon(this.panel, this.points, this.pen);
        }

        private void choisir_Click(object sender, EventArgs e) {
            ZoneView zone = new ZoneView(((KeyValuePair<string, string>)this.stades.SelectedItem).Key);
            zone.Show();
        }
    }
}
