namespace IHECTHEQUE
{
    partial class UCEmpruntsEtudiant
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
            this.textBoxRechercherEmpET = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblNomEtudiantEmpET = new System.Windows.Forms.Label();
            this.flowLayoutPanelEmprunts = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mes emprunts";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(33, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gérez vos emprunts en cours";
            // 
            // textBoxRechercherEmpET
            // 
            this.textBoxRechercherEmpET.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRechercherEmpET.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxRechercherEmpET.Location = new System.Drawing.Point(1172, 62);
            this.textBoxRechercherEmpET.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxRechercherEmpET.Multiline = true;
            this.textBoxRechercherEmpET.Name = "textBoxRechercherEmpET";
            this.textBoxRechercherEmpET.Size = new System.Drawing.Size(289, 33);
            this.textBoxRechercherEmpET.TabIndex = 14;
            this.textBoxRechercherEmpET.Text = "     Rechercher...";
            this.textBoxRechercherEmpET.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::IHECTHEQUE.Properties.Resources._042735f9_f070_4bd6_bf67_73a41233f3f22;
            this.pictureBox2.Location = new System.Drawing.Point(1172, 62);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // lblNomEtudiantEmpET
            // 
            this.lblNomEtudiantEmpET.AutoSize = true;
            this.lblNomEtudiantEmpET.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEtudiantEmpET.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNomEtudiantEmpET.Location = new System.Drawing.Point(1352, 20);
            this.lblNomEtudiantEmpET.Name = "lblNomEtudiantEmpET";
            this.lblNomEtudiantEmpET.Size = new System.Drawing.Size(0, 23);
            this.lblNomEtudiantEmpET.TabIndex = 16;
            // 
            // flowLayoutPanelEmprunts
            // 
            this.flowLayoutPanelEmprunts.Location = new System.Drawing.Point(3, 124);
            this.flowLayoutPanelEmprunts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanelEmprunts.Name = "flowLayoutPanelEmprunts";
            this.flowLayoutPanelEmprunts.Size = new System.Drawing.Size(1468, 860);
            this.flowLayoutPanelEmprunts.TabIndex = 17;
            this.flowLayoutPanelEmprunts.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelEmprunts_Paint);
            // 
            // UCEmpruntsEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelEmprunts);
            this.Controls.Add(this.lblNomEtudiantEmpET);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBoxRechercherEmpET);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCEmpruntsEtudiant";
            this.Size = new System.Drawing.Size(1495, 1002);
            this.Load += new System.EventHandler(this.UCEmpruntsEtudiant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRechercherEmpET;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblNomEtudiantEmpET;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEmprunts;
    }
}
