namespace stade.views {
	partial class InsertView {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.tabcontrol1 = new System.Windows.Forms.TabControl();
			this.tabEvent = new System.Windows.Forms.TabPage();
			this.insertZone = new System.Windows.Forms.LinkLabel();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.evnmts = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.l = new System.Windows.Forms.Label();
			this.voir = new System.Windows.Forms.Button();
			this.stades = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.msgEvent = new System.Windows.Forms.Label();
			this.insererEvent = new System.Windows.Forms.Button();
			this.stadeEvent = new System.Windows.Forms.ComboBox();
			this.desEvent = new System.Windows.Forms.TextBox();
			this.dateEvent = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tabMedia = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.media = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.mediaEvent = new System.Windows.Forms.ComboBox();
			this.ajouterMedia = new System.Windows.Forms.Button();
			this.mediaDate = new System.Windows.Forms.TextBox();
			this.label120 = new System.Windows.Forms.Label();
			this.label123 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.prixMedia = new System.Windows.Forms.NumericUpDown();
			this.insertMedia = new System.Windows.Forms.Button();
			this.desMedia = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tabcontrol1.SuspendLayout();
			this.tabEvent.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabMedia.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.prixMedia)).BeginInit();
			this.SuspendLayout();
			// 
			// tabcontrol1
			// 
			this.tabcontrol1.Controls.Add(this.tabEvent);
			this.tabcontrol1.Controls.Add(this.tabMedia);
			this.tabcontrol1.Location = new System.Drawing.Point(12, 12);
			this.tabcontrol1.Name = "tabcontrol1";
			this.tabcontrol1.SelectedIndex = 0;
			this.tabcontrol1.Size = new System.Drawing.Size(1079, 571);
			this.tabcontrol1.TabIndex = 0;
			// 
			// tabEvent
			// 
			this.tabEvent.Controls.Add(this.insertZone);
			this.tabEvent.Controls.Add(this.groupBox4);
			this.tabEvent.Controls.Add(this.groupBox1);
			this.tabEvent.Location = new System.Drawing.Point(4, 25);
			this.tabEvent.Name = "tabEvent";
			this.tabEvent.Padding = new System.Windows.Forms.Padding(3);
			this.tabEvent.Size = new System.Drawing.Size(1071, 542);
			this.tabEvent.TabIndex = 0;
			this.tabEvent.Text = "Evenement";
			this.tabEvent.UseVisualStyleBackColor = true;
			// 
			// insertZone
			// 
			this.insertZone.AutoSize = true;
			this.insertZone.Location = new System.Drawing.Point(964, 18);
			this.insertZone.Name = "insertZone";
			this.insertZone.Size = new System.Drawing.Size(87, 17);
			this.insertZone.TabIndex = 6;
			this.insertZone.TabStop = true;
			this.insertZone.Text = "Inserer zone";
			this.insertZone.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.insertZone_LinkClicked);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.evnmts);
			this.groupBox4.Controls.Add(this.label8);
			this.groupBox4.Controls.Add(this.l);
			this.groupBox4.Controls.Add(this.voir);
			this.groupBox4.Controls.Add(this.stades);
			this.groupBox4.Location = new System.Drawing.Point(386, 18);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(338, 191);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Evenement existant";
			// 
			// evnmts
			// 
			this.evnmts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.evnmts.FormattingEnabled = true;
			this.evnmts.Location = new System.Drawing.Point(148, 71);
			this.evnmts.Name = "evnmts";
			this.evnmts.Size = new System.Drawing.Size(159, 24);
			this.evnmts.TabIndex = 4;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(7, 80);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(79, 17);
			this.label8.TabIndex = 3;
			this.label8.Text = "Evenement";
			// 
			// l
			// 
			this.l.AutoSize = true;
			this.l.Location = new System.Drawing.Point(7, 41);
			this.l.Name = "l";
			this.l.Size = new System.Drawing.Size(45, 17);
			this.l.TabIndex = 2;
			this.l.Text = "Stade";
			// 
			// voir
			// 
			this.voir.Location = new System.Drawing.Point(193, 111);
			this.voir.Name = "voir";
			this.voir.Size = new System.Drawing.Size(114, 24);
			this.voir.TabIndex = 1;
			this.voir.Text = "Voir";
			this.voir.UseVisualStyleBackColor = true;
			this.voir.Click += new System.EventHandler(this.voir_Click);
			// 
			// stades
			// 
			this.stades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.stades.FormattingEnabled = true;
			this.stades.Location = new System.Drawing.Point(148, 34);
			this.stades.Name = "stades";
			this.stades.Size = new System.Drawing.Size(159, 24);
			this.stades.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.msgEvent);
			this.groupBox1.Controls.Add(this.insererEvent);
			this.groupBox1.Controls.Add(this.stadeEvent);
			this.groupBox1.Controls.Add(this.desEvent);
			this.groupBox1.Controls.Add(this.dateEvent);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(18, 18);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(351, 191);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Nouvelle evenement";
			// 
			// msgEvent
			// 
			this.msgEvent.AutoSize = true;
			this.msgEvent.ForeColor = System.Drawing.Color.ForestGreen;
			this.msgEvent.Location = new System.Drawing.Point(9, 158);
			this.msgEvent.Name = "msgEvent";
			this.msgEvent.Size = new System.Drawing.Size(0, 17);
			this.msgEvent.TabIndex = 7;
			// 
			// insererEvent
			// 
			this.insererEvent.Location = new System.Drawing.Point(220, 155);
			this.insererEvent.Name = "insererEvent";
			this.insererEvent.Size = new System.Drawing.Size(113, 23);
			this.insererEvent.TabIndex = 6;
			this.insererEvent.Text = "Inserer";
			this.insererEvent.UseVisualStyleBackColor = true;
			this.insererEvent.Click += new System.EventHandler(this.insererEvent_Click);
			// 
			// stadeEvent
			// 
			this.stadeEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.stadeEvent.FormattingEnabled = true;
			this.stadeEvent.Location = new System.Drawing.Point(110, 112);
			this.stadeEvent.Name = "stadeEvent";
			this.stadeEvent.Size = new System.Drawing.Size(223, 24);
			this.stadeEvent.TabIndex = 5;
			// 
			// desEvent
			// 
			this.desEvent.Location = new System.Drawing.Point(110, 75);
			this.desEvent.Name = "desEvent";
			this.desEvent.Size = new System.Drawing.Size(223, 22);
			this.desEvent.TabIndex = 4;
			this.desEvent.Text = "Fete";
			// 
			// dateEvent
			// 
			this.dateEvent.Location = new System.Drawing.Point(110, 37);
			this.dateEvent.Name = "dateEvent";
			this.dateEvent.Size = new System.Drawing.Size(223, 22);
			this.dateEvent.TabIndex = 3;
			this.dateEvent.Text = "25/12/2019 14:00";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Date";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Stade";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Designation";
			// 
			// tabMedia
			// 
			this.tabMedia.Controls.Add(this.groupBox3);
			this.tabMedia.Controls.Add(this.groupBox2);
			this.tabMedia.Location = new System.Drawing.Point(4, 25);
			this.tabMedia.Name = "tabMedia";
			this.tabMedia.Padding = new System.Windows.Forms.Padding(3);
			this.tabMedia.Size = new System.Drawing.Size(1071, 542);
			this.tabMedia.TabIndex = 1;
			this.tabMedia.Text = "Media";
			this.tabMedia.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.media);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.mediaEvent);
			this.groupBox3.Controls.Add(this.ajouterMedia);
			this.groupBox3.Controls.Add(this.mediaDate);
			this.groupBox3.Controls.Add(this.label120);
			this.groupBox3.Controls.Add(this.label123);
			this.groupBox3.Location = new System.Drawing.Point(343, 6);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(722, 74);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Média avec evenement";
			// 
			// media
			// 
			this.media.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.media.FormattingEnabled = true;
			this.media.Location = new System.Drawing.Point(445, 33);
			this.media.Name = "media";
			this.media.Size = new System.Drawing.Size(121, 24);
			this.media.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(393, 42);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 17);
			this.label4.TabIndex = 8;
			this.label4.Text = "Media";
			// 
			// mediaEvent
			// 
			this.mediaEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.mediaEvent.FormattingEnabled = true;
			this.mediaEvent.Location = new System.Drawing.Point(259, 33);
			this.mediaEvent.Name = "mediaEvent";
			this.mediaEvent.Size = new System.Drawing.Size(121, 24);
			this.mediaEvent.TabIndex = 7;
			// 
			// ajouterMedia
			// 
			this.ajouterMedia.Location = new System.Drawing.Point(583, 33);
			this.ajouterMedia.Name = "ajouterMedia";
			this.ajouterMedia.Size = new System.Drawing.Size(128, 24);
			this.ajouterMedia.TabIndex = 6;
			this.ajouterMedia.Text = "Ajouter";
			this.ajouterMedia.UseVisualStyleBackColor = true;
			this.ajouterMedia.Click += new System.EventHandler(this.ajouterMedia_Click);
			// 
			// mediaDate
			// 
			this.mediaDate.Location = new System.Drawing.Point(50, 35);
			this.mediaDate.Name = "mediaDate";
			this.mediaDate.Size = new System.Drawing.Size(113, 22);
			this.mediaDate.TabIndex = 4;
			this.mediaDate.Text = "01/12/2019";
			// 
			// label120
			// 
			this.label120.AutoSize = true;
			this.label120.Location = new System.Drawing.Point(173, 42);
			this.label120.Name = "label120";
			this.label120.Size = new System.Drawing.Size(79, 17);
			this.label120.TabIndex = 2;
			this.label120.Text = "Evenement";
			// 
			// label123
			// 
			this.label123.AutoSize = true;
			this.label123.Location = new System.Drawing.Point(6, 40);
			this.label123.Name = "label123";
			this.label123.Size = new System.Drawing.Size(38, 17);
			this.label123.TabIndex = 1;
			this.label123.Text = "Date";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.prixMedia);
			this.groupBox2.Controls.Add(this.insertMedia);
			this.groupBox2.Controls.Add(this.desMedia);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Location = new System.Drawing.Point(6, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(320, 132);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Nouvelle média";
			// 
			// prixMedia
			// 
			this.prixMedia.Location = new System.Drawing.Point(110, 52);
			this.prixMedia.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
			this.prixMedia.Name = "prixMedia";
			this.prixMedia.Size = new System.Drawing.Size(204, 22);
			this.prixMedia.TabIndex = 7;
			this.prixMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.prixMedia.ThousandsSeparator = true;
			this.prixMedia.Value = new decimal(new int[] {
            2500,
            0,
            0,
            0});
			// 
			// insertMedia
			// 
			this.insertMedia.Location = new System.Drawing.Point(201, 80);
			this.insertMedia.Name = "insertMedia";
			this.insertMedia.Size = new System.Drawing.Size(113, 23);
			this.insertMedia.TabIndex = 6;
			this.insertMedia.Text = "Inserer";
			this.insertMedia.UseVisualStyleBackColor = true;
			this.insertMedia.Click += new System.EventHandler(this.insertMedia_Click);
			// 
			// desMedia
			// 
			this.desMedia.Location = new System.Drawing.Point(110, 21);
			this.desMedia.Name = "desMedia";
			this.desMedia.Size = new System.Drawing.Size(204, 22);
			this.desMedia.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 57);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(31, 17);
			this.label5.TabIndex = 2;
			this.label5.Text = "Prix";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 26);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 17);
			this.label6.TabIndex = 1;
			this.label6.Text = "Designation";
			// 
			// InsertView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1103, 595);
			this.Controls.Add(this.tabcontrol1);
			this.Name = "InsertView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Insertion";
			this.Load += new System.EventHandler(this.Insertion_Load);
			this.tabcontrol1.ResumeLayout(false);
			this.tabEvent.ResumeLayout(false);
			this.tabEvent.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabMedia.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.prixMedia)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabcontrol1;
		private System.Windows.Forms.TabPage tabEvent;
		private System.Windows.Forms.TabPage tabMedia;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox stadeEvent;
		private System.Windows.Forms.TextBox desEvent;
		private System.Windows.Forms.TextBox dateEvent;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button insererEvent;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.NumericUpDown prixMedia;
		private System.Windows.Forms.Button insertMedia;
		private System.Windows.Forms.TextBox desMedia;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ComboBox media;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button ajouterMedia;
		private System.Windows.Forms.TextBox mediaDate;
		private System.Windows.Forms.Label label120;
		private System.Windows.Forms.Label label123;
		private System.Windows.Forms.Label msgEvent;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.ComboBox evnmts;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label l;
		private System.Windows.Forms.Button voir;
		private System.Windows.Forms.ComboBox stades;
		private System.Windows.Forms.LinkLabel insertZone;
		private System.Windows.Forms.ComboBox mediaEvent;
	}
}