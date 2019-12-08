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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.topMedia = new System.Windows.Forms.TabPage();
			this.panel = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.topMedia.SuspendLayout();
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
			this.topMedia.Controls.Add(this.panel);
			this.topMedia.Controls.Add(this.button1);
			this.topMedia.Controls.Add(this.textBox2);
			this.topMedia.Controls.Add(this.comboBox1);
			this.topMedia.Controls.Add(this.label3);
			this.topMedia.Controls.Add(this.label2);
			this.topMedia.Controls.Add(this.textBox1);
			this.topMedia.Controls.Add(this.label1);
			this.topMedia.Location = new System.Drawing.Point(4, 25);
			this.topMedia.Name = "topMedia";
			this.topMedia.Padding = new System.Windows.Forms.Padding(3);
			this.topMedia.Size = new System.Drawing.Size(1070, 541);
			this.topMedia.TabIndex = 1;
			this.topMedia.Text = "Top Media ";
			// 
			// panel
			// 
			this.panel.BackColor = System.Drawing.Color.White;
			this.panel.Location = new System.Drawing.Point(6, 48);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(1058, 487);
			this.panel.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(603, 19);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(131, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Voir Graphe";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(487, 20);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 22);
			this.textBox2.TabIndex = 5;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(107, 18);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 24);
			this.comboBox1.TabIndex = 4;
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
			this.label2.Location = new System.Drawing.Point(424, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Date fin";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(318, 20);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 1;
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
			// DashBoard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1103, 595);
			this.Controls.Add(this.tabControl1);
			this.Name = "DashBoard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DashBoard";
			this.tabControl1.ResumeLayout(false);
			this.topMedia.ResumeLayout(false);
			this.topMedia.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage topMedia;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel;
	}
}