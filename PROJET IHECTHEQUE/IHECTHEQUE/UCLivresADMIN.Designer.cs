namespace IHECTHEQUE
{
    partial class UCLivresADMIN
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
            this.panelSEARCHPAGE3AD = new System.Windows.Forms.Panel();
            this.txtboxLivreAD = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLivresAdmin = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSEARCHPAGE3AD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Les livres de la bibliothéque";
            // 
            // panelSEARCHPAGE3AD
            // 
            this.panelSEARCHPAGE3AD.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelSEARCHPAGE3AD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSEARCHPAGE3AD.Controls.Add(this.txtboxLivreAD);
            this.panelSEARCHPAGE3AD.Controls.Add(this.pictureBox2);
            this.panelSEARCHPAGE3AD.Location = new System.Drawing.Point(1144, 82);
            this.panelSEARCHPAGE3AD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSEARCHPAGE3AD.Name = "panelSEARCHPAGE3AD";
            this.panelSEARCHPAGE3AD.Size = new System.Drawing.Size(324, 43);
            this.panelSEARCHPAGE3AD.TabIndex = 12;
            // 
            // txtboxLivreAD
            // 
            this.txtboxLivreAD.Location = new System.Drawing.Point(54, 5);
            this.txtboxLivreAD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxLivreAD.Name = "txtboxLivreAD";
            this.txtboxLivreAD.Size = new System.Drawing.Size(214, 26);
            this.txtboxLivreAD.TabIndex = 6;
            this.txtboxLivreAD.Text = "Rechercher...";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::IHECTHEQUE.Properties.Resources.Loupe;
            this.pictureBox2.Location = new System.Drawing.Point(14, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(125, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1523, 76);
            this.panel1.TabIndex = 13;
            // 
            // panelLivresAdmin
            // 
            this.panelLivresAdmin.AutoScroll = true;
            this.panelLivresAdmin.Location = new System.Drawing.Point(125, 131);
            this.panelLivresAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLivresAdmin.Name = "panelLivresAdmin";
            this.panelLivresAdmin.Size = new System.Drawing.Size(1354, 848);
            this.panelLivresAdmin.TabIndex = 14;
            this.panelLivresAdmin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLivresAdmin_Paint);
            // 
            // UCLivresADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelLivresAdmin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSEARCHPAGE3AD);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCLivresADMIN";
            this.Size = new System.Drawing.Size(1495, 1002);
            this.Load += new System.EventHandler(this.UCLivresADMIN_Load);
            this.panelSEARCHPAGE3AD.ResumeLayout(false);
            this.panelSEARCHPAGE3AD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSEARCHPAGE3AD;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtboxLivreAD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel panelLivresAdmin;
    }
}
