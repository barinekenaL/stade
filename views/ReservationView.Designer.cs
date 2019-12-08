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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.estimationTable = new System.Windows.Forms.DataGridView();
			this.estimation = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.prixTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sitActuelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.prixActuel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.date = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.evenement = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.zone = new System.Windows.Forms.ComboBox();
			this.voir = new System.Windows.Forms.Button();
			this.reserver = new System.Windows.Forms.TabPage();
			this.panel = new System.Windows.Forms.Panel();
			this.reserverBtn = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.numChaise = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.estimationTable)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
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
			this.tabPage1.Controls.Add(this.estimationTable);
			this.tabPage1.Controls.Add(this.flowLayoutPanel1);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1071, 541);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Rapprochement";
			// 
			// estimationTable
			// 
			this.estimationTable.AllowUserToAddRows = false;
			this.estimationTable.AllowUserToDeleteRows = false;
			this.estimationTable.AllowUserToOrderColumns = true;
			this.estimationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.estimationTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.estimation,
            this.prixTotal,
            this.sitActuelle,
            this.prixActuel});
			this.estimationTable.Location = new System.Drawing.Point(6, 47);
			this.estimationTable.Name = "estimationTable";
			this.estimationTable.ReadOnly = true;
			this.estimationTable.RowHeadersWidth = 51;
			this.estimationTable.RowTemplate.Height = 24;
			this.estimationTable.Size = new System.Drawing.Size(554, 488);
			this.estimationTable.TabIndex = 8;
			// 
			// estimation
			// 
			this.estimation.HeaderText = "Estimation";
			this.estimation.MinimumWidth = 6;
			this.estimation.Name = "estimation";
			this.estimation.ReadOnly = true;
			this.estimation.Width = 125;
			// 
			// prixTotal
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle1.Format = "N2";
			dataGridViewCellStyle1.NullValue = "0";
			this.prixTotal.DefaultCellStyle = dataGridViewCellStyle1;
			this.prixTotal.HeaderText = "Prix total";
			this.prixTotal.MinimumWidth = 6;
			this.prixTotal.Name = "prixTotal";
			this.prixTotal.ReadOnly = true;
			this.prixTotal.Width = 125;
			// 
			// sitActuelle
			// 
			this.sitActuelle.HeaderText = "Situation actuelle";
			this.sitActuelle.MinimumWidth = 6;
			this.sitActuelle.Name = "sitActuelle";
			this.sitActuelle.ReadOnly = true;
			this.sitActuelle.Width = 150;
			// 
			// prixActuel
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Format = "N2";
			dataGridViewCellStyle2.NullValue = "0";
			this.prixActuel.DefaultCellStyle = dataGridViewCellStyle2;
			this.prixActuel.HeaderText = "Prix actuel";
			this.prixActuel.MinimumWidth = 6;
			this.prixActuel.Name = "prixActuel";
			this.prixActuel.ReadOnly = true;
			this.prixActuel.Width = 125;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this.date);
			this.flowLayoutPanel1.Controls.Add(this.label2);
			this.flowLayoutPanel1.Controls.Add(this.evenement);
			this.flowLayoutPanel1.Controls.Add(this.label3);
			this.flowLayoutPanel1.Controls.Add(this.zone);
			this.flowLayoutPanel1.Controls.Add(this.voir);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 6);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1059, 35);
			this.flowLayoutPanel1.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Date";
			// 
			// date
			// 
			this.date.Location = new System.Drawing.Point(47, 3);
			this.date.Name = "date";
			this.date.Size = new System.Drawing.Size(100, 22);
			this.date.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(153, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Evenement";
			// 
			// evenement
			// 
			this.evenement.FormattingEnabled = true;
			this.evenement.Location = new System.Drawing.Point(238, 3);
			this.evenement.Name = "evenement";
			this.evenement.Size = new System.Drawing.Size(121, 24);
			this.evenement.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(365, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "Zone";
			// 
			// zone
			// 
			this.zone.FormattingEnabled = true;
			this.zone.Location = new System.Drawing.Point(412, 3);
			this.zone.Name = "zone";
			this.zone.Size = new System.Drawing.Size(121, 24);
			this.zone.TabIndex = 2;
			// 
			// voir
			// 
			this.voir.Location = new System.Drawing.Point(539, 3);
			this.voir.Name = "voir";
			this.voir.Size = new System.Drawing.Size(75, 23);
			this.voir.TabIndex = 3;
			this.voir.Text = "Voir";
			this.voir.UseVisualStyleBackColor = true;
			// 
			// reserver
			// 
			this.reserver.BackColor = System.Drawing.Color.Gainsboro;
			this.reserver.Controls.Add(this.panel);
			this.reserver.Controls.Add(this.reserverBtn);
			this.reserver.Controls.Add(this.textBox1);
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
			// panel
			// 
			this.panel.BackColor = System.Drawing.Color.White;
			this.panel.Location = new System.Drawing.Point(10, 35);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(1055, 500);
			this.panel.TabIndex = 5;
			// 
			// reserverBtn
			// 
			this.reserverBtn.Location = new System.Drawing.Point(767, 5);
			this.reserverBtn.Name = "reserverBtn";
			this.reserverBtn.Size = new System.Drawing.Size(106, 23);
			this.reserverBtn.TabIndex = 4;
			this.reserverBtn.Text = "Reserver";
			this.reserverBtn.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(587, 7);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(159, 22);
			this.textBox1.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(498, 10);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 17);
			this.label5.TabIndex = 2;
			this.label5.Text = "Designation";
			// 
			// numChaise
			// 
			this.numChaise.Location = new System.Drawing.Point(117, 7);
			this.numChaise.Name = "numChaise";
			this.numChaise.Size = new System.Drawing.Size(355, 22);
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
			// ReservationView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1103, 595);
			this.Controls.Add(this.tabControl1);
			this.Name = "ReservationView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reservation";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.estimationTable)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.reserver.ResumeLayout(false);
			this.reserver.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage reserver;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button voir;
		private System.Windows.Forms.ComboBox zone;
		private System.Windows.Forms.ComboBox evenement;
		private System.Windows.Forms.TextBox date;
		private System.Windows.Forms.DataGridView estimationTable;
		private System.Windows.Forms.DataGridViewTextBoxColumn estimation;
		private System.Windows.Forms.DataGridViewTextBoxColumn prixTotal;
		private System.Windows.Forms.DataGridViewTextBoxColumn sitActuelle;
		private System.Windows.Forms.DataGridViewTextBoxColumn prixActuel;
		private System.Windows.Forms.TextBox numChaise;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.Button reserverBtn;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
	}
}