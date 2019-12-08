namespace stade
{
    partial class ZoneView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.insertion = new System.Windows.Forms.GroupBox();
			this.prixEstimer = new System.Windows.Forms.NumericUpDown();
			this.label15 = new System.Windows.Forms.Label();
			this.estimation = new System.Windows.Forms.NumericUpDown();
			this.pu = new System.Windows.Forms.NumericUpDown();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.evenm = new System.Windows.Forms.ComboBox();
			this.err = new System.Windows.Forms.Label();
			this.couleur = new System.Windows.Forms.Button();
			this.simuler = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.espCote = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.lngCh = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.largCh = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.espAv = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.num1 = new System.Windows.Forms.NumericUpDown();
			this.sens = new System.Windows.Forms.ComboBox();
			this.direction = new System.Windows.Forms.ComboBox();
			this.stades = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.enregistrer = new System.Windows.Forms.Button();
			this.clear = new System.Windows.Forms.Button();
			this.points = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.desZone = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel = new System.Windows.Forms.Panel();
			this.label11 = new System.Windows.Forms.Label();
			this.nbPlace = new System.Windows.Forms.NumericUpDown();
			this.insertion.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.prixEstimer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.estimation)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pu)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.espCote)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lngCh)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.largCh)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.espAv)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nbPlace)).BeginInit();
			this.SuspendLayout();
			// 
			// insertion
			// 
			this.insertion.Controls.Add(this.nbPlace);
			this.insertion.Controls.Add(this.label11);
			this.insertion.Controls.Add(this.prixEstimer);
			this.insertion.Controls.Add(this.label15);
			this.insertion.Controls.Add(this.estimation);
			this.insertion.Controls.Add(this.pu);
			this.insertion.Controls.Add(this.label14);
			this.insertion.Controls.Add(this.label13);
			this.insertion.Controls.Add(this.label12);
			this.insertion.Controls.Add(this.evenm);
			this.insertion.Controls.Add(this.err);
			this.insertion.Controls.Add(this.couleur);
			this.insertion.Controls.Add(this.simuler);
			this.insertion.Controls.Add(this.groupBox2);
			this.insertion.Controls.Add(this.label6);
			this.insertion.Controls.Add(this.label5);
			this.insertion.Controls.Add(this.label4);
			this.insertion.Controls.Add(this.num1);
			this.insertion.Controls.Add(this.sens);
			this.insertion.Controls.Add(this.direction);
			this.insertion.Controls.Add(this.stades);
			this.insertion.Controls.Add(this.label3);
			this.insertion.Controls.Add(this.enregistrer);
			this.insertion.Controls.Add(this.clear);
			this.insertion.Controls.Add(this.points);
			this.insertion.Controls.Add(this.label2);
			this.insertion.Controls.Add(this.desZone);
			this.insertion.Controls.Add(this.label1);
			this.insertion.Location = new System.Drawing.Point(12, 12);
			this.insertion.Name = "insertion";
			this.insertion.Size = new System.Drawing.Size(326, 590);
			this.insertion.TabIndex = 0;
			this.insertion.TabStop = false;
			this.insertion.Text = "zone";
			// 
			// prixEstimer
			// 
			this.prixEstimer.BackColor = System.Drawing.Color.LemonChiffon;
			this.prixEstimer.DecimalPlaces = 2;
			this.prixEstimer.Enabled = false;
			this.prixEstimer.ForeColor = System.Drawing.Color.Black;
			this.prixEstimer.Location = new System.Drawing.Point(125, 345);
			this.prixEstimer.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.prixEstimer.Name = "prixEstimer";
			this.prixEstimer.Size = new System.Drawing.Size(195, 22);
			this.prixEstimer.TabIndex = 35;
			this.prixEstimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.prixEstimer.ThousandsSeparator = true;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(6, 350);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(81, 17);
			this.label15.TabIndex = 34;
			this.label15.Text = "Prix estimer";
			// 
			// estimation
			// 
			this.estimation.DecimalPlaces = 2;
			this.estimation.Location = new System.Drawing.Point(125, 289);
			this.estimation.Name = "estimation";
			this.estimation.Size = new System.Drawing.Size(195, 22);
			this.estimation.TabIndex = 32;
			this.estimation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.estimation.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
			// 
			// pu
			// 
			this.pu.DecimalPlaces = 2;
			this.pu.Location = new System.Drawing.Point(125, 317);
			this.pu.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
			this.pu.Name = "pu";
			this.pu.Size = new System.Drawing.Size(195, 22);
			this.pu.TabIndex = 33;
			this.pu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.pu.ThousandsSeparator = true;
			this.pu.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(6, 322);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(84, 17);
			this.label14.TabIndex = 31;
			this.label14.Text = "Prix Unitaire";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(6, 294);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(99, 17);
			this.label13.TabIndex = 29;
			this.label13.Text = "Estimation (%)";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(6, 58);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(79, 17);
			this.label12.TabIndex = 28;
			this.label12.Text = "Evenement";
			// 
			// evenm
			// 
			this.evenm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.evenm.FormattingEnabled = true;
			this.evenm.Location = new System.Drawing.Point(125, 51);
			this.evenm.Name = "evenm";
			this.evenm.Size = new System.Drawing.Size(195, 24);
			this.evenm.TabIndex = 27;
			this.evenm.SelectedIndexChanged += new System.EventHandler(this.evenm_SelectedIndexChanged);
			// 
			// err
			// 
			this.err.AutoSize = true;
			this.err.ForeColor = System.Drawing.Color.Red;
			this.err.Location = new System.Drawing.Point(9, 344);
			this.err.Name = "err";
			this.err.Size = new System.Drawing.Size(0, 17);
			this.err.TabIndex = 26;
			// 
			// couleur
			// 
			this.couleur.Location = new System.Drawing.Point(6, 141);
			this.couleur.Name = "couleur";
			this.couleur.Size = new System.Drawing.Size(75, 23);
			this.couleur.TabIndex = 24;
			this.couleur.Text = "couleur";
			this.couleur.UseVisualStyleBackColor = true;
			this.couleur.Click += new System.EventHandler(this.couleur_Click);
			// 
			// simuler
			// 
			this.simuler.Location = new System.Drawing.Point(6, 551);
			this.simuler.Name = "simuler";
			this.simuler.Size = new System.Drawing.Size(75, 32);
			this.simuler.TabIndex = 21;
			this.simuler.Text = "Simuler";
			this.simuler.UseVisualStyleBackColor = true;
			this.simuler.Click += new System.EventHandler(this.simuler_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.espCote);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.lngCh);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.largCh);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.espAv);
			this.groupBox2.Location = new System.Drawing.Point(12, 408);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(308, 137);
			this.groupBox2.TabIndex = 20;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Chaise";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(8, 112);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(62, 17);
			this.label10.TabIndex = 21;
			this.label10.Text = "esp cote";
			// 
			// espCote
			// 
			this.espCote.Location = new System.Drawing.Point(121, 108);
			this.espCote.Name = "espCote";
			this.espCote.Size = new System.Drawing.Size(181, 22);
			this.espCote.TabIndex = 20;
			this.espCote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.espCote.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(5, 84);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(51, 17);
			this.label9.TabIndex = 19;
			this.label9.Text = "esp Av";
			// 
			// lngCh
			// 
			this.lngCh.Location = new System.Drawing.Point(121, 21);
			this.lngCh.Name = "lngCh";
			this.lngCh.Size = new System.Drawing.Size(181, 22);
			this.lngCh.TabIndex = 11;
			this.lngCh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.lngCh.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(5, 55);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(32, 17);
			this.label8.TabIndex = 18;
			this.label8.Text = "larg";
			// 
			// largCh
			// 
			this.largCh.Location = new System.Drawing.Point(121, 50);
			this.largCh.Name = "largCh";
			this.largCh.Size = new System.Drawing.Size(181, 22);
			this.largCh.TabIndex = 12;
			this.largCh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.largCh.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(5, 26);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(35, 17);
			this.label7.TabIndex = 17;
			this.label7.Text = "long";
			// 
			// espAv
			// 
			this.espAv.Location = new System.Drawing.Point(121, 79);
			this.espAv.Name = "espAv";
			this.espAv.Size = new System.Drawing.Size(181, 22);
			this.espAv.TabIndex = 13;
			this.espAv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.espAv.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 266);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 17);
			this.label6.TabIndex = 16;
			this.label6.Text = "1er Num";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 238);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 17);
			this.label5.TabIndex = 15;
			this.label5.Text = "Sens";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 207);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 17);
			this.label4.TabIndex = 14;
			this.label4.Text = "Direction";
			// 
			// num1
			// 
			this.num1.Location = new System.Drawing.Point(125, 261);
			this.num1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.num1.Name = "num1";
			this.num1.Size = new System.Drawing.Size(195, 22);
			this.num1.TabIndex = 10;
			this.num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.num1.ThousandsSeparator = true;
			this.num1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// sens
			// 
			this.sens.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.sens.FormattingEnabled = true;
			this.sens.Location = new System.Drawing.Point(125, 231);
			this.sens.Name = "sens";
			this.sens.Size = new System.Drawing.Size(195, 24);
			this.sens.TabIndex = 9;
			// 
			// direction
			// 
			this.direction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.direction.FormattingEnabled = true;
			this.direction.Location = new System.Drawing.Point(125, 200);
			this.direction.Name = "direction";
			this.direction.Size = new System.Drawing.Size(195, 24);
			this.direction.TabIndex = 8;
			this.direction.SelectedValueChanged += new System.EventHandler(this.direction_SelectedValueChanged);
			// 
			// stades
			// 
			this.stades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.stades.FormattingEnabled = true;
			this.stades.Location = new System.Drawing.Point(125, 21);
			this.stades.Name = "stades";
			this.stades.Size = new System.Drawing.Size(195, 24);
			this.stades.TabIndex = 7;
			this.stades.SelectedIndexChanged += new System.EventHandler(this.stades_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "Stade";
			// 
			// enregistrer
			// 
			this.enregistrer.Location = new System.Drawing.Point(213, 552);
			this.enregistrer.Name = "enregistrer";
			this.enregistrer.Size = new System.Drawing.Size(101, 32);
			this.enregistrer.TabIndex = 5;
			this.enregistrer.Text = "Enregistrer";
			this.enregistrer.UseVisualStyleBackColor = true;
			this.enregistrer.Click += new System.EventHandler(this.enr_Click);
			// 
			// clear
			// 
			this.clear.Location = new System.Drawing.Point(6, 170);
			this.clear.Name = "clear";
			this.clear.Size = new System.Drawing.Size(75, 23);
			this.clear.TabIndex = 4;
			this.clear.Text = "Clear";
			this.clear.UseVisualStyleBackColor = true;
			this.clear.Click += new System.EventHandler(this.clear_Click);
			// 
			// points
			// 
			this.points.FormattingEnabled = true;
			this.points.ItemHeight = 16;
			this.points.Location = new System.Drawing.Point(125, 110);
			this.points.Name = "points";
			this.points.Size = new System.Drawing.Size(195, 84);
			this.points.TabIndex = 3;
			this.points.MouseClick += new System.Windows.Forms.MouseEventHandler(this.points_MouseClick);
			this.points.KeyUp += new System.Windows.Forms.KeyEventHandler(this.points_KeyUp);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Points";
			// 
			// desZone
			// 
			this.desZone.Location = new System.Drawing.Point(125, 82);
			this.desZone.Name = "desZone";
			this.desZone.Size = new System.Drawing.Size(195, 22);
			this.desZone.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 87);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nom";
			// 
			// panel
			// 
			this.panel.BackColor = System.Drawing.Color.White;
			this.panel.Location = new System.Drawing.Point(344, 12);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(747, 590);
			this.panel.TabIndex = 1;
			this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
			this.panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_MouseClick);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 379);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(65, 17);
			this.label11.TabIndex = 36;
			this.label11.Text = "Nb Place";
			// 
			// nbPlace
			// 
			this.nbPlace.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.nbPlace.Enabled = false;
			this.nbPlace.Location = new System.Drawing.Point(125, 374);
			this.nbPlace.Name = "nbPlace";
			this.nbPlace.Size = new System.Drawing.Size(195, 22);
			this.nbPlace.TabIndex = 37;
			this.nbPlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// ZoneView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1103, 614);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.insertion);
			this.Name = "ZoneView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Zone";
			this.Load += new System.EventHandler(this.Zone_Load);
			this.Resize += new System.EventHandler(this.Zone_Resize);
			this.insertion.ResumeLayout(false);
			this.insertion.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.prixEstimer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.estimation)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pu)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.espCote)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lngCh)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.largCh)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.espAv)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nbPlace)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox insertion;
        private System.Windows.Forms.ListBox points;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox desZone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.ComboBox stades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button simuler;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown espCote;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown lngCh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown largCh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown espAv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num1;
        private System.Windows.Forms.ComboBox sens;
        private System.Windows.Forms.ComboBox direction;
        private System.Windows.Forms.Button couleur;
        private System.Windows.Forms.Label err;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox evenm;
		private System.Windows.Forms.NumericUpDown estimation;
		private System.Windows.Forms.NumericUpDown pu;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.NumericUpDown prixEstimer;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.NumericUpDown nbPlace;
		private System.Windows.Forms.Label label11;
	}
}