using stade.dao;
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
        private Dictionary<string, string> stades = new Dictionary<string, string>();
        private Dictionary<string, string> categories = new Dictionary<string, string>();
        private Pen pen = new Pen(Color.DarkGray);
        private Stade stadeData;


        internal Stade StadeData { get => stadeData; set => stadeData = value; }

        public ZoneView(string idStade) {
            object[] temp = new CRUD().select("stade", new Stade(), null, "id = '" + idStade + "'");
            this.StadeData = (Stade)temp[0];
            temp = new CRUD().select("stade", new Stade(), null, null);
            Stade st = null;
            for (int i = 0; i < temp.Length; i++) {
                st = (Stade)temp[i];
                this.stades.Add(st.Id, st.Des);
            }
            temp = new CRUD().select("categ", new Categ(), null, null);
            Categ ct = null;
            for (int i = 0; i < temp.Length; i++) {
                ct = (Categ)temp[i];
                this.categories.Add(ct.Id, ct.Des);
            }
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

            this.categ.DataSource = new BindingSource(this.categories, null);
            this.categ.DisplayMember = "Value";
            this.categ.ValueMember = "key";
            this.categ.SelectedIndex = 0;

            this.stade.DataSource = new BindingSource(this.stades, null);
            this.stade.DisplayMember = "Value";
            this.stade.ValueMember = "key";
            this.stade.SelectedIndex = this.stades.Keys.ToList<string>().IndexOf(this.stadeData.Id);

            this.Zone_Resize(sender, e);
        }

        private void panel_MouseClick(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Right) {
                
            } else {
                if (!StadeService.inPolygon(stadeData, new int[] { e.X, e.Y})) {
                    return;
                }
                this.points.Items.Add(e.X + ";" + e.Y);
                this.panel.Refresh();
                DrawService.DrawZone(this.panel, this.points, this.pen);
            }
        }

        private void clear_Click(object sender, EventArgs e) {
            this.points.Items.Clear();
            this.panel.Refresh();
        }

        private void ajouter_Click(object sender, EventArgs e) {
            if(this.desZone.Text == "") {
                this.err.Text = "Saisir un nom pour la zone";
                return;
            }
            if(this.points.Items.Count < 3) {
                this.err.Text = "3 points au minimum pour desinner une zone";
                return;
            }
            StadeService.insertZone(
                ((KeyValuePair<string, string>)this.stade.SelectedItem).Key,
                this.desZone.Text, this.points,
                ((KeyValuePair<string, string>)this.direction.SelectedItem).Key,
                ((KeyValuePair<string, string>)this.sens.SelectedItem).Key,
                ((KeyValuePair<string, string>)this.categ.SelectedItem).Key,
                Convert.ToInt32(this.num1.Value),
                Convert.ToSingle(this.lngCh.Value), Convert.ToSingle(this.largCh.Value),
                Convert.ToSingle(this.espAv.Value), Convert.ToSingle(this.espCote.Value)
            );
            ;
        }

        private void points_KeyUp(object sender, KeyEventArgs e) {
            DrawService.removePoint(e.KeyCode, this.points, this.panel, this.pen);
        }

        private void points_MouseClick(object sender, MouseEventArgs e) {
            this.panel.Refresh();
            DrawService.markPoint(this.points, this.panel, this.pen);
        }

        private void simuler_Click(object sender, EventArgs e) {
            if (this.points.Items.Count < 3) {
                return;
            }
            Zone zone = StadeService.simuler(
                StadeService.GetPoints(this.points),
                Convert.ToInt32(this.num1.Value),
                ((KeyValuePair<string, string>)this.direction.SelectedItem).Key,
                ((KeyValuePair<string, string>)this.sens.SelectedItem).Key,
                Convert.ToSingle(this.lngCh.Value),
                Convert.ToSingle(this.largCh.Value),
                Convert.ToSingle(this.espAv.Value),
                Convert.ToSingle(this.espCote.Value)
            );
            this.panel.Refresh();
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
            this.panel.Refresh();
            DrawService.DrawZone(this.panel, this.points, this.pen);
        }

        private void couleur_Click(object sender, EventArgs e) {
            this.pen.Color = DrawService.getColor(this.pen);
            this.panel.Refresh();
            DrawService.DrawZone(this.panel, this.points, this.pen);
        }

        private void panel_Paint(object sender, PaintEventArgs e) {
            DrawService.DrawZone(this.panel, StadeService.GetPoints(this.stadeData.Points), new Pen(Color.Green));
        }
    }
}