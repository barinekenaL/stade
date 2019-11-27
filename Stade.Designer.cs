namespace stade
{
    partial class Stade
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.largeur = new System.Windows.Forms.TextBox();
            this.longueur = new System.Windows.Forms.TextBox();
            this.ajouter = new System.Windows.Forms.Button();
            this.desStade = new System.Windows.Forms.TextBox();
            this.choisir = new System.Windows.Forms.Button();
            this.stades = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.largeur);
            this.groupBox1.Controls.Add(this.longueur);
            this.groupBox1.Controls.Add(this.ajouter);
            this.groupBox1.Controls.Add(this.desStade);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "largeur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "longueur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom";
            // 
            // largeur
            // 
            this.largeur.Location = new System.Drawing.Point(72, 103);
            this.largeur.Name = "largeur";
            this.largeur.Size = new System.Drawing.Size(149, 22);
            this.largeur.TabIndex = 5;
            // 
            // longueur
            // 
            this.longueur.Location = new System.Drawing.Point(73, 65);
            this.longueur.Name = "longueur";
            this.longueur.Size = new System.Drawing.Size(148, 22);
            this.longueur.TabIndex = 4;
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(72, 142);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(149, 23);
            this.ajouter.TabIndex = 1;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // desStade
            // 
            this.desStade.Location = new System.Drawing.Point(73, 27);
            this.desStade.Name = "desStade";
            this.desStade.Size = new System.Drawing.Size(148, 22);
            this.desStade.TabIndex = 0;
            // 
            // choisir
            // 
            this.choisir.Location = new System.Drawing.Point(17, 73);
            this.choisir.Name = "choisir";
            this.choisir.Size = new System.Drawing.Size(148, 23);
            this.choisir.TabIndex = 3;
            this.choisir.Text = "Choisir";
            this.choisir.UseVisualStyleBackColor = true;
            // 
            // stades
            // 
            this.stades.FormattingEnabled = true;
            this.stades.Location = new System.Drawing.Point(16, 33);
            this.stades.Name = "stades";
            this.stades.Size = new System.Drawing.Size(149, 24);
            this.stades.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.stades);
            this.groupBox2.Controls.Add(this.choisir);
            this.groupBox2.Location = new System.Drawing.Point(13, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 118);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choix existant";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(257, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 571);
            this.panel1.TabIndex = 3;
            // 
            // Stade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 595);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Stade";
            this.Text = "Espace";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox desStade;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button choisir;
        private System.Windows.Forms.ComboBox stades;
        private System.Windows.Forms.TextBox largeur;
        private System.Windows.Forms.TextBox longueur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
    }
}

