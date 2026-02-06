namespace IHECTHEQUE
{
    partial class UCutilisateursADMIN
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxRechercheUtiliPAGE4AD = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelUtilisateurs = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(52, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Utilisateurs de la bibliothéque";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(54, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gérez les utilisateurs et leurs accès";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBoxRechercheUtiliPAGE4AD);
            this.panel1.Location = new System.Drawing.Point(130, 186);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 83);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IHECTHEQUE.Properties.Resources._042735f9_f070_4bd6_bf67_73a41233f3f21;
            this.pictureBox1.Location = new System.Drawing.Point(45, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxRechercheUtiliPAGE4AD
            // 
            this.textBoxRechercheUtiliPAGE4AD.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRechercheUtiliPAGE4AD.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxRechercheUtiliPAGE4AD.Location = new System.Drawing.Point(72, 19);
            this.textBoxRechercheUtiliPAGE4AD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxRechercheUtiliPAGE4AD.Multiline = true;
            this.textBoxRechercheUtiliPAGE4AD.Name = "textBoxRechercheUtiliPAGE4AD";
            this.textBoxRechercheUtiliPAGE4AD.Size = new System.Drawing.Size(484, 25);
            this.textBoxRechercheUtiliPAGE4AD.TabIndex = 5;
            this.textBoxRechercheUtiliPAGE4AD.Text = "Rechercher...";
            this.textBoxRechercheUtiliPAGE4AD.TextChanged += new System.EventHandler(this.textBoxRechercheUtiliPAGE4AD_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(130, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1492, 84);
            this.panel3.TabIndex = 5;
            // 
            // panelUtilisateurs
            // 
            this.panelUtilisateurs.AutoScroll = true;
            this.panelUtilisateurs.Location = new System.Drawing.Point(130, 294);
            this.panelUtilisateurs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelUtilisateurs.Name = "panelUtilisateurs";
            this.panelUtilisateurs.Size = new System.Drawing.Size(1397, 629);
            this.panelUtilisateurs.TabIndex = 6;
            this.panelUtilisateurs.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUtilisateurs_Paint);
            // 
            // UCutilisateursADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelUtilisateurs);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCutilisateursADMIN";
            this.Size = new System.Drawing.Size(1495, 1002);
            this.Load += new System.EventHandler(this.UCutilisateursADMIN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxRechercheUtiliPAGE4AD;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel panelUtilisateurs;
    }
}
