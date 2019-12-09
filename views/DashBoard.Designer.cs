namespace stade.views {
	partial class DashBoard {
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.topMedia = new System.Windows.Forms.TabPage();
			this.grph = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.voir = new System.Windows.Forms.Button();
			this.dateFin = new System.Windows.Forms.TextBox();
			this.evenm = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dateDebut = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.topList = new System.Windows.Forms.ListBox();
			this.tabControl1.SuspendLayout();
			this.topMedia.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grph)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.topMedia);
			this.tabControl1.Location = new System.Drawing.Point(13, 13);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1078, 570);
			this.tabControl1.TabIndex = 0;
			// 
			// topMedia
			// 
			this.topMedia.BackColor = System.Drawing.Color.Gainsboro;
			this.topMedia.Controls.Add(this.topList);
			this.topMedia.Controls.Add(this.groupBox1);
			this.topMedia.Controls.Add(this.grph);
			this.topMedia.Controls.Add(this.voir);
			this.topMedia.Controls.Add(this.dateFin);
			this.topMedia.Controls.Add(this.evenm);
			this.topMedia.Controls.Add(this.label3);
			this.topMedia.Controls.Add(this.label2);
			this.topMedia.Controls.Add(this.dateDebut);
			this.topMedia.Controls.Add(this.label1);
			this.topMedia.Location = new System.Drawing.Point(4, 25);
			this.topMedia.Name = "topMedia";
			this.topMedia.Padding = new System.Windows.Forms.Padding(3);
			this.topMedia.Size = new System.Drawing.Size(1070, 541);
			this.topMedia.TabIndex = 1;
			this.topMedia.Text = "Top Media ";
			// 
			// grph
			// 
			this.grph.BorderlineWidth = 3;
			chartArea1.Name = "ChartArea1";
			this.grph.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.grph.Legends.Add(legend1);
			this.grph.Location = new System.Drawing.Point(7, 64);
			this.grph.Name = "grph";
			series1.BorderWidth = 4;
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.IsValueShownAsLabel = true;
			series1.LabelAngle = 10;
			series1.LabelBackColor = System.Drawing.Color.White;
			series1.LabelBorderColor = System.Drawing.Color.White;
			series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
			series1.Legend = "Legend1";
			series1.MarkerSize = 1;
			series1.Name = "Reservation";
			series1.ShadowColor = System.Drawing.Color.Silver;
			series1.ShadowOffset = 1;
			series1.YValuesPerPoint = 2;
			series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
			this.grph.Series.Add(series1);
			this.grph.Size = new System.Drawing.Size(817, 471);
			this.grph.TabIndex = 7;
			this.grph.Text = "chart1";
			// 
			// voir
			// 
			this.voir.Location = new System.Drawing.Point(924, 18);
			this.voir.Name = "voir";
			this.voir.Size = new System.Drawing.Size(131, 23);
			this.voir.TabIndex = 6;
			this.voir.Text = "Voir";
			this.voir.UseVisualStyleBackColor = true;
			this.voir.Click += new System.EventHandler(this.voir_Click);
			// 
			// dateFin
			// 
			this.dateFin.Location = new System.Drawing.Point(518, 20);
			this.dateFin.Name = "dateFin";
			this.dateFin.Size = new System.Drawing.Size(137, 22);
			this.dateFin.TabIndex = 5;
			this.dateFin.Text = "06/12/2019";
			// 
			// evenm
			// 
			this.evenm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.evenm.FormattingEnabled = true;
			this.evenm.Location = new System.Drawing.Point(107, 18);
			this.evenm.Name = "evenm";
			this.evenm.Size = new System.Drawing.Size(121, 24);
			this.evenm.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(22, 25);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "Evenement";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(455, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Date fin";
			// 
			// dateDebut
			// 
			this.dateDebut.Location = new System.Drawing.Point(318, 20);
			this.dateDebut.Name = "dateDebut";
			this.dateDebut.Size = new System.Drawing.Size(131, 22);
			this.dateDebut.TabIndex = 1;
			this.dateDebut.Text = "01/12/2019";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(234, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Date debut";
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(831, 64);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(224, 471);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Top Media";
			// 
			// topList
			// 
			this.topList.FormattingEnabled = true;
			this.topList.ItemHeight = 16;
			this.topList.Location = new System.Drawing.Point(837, 85);
			this.topList.Name = "topList";
			this.topList.Size = new System.Drawing.Size(218, 420);
			this.topList.TabIndex = 0;
			// 
			// DashBoard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1103, 595);
			this.Controls.Add(this.tabControl1);
			this.Name = "DashBoard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DashBoard";
			this.Load += new System.EventHandler(this.DashBoard_Load);
			this.tabControl1.ResumeLayout(false);
			this.topMedia.ResumeLayout(false);
			this.topMedia.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grph)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage topMedia;
		private System.Windows.Forms.ComboBox evenm;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox dateDebut;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox dateFin;
		private System.Windows.Forms.Button voir;
		private System.Windows.Forms.DataVisualization.Charting.Chart grph;
		private System.Windows.Forms.ListBox topList;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}