namespace stade.views {
	partial class ReservationView {
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.date = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.evenement = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.zone = new System.Windows.Forms.ComboBox();
			this.voir = new System.Windows.Forms.Button();
			this.table = new System.Windows.Forms.DataGridView();
			this.reserver = new System.Windows.Forms.TabPage();
			this.zoneRes = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.dateRes = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.evnm = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.panel = new System.Windows.Forms.Panel();
			this.reserverBtn = new System.Windows.Forms.Button();
			this.des = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.numChaise = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.pu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.estimation = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.prixTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sitActuelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.prixActuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
			this.reserver.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.reserver);
			this.tabControl1.Location = new System.Drawing.Point(12, 13);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1079, 570);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.date);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.evenement);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.zone);
			this.tabPage1.Controls.Add(this.voir);
			this.tabPage1.Controls.Add(this.table);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1071, 541);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Rapprochement";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 17);
			this.label1.TabIndex = 13;
			this.label1.Text = "Date";
			// 
			// date
			// 
			this.date.Location = new System.Drawing.Point(47, 6);
			this.date.Name = "date";
			this.date.Size = new System.Drawing.Size(160, 22);
			this.date.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(213, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 17);
			this.label2.TabIndex = 14;
			this.label2.Text = "Evenement";
			// 
			// evenement
			// 
			this.evenement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.evenement.FormattingEnabled = true;
			this.evenement.Location = new System.Drawing.Point(298, 5);
			this.evenement.Name = "evenement";
			this.evenement.Size = new System.Drawing.Size(121, 24);
			this.evenement.TabIndex = 10;
			this.evenement.SelectedIndexChanged += new System.EventHandler(this.evenement_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(425, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 17);
			this.label3.TabIndex = 15;
			this.label3.Text = "Zone";
			// 
			// zone
			// 
			this.zone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.zone.FormattingEnabled = true;
			this.zone.Location = new System.Drawing.Point(472, 5);
			this.zone.Name = "zone";
			this.zone.Size = new System.Drawing.Size(121, 24);
			this.zone.TabIndex = 11;
			// 
			// voir
			// 
			this.voir.Location = new System.Drawing.Point(599, 5);
			this.voir.Name = "voir";
			this.voir.Size = new System.Drawing.Size(75, 24);
			this.voir.TabIndex = 12;
			this.voir.Text = "Voir";
			this.voir.UseVisualStyleBackColor = true;
			this.voir.Click += new System.EventHandler(this.voir_Click);
			// 
			// table
			// 
			this.table.AllowUserToAddRows = false;
			this.table.AllowUserToDeleteRows = false;
			this.table.AllowUserToOrderColumns = true;
			this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pu,
            this.estimation,
            this.prixTotal,
            this.sitActuelle,
            this.prixActuel});
			this.table.Location = new System.Drawing.Point(6, 36);
			this.table.Name = "table";
			this.table.ReadOnly = true;
			this.table.RowHeadersWidth = 51;
			this.table.RowTemplate.Height = 24;
			this.table.Size = new System.Drawing.Size(1059, 488);
			this.table.TabIndex = 8;
			// 
			// reserver
			// 
			this.reserver.BackColor = System.Drawing.Color.Gainsboro;
			this.reserver.Controls.Add(this.zoneRes);
			this.reserver.Controls.Add(this.label8);
			this.reserver.Controls.Add(this.dateRes);
			this.reserver.Controls.Add(this.label7);
			this.reserver.Controls.Add(this.evnm);
			this.reserver.Controls.Add(this.label6);
			this.reserver.Controls.Add(this.panel);
			this.reserver.Controls.Add(this.reserverBtn);
			this.reserver.Controls.Add(this.des);
			this.reserver.Controls.Add(this.label5);
			this.reserver.Controls.Add(this.numChaise);
			this.reserver.Controls.Add(this.label4);
			this.reserver.Location = new System.Drawing.Point(4, 25);
			this.reserver.Name = "reserver";
			this.reserver.Padding = new System.Windows.Forms.Padding(3);
			this.reserver.Size = new System.Drawing.Size(1071, 541);
			this.reserver.TabIndex = 1;
			this.reserver.Text = "Reserver";
			// 
			// zoneRes
			// 
			this.zoneRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.zoneRes.FormattingEnabled = true;
			this.zoneRes.Location = new System.Drawing.Point(906, 9);
			this.zoneRes.Name = "zoneRes";
			this.zoneRes.Size = new System.Drawing.Size(121, 24);
			this.zoneRes.TabIndex = 11;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(858, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(41, 17);
			this.label8.TabIndex = 10;
			this.label8.Text = "Zone";
			// 
			// dateRes
			// 
			this.dateRes.Location = new System.Drawing.Point(504, 6);
			this.dateRes.Multiline = true;
			this.dateRes.Name = "dateRes";
			this.dateRes.Size = new System.Drawing.Size(135, 22);
			this.dateRes.TabIndex = 9;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(460, 11);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(38, 17);
			this.label7.TabIndex = 8;
			this.label7.Text = "Date";
			// 
			// evnm
			// 
			this.evnm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.evnm.FormattingEnabled = true;
			this.evnm.Location = new System.Drawing.Point(730, 6);
			this.evnm.Name = "evnm";
			this.evnm.Size = new System.Drawing.Size(121, 24);
			this.evnm.TabIndex = 7;
			this.evnm.SelectedIndexChanged += new System.EventHandler(this.evnm_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(645, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(79, 17);
			this.label6.TabIndex = 6;
			this.label6.Text = "Evenement";
			// 
			// panel
			// 
			this.panel.BackColor = System.Drawing.Color.White;
			this.panel.Location = new System.Drawing.Point(10, 68);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(1055, 467);
			this.panel.TabIndex = 5;
			// 
			// reserverBtn
			// 
			this.reserverBtn.Location = new System.Drawing.Point(921, 39);
			this.reserverBtn.Name = "reserverBtn";
			this.reserverBtn.Size = new System.Drawing.Size(106, 23);
			this.reserverBtn.TabIndex = 4;
			this.reserverBtn.Text = "Reserver";
			this.reserverBtn.UseVisualStyleBackColor = true;
			this.reserverBtn.Click += new System.EventHandler(this.reserverBtn_Click);
			// 
			// des
			// 
			this.des.Location = new System.Drawing.Point(297, 6);
			this.des.Name = "des";
			this.des.Size = new System.Drawing.Size(157, 22);
			this.des.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(209, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 17);
			this.label5.TabIndex = 2;
			this.label5.Text = "Designation";
			// 
			// numChaise
			// 
			this.numChaise.Location = new System.Drawing.Point(95, 5);
			this.numChaise.Name = "numChaise";
			this.numChaise.Size = new System.Drawing.Size(108, 22);
			this.numChaise.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 7);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "Num chaise";
			// 
			// pu
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle1.Format = "N2";
			dataGridViewCellStyle1.NullValue = "0";
			this.pu.DefaultCellStyle = dataGridViewCellStyle1;
			this.pu.HeaderText = "Prix Unitaire";
			this.pu.MinimumWidth = 6;
			this.pu.Name = "pu";
			this.pu.ReadOnly = true;
			this.pu.Width = 125;
			// 
			// estimation
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.estimation.DefaultCellStyle = dataGridViewCellStyle2;
			this.estimation.HeaderText = "Estimation";
			this.estimation.MinimumWidth = 6;
			this.estimation.Name = "estimation";
			this.estimation.ReadOnly = true;
			this.estimation.Width = 125;
			// 
			// prixTotal
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "N2";
			dataGridViewCellStyle3.NullValue = "0";
			this.prixTotal.DefaultCellStyle = dataGridViewCellStyle3;
			this.prixTotal.HeaderText = "Prix total";
			this.prixTotal.MinimumWidth = 6;
			this.prixTotal.Name = "prixTotal";
			this.prixTotal.ReadOnly = true;
			this.prixTotal.Width = 125;
			// 
			// sitActuelle
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.sitActuelle.DefaultCellStyle = dataGridViewCellStyle4;
			this.sitActuelle.HeaderText = "Situation actuelle";
			this.sitActuelle.MinimumWidth = 6;
			this.sitActuelle.Name = "sitActuelle";
			this.sitActuelle.ReadOnly = true;
			this.sitActuelle.Width = 150;
			// 
			// prixActuel
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle5.Format = "N2";
			dataGridViewCellStyle5.NullValue = "0";
			this.prixActuel.DefaultCellStyle = dataGridViewCellStyle5;
			this.prixActuel.HeaderText = "Prix actuel";
			this.prixActuel.MinimumWidth = 6;
			this.prixActuel.Name = "prixActuel";
			this.prixActuel.ReadOnly = true;
			this.prixActuel.Width = 125;
			// 
			// ReservationView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1103, 595);
			this.Controls.Add(this.tabControl1);
			this.Name = "ReservationView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reservation";
			this.Load += new System.EventHandler(this.ReservationView_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
			this.reserver.ResumeLayout(false);
			this.reserver.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage reserver;
		private System.Windows.Forms.DataGridView table;
		private System.Windows.Forms.TextBox numChaise;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.Button reserverBtn;
		private System.Windows.Forms.TextBox des;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox evnm;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox dateRes;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox date;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox evenement;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox zone;
		private System.Windows.Forms.Button voir;
		private System.Windows.Forms.ComboBox zoneRes;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridViewTextBoxColumn pu;
		private System.Windows.Forms.DataGridViewTextBoxColumn estimation;
		private System.Windows.Forms.DataGridViewTextBoxColumn prixTotal;
		private System.Windows.Forms.DataGridViewTextBoxColumn sitActuelle;
		private System.Windows.Forms.DataGridViewTextBoxColumn prixActuel;
	}
}