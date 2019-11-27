namespace stade
{
    partial class Zone
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.stade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.enregistrer = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.points = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.des = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.categ = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.espCote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lngCh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.largCh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.espAv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.categ);
            this.groupBox1.Controls.Add(this.simuler);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.num1);
            this.groupBox1.Controls.Add(this.sens);
            this.groupBox1.Controls.Add(this.direction);
            this.groupBox1.Controls.Add(this.stade);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.enregistrer);
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.points);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.des);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 571);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "zone";
            // 
            // simuler
            // 
            this.simuler.Location = new System.Drawing.Point(0, 533);
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
            this.groupBox2.Location = new System.Drawing.Point(1, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 138);
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
            this.espCote.Location = new System.Drawing.Point(75, 108);
            this.espCote.Name = "espCote";
            this.espCote.Size = new System.Drawing.Size(112, 22);
            this.espCote.TabIndex = 20;
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
            this.lngCh.Location = new System.Drawing.Point(75, 21);
            this.lngCh.Name = "lngCh";
            this.lngCh.Size = new System.Drawing.Size(112, 22);
            this.lngCh.TabIndex = 11;
            this.lngCh.Value = new decimal(new int[] {
            6,
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
            this.largCh.Location = new System.Drawing.Point(75, 50);
            this.largCh.Name = "largCh";
            this.largCh.Size = new System.Drawing.Size(112, 22);
            this.largCh.TabIndex = 12;
            this.largCh.Value = new decimal(new int[] {
            5,
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
            this.espAv.Location = new System.Drawing.Point(75, 79);
            this.espAv.Name = "espAv";
            this.espAv.Size = new System.Drawing.Size(112, 22);
            this.espAv.TabIndex = 13;
            this.espAv.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "1er Num";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sens";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Direction";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(80, 297);
            this.num1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(114, 22);
            this.num1.TabIndex = 10;
            // 
            // sens
            // 
            this.sens.FormattingEnabled = true;
            this.sens.Location = new System.Drawing.Point(80, 234);
            this.sens.Name = "sens";
            this.sens.Size = new System.Drawing.Size(114, 24);
            this.sens.TabIndex = 9;
            // 
            // direction
            // 
            this.direction.FormattingEnabled = true;
            this.direction.Location = new System.Drawing.Point(80, 203);
            this.direction.Name = "direction";
            this.direction.Size = new System.Drawing.Size(114, 24);
            this.direction.TabIndex = 8;
            this.direction.SelectedValueChanged += new System.EventHandler(this.direction_SelectedValueChanged);
            // 
            // stade
            // 
            this.stade.FormattingEnabled = true;
            this.stade.Location = new System.Drawing.Point(80, 22);
            this.stade.Name = "stade";
            this.stade.Size = new System.Drawing.Size(114, 24);
            this.stade.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stade";
            // 
            // enregistrer
            // 
            this.enregistrer.Location = new System.Drawing.Point(94, 533);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(101, 32);
            this.enregistrer.TabIndex = 5;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.UseVisualStyleBackColor = true;
            this.enregistrer.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(2, 173);
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
            this.points.Location = new System.Drawing.Point(80, 80);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(114, 116);
            this.points.TabIndex = 3;
            this.points.MouseClick += new System.Windows.Forms.MouseEventHandler(this.points_MouseClick);
            this.points.KeyUp += new System.Windows.Forms.KeyEventHandler(this.points_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Points";
            // 
            // des
            // 
            this.des.Location = new System.Drawing.Point(80, 52);
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(114, 22);
            this.des.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(218, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(873, 571);
            this.panel.TabIndex = 1;
            this.panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_MouseClick);
            // 
            // categ
            // 
            this.categ.FormattingEnabled = true;
            this.categ.Location = new System.Drawing.Point(80, 265);
            this.categ.Name = "categ";
            this.categ.Size = new System.Drawing.Size(114, 24);
            this.categ.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Categorie";
            // 
            // Zone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 595);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Zone";
            this.Text = "Zone";
            this.Load += new System.EventHandler(this.Zone_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.espCote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lngCh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.largCh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.espAv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox points;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox des;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.ComboBox stade;
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox categ;
    }
}