namespace stade
{
    partial class StadeView
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
			this.insertion = new System.Windows.Forms.GroupBox();
			this.couleur = new System.Windows.Forms.Button();
			this.clear = new System.Windows.Forms.Button();
			this.points = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ajouter = new System.Windows.Forms.Button();
			this.desStade = new System.Windows.Forms.TextBox();
			this.panel = new System.Windows.Forms.Panel();
			this.err = new System.Windows.Forms.Label();
			this.insert = new System.Windows.Forms.Button();
			this.reservation = new System.Windows.Forms.Button();
			this.insertion.SuspendLayout();
			this.SuspendLayout();
			// 
			// insertion
			// 
			this.insertion.Controls.Add(this.couleur);
			this.insertion.Controls.Add(this.clear);
			this.insertion.Controls.Add(this.points);
			this.insertion.Controls.Add(this.label3);
			this.insertion.Controls.Add(this.label1);
			this.insertion.Controls.Add(this.ajouter);
			this.insertion.Controls.Add(this.desStade);
			this.insertion.Location = new System.Drawing.Point(12, 12);
			this.insertion.Name = "insertion";
			this.insertion.Size = new System.Drawing.Size(230, 249);
			this.insertion.TabIndex = 1;
			this.insertion.TabStop = false;
			this.insertion.Text = "Insertion";
			// 
			// couleur
			// 
			this.couleur.Location = new System.Drawing.Point(6, 214);
			this.couleur.Name = "couleur";
			this.couleur.Size = new System.Drawing.Size(75, 23);
			this.couleur.TabIndex = 11;
			this.couleur.Text = "couleur";
			this.couleur.UseVisualStyleBackColor = true;
			this.couleur.Click += new System.EventHandler(this.couleur_Click);
			// 
			// clear
			// 
			this.clear.Location = new System.Drawing.Point(6, 185);
			this.clear.Name = "clear";
			this.clear.Size = new System.Drawing.Size(75, 23);
			this.clear.TabIndex = 10;
			this.clear.Text = "clear";
			this.clear.UseVisualStyleBackColor = true;
			this.clear.Click += new System.EventHandler(this.clear_Click);
			// 
			// points
			// 
			this.points.FormattingEnabled = true;
			this.points.ItemHeight = 16;
			this.points.Location = new System.Drawing.Point(101, 60);
			this.points.Name = "points";
			this.points.Size = new System.Drawing.Size(120, 148);
			this.points.TabIndex = 9;
			this.points.MouseClick += new System.Windows.Forms.MouseEventHandler(this.points_MouseClick);
			this.points.KeyUp += new System.Windows.Forms.KeyEventHandler(this.points_KeyUp);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "Points";
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
			// ajouter
			// 
			this.ajouter.Location = new System.Drawing.Point(111, 214);
			this.ajouter.Name = "ajouter";
			this.ajouter.Size = new System.Drawing.Size(109, 23);
			this.ajouter.TabIndex = 1;
			this.ajouter.Text = "Ajouter";
			this.ajouter.UseVisualStyleBackColor = true;
			this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
			// 
			// desStade
			// 
			this.desStade.Location = new System.Drawing.Point(101, 27);
			this.desStade.Name = "desStade";
			this.desStade.Size = new System.Drawing.Size(120, 22);
			this.desStade.TabIndex = 0;
			// 
			// panel
			// 
			this.panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel.Location = new System.Drawing.Point(257, 12);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(834, 571);
			this.panel.TabIndex = 3;
			this.panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_MouseClick);
			// 
			// err
			// 
			this.err.AutoSize = true;
			this.err.ForeColor = System.Drawing.Color.Red;
			this.err.Location = new System.Drawing.Point(12, 277);
			this.err.Name = "err";
			this.err.Size = new System.Drawing.Size(0, 17);
			this.err.TabIndex = 4;
			// 
			// insert
			// 
			this.insert.Location = new System.Drawing.Point(12, 267);
			this.insert.Name = "insert";
			this.insert.Size = new System.Drawing.Size(98, 23);
			this.insert.TabIndex = 5;
			this.insert.Text = "Insertion";
			this.insert.UseVisualStyleBackColor = true;
			this.insert.Click += new System.EventHandler(this.insert_Click);
			// 
			// reservation
			// 
			this.reservation.Location = new System.Drawing.Point(139, 267);
			this.reservation.Name = "reservation";
			this.reservation.Size = new System.Drawing.Size(103, 23);
			this.reservation.TabIndex = 6;
			this.reservation.Text = "Reservation";
			this.reservation.UseVisualStyleBackColor = true;
			this.reservation.Click += new System.EventHandler(this.reservation_Click);
			// 
			// StadeView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1103, 595);
			this.Controls.Add(this.reservation);
			this.Controls.Add(this.insert);
			this.Controls.Add(this.err);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.insertion);
			this.Name = "StadeView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Stade";
			this.Load += new System.EventHandler(this.Stade_Load);
			this.Resize += new System.EventHandler(this.Stade_Resize);
			this.insertion.ResumeLayout(false);
			this.insertion.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox insertion;
        private System.Windows.Forms.TextBox desStade;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ListBox points;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button couleur;
        private System.Windows.Forms.Label err;
		private System.Windows.Forms.Button insert;
		private System.Windows.Forms.Button reservation;
	}
}

