namespace IHECTHEQUE
{
    partial class UCGestionLivreBIB
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAjouterLivreBIB = new System.Windows.Forms.Button();
            this.liste_livres = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1492, 88);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::IHECTHEQUE.Properties.Resources._1bec9e53_3f3b_4391_b221_87c33bbb36bf;
            this.pictureBox3.Location = new System.Drawing.Point(86, 28);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(126, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gestion Des Livres";
            // 
            // btnAjouterLivreBIB
            // 
            this.btnAjouterLivreBIB.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAjouterLivreBIB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterLivreBIB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAjouterLivreBIB.Location = new System.Drawing.Point(1029, 140);
            this.btnAjouterLivreBIB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjouterLivreBIB.Name = "btnAjouterLivreBIB";
            this.btnAjouterLivreBIB.Size = new System.Drawing.Size(278, 52);
            this.btnAjouterLivreBIB.TabIndex = 3;
            this.btnAjouterLivreBIB.Text = "Ajouter un nouveau livre";
            this.btnAjouterLivreBIB.UseVisualStyleBackColor = false;
            this.btnAjouterLivreBIB.Click += new System.EventHandler(this.btnAjouterLivreBIB_Click);
            // 
            // liste_livres
            // 
            this.liste_livres.AutoScroll = true;
            this.liste_livres.Location = new System.Drawing.Point(110, 250);
            this.liste_livres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.liste_livres.Name = "liste_livres";
            this.liste_livres.Size = new System.Drawing.Size(1317, 641);
            this.liste_livres.TabIndex = 5;
            this.liste_livres.Paint += new System.Windows.Forms.PaintEventHandler(this.liste_livres_Paint);
            // 
            // UCGestionLivreBIB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.liste_livres);
            this.Controls.Add(this.btnAjouterLivreBIB);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCGestionLivreBIB";
            this.Size = new System.Drawing.Size(1495, 1002);
            this.Load += new System.EventHandler(this.UCGestionLivreBIB_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnAjouterLivreBIB;
        private System.Windows.Forms.FlowLayoutPanel liste_livres;
    }
}
