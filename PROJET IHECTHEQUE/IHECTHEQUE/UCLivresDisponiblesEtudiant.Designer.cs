namespace IHECTHEQUE
{
    partial class UCLivresDisponiblesEtudiant
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
            this.panelSEARCHPAGE6ET = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSEARCHPAGE6ET = new System.Windows.Forms.Label();
            this.flowLayoutPanelLivres = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSEARCHPAGE6ET.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Livres disponibles";
            // 
            // panelSEARCHPAGE6ET
            // 
            this.panelSEARCHPAGE6ET.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelSEARCHPAGE6ET.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSEARCHPAGE6ET.Controls.Add(this.pictureBox1);
            this.panelSEARCHPAGE6ET.Controls.Add(this.lblSEARCHPAGE6ET);
            this.panelSEARCHPAGE6ET.Location = new System.Drawing.Point(943, 22);
            this.panelSEARCHPAGE6ET.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSEARCHPAGE6ET.Name = "panelSEARCHPAGE6ET";
            this.panelSEARCHPAGE6ET.Size = new System.Drawing.Size(288, 35);
            this.panelSEARCHPAGE6ET.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::IHECTHEQUE.Properties.Resources.Loupe;
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblSEARCHPAGE6ET
            // 
            this.lblSEARCHPAGE6ET.AutoSize = true;
            this.lblSEARCHPAGE6ET.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSEARCHPAGE6ET.ForeColor = System.Drawing.Color.Gray;
            this.lblSEARCHPAGE6ET.Location = new System.Drawing.Point(47, 9);
            this.lblSEARCHPAGE6ET.Name = "lblSEARCHPAGE6ET";
            this.lblSEARCHPAGE6ET.Size = new System.Drawing.Size(90, 16);
            this.lblSEARCHPAGE6ET.TabIndex = 5;
            this.lblSEARCHPAGE6ET.Text = "Rechercher...";
            // 
            // flowLayoutPanelLivres
            // 
            this.flowLayoutPanelLivres.AutoScroll = true;
            this.flowLayoutPanelLivres.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelLivres.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelLivres.Name = "flowLayoutPanelLivres";
            this.flowLayoutPanelLivres.Size = new System.Drawing.Size(1329, 804);
            this.flowLayoutPanelLivres.TabIndex = 8;
            this.flowLayoutPanelLivres.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelLivres_Paint);
            // 
            // UCLivresDisponiblesEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.flowLayoutPanelLivres);
            this.Controls.Add(this.panelSEARCHPAGE6ET);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCLivresDisponiblesEtudiant";
            this.Size = new System.Drawing.Size(1329, 802);
            this.panelSEARCHPAGE6ET.ResumeLayout(false);
            this.panelSEARCHPAGE6ET.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSEARCHPAGE6ET;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSEARCHPAGE6ET;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLivres;
    }
}
