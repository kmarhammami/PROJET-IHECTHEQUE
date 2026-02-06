namespace IHECTHEQUE
{
    partial class UCGestionUtilisateurBIB
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
            this.textBoxRechercheUtilisateurBIB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.data_utilisateurs = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_utilisateurs)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxRechercheUtilisateurBIB
            // 
            this.textBoxRechercheUtilisateurBIB.BackColor = System.Drawing.Color.White;
            this.textBoxRechercheUtilisateurBIB.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRechercheUtilisateurBIB.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxRechercheUtilisateurBIB.Location = new System.Drawing.Point(150, 98);
            this.textBoxRechercheUtilisateurBIB.Multiline = true;
            this.textBoxRechercheUtilisateurBIB.Name = "textBoxRechercheUtilisateurBIB";
            this.textBoxRechercheUtilisateurBIB.Size = new System.Drawing.Size(717, 29);
            this.textBoxRechercheUtilisateurBIB.TabIndex = 3;
            this.textBoxRechercheUtilisateurBIB.Text = "      Rechercher un utilisateur";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1326, 70);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::IHECTHEQUE.Properties.Resources._1bec9e53_3f3b_4391_b221_87c33bbb36bf;
            this.pictureBox3.Location = new System.Drawing.Point(95, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(131, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gestion Des Utilisateurs";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::IHECTHEQUE.Properties.Resources._042735f9_f070_4bd6_bf67_73a41233f3f23;
            this.pictureBox1.Location = new System.Drawing.Point(150, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // data_utilisateurs
            // 
            this.data_utilisateurs.AllowUserToOrderColumns = true;
            this.data_utilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_utilisateurs.Location = new System.Drawing.Point(47, 149);
            this.data_utilisateurs.Name = "data_utilisateurs";
            this.data_utilisateurs.RowHeadersWidth = 51;
            this.data_utilisateurs.RowTemplate.Height = 24;
            this.data_utilisateurs.Size = new System.Drawing.Size(1249, 439);
            this.data_utilisateurs.TabIndex = 6;
            this.data_utilisateurs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_utilisateurs_CellContentClick);
            // 
            // UCGestionUtilisateurBIB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.data_utilisateurs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxRechercheUtilisateurBIB);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UCGestionUtilisateurBIB";
            this.Size = new System.Drawing.Size(1329, 802);
            this.Load += new System.EventHandler(this.UCGestionAdhérents_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_utilisateurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxRechercheUtilisateurBIB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView data_utilisateurs;
    }
}
