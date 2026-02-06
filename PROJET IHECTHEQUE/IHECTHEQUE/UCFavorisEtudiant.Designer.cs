namespace IHECTHEQUE
{
    partial class UCFavorisEtudiant
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
            this.flowLayoutPanelfavorie = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(50, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mes favoris";
            // 
            // flowLayoutPanelfavorie
            // 
            this.flowLayoutPanelfavorie.Location = new System.Drawing.Point(68, 151);
            this.flowLayoutPanelfavorie.Name = "flowLayoutPanelfavorie";
            this.flowLayoutPanelfavorie.Size = new System.Drawing.Size(1104, 562);
            this.flowLayoutPanelfavorie.TabIndex = 3;
            this.flowLayoutPanelfavorie.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelfavorie_Paint);
            // 
            // UCFavorisEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelfavorie);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCFavorisEtudiant";
            this.Size = new System.Drawing.Size(1329, 802);
            this.Load += new System.EventHandler(this.UCFavorisEtudiant_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelfavorie;
    }
}
