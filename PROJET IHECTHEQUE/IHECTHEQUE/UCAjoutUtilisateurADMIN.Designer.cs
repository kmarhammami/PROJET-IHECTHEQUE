namespace IHECTHEQUE
{
    partial class UCAjoutUtilisateurADMIN
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
            this.panelAjoutUtilisAD = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxPRENOMUtilisateurAD = new System.Windows.Forms.TextBox();
            this.textBoxROLEUtilisateurAD = new System.Windows.Forms.TextBox();
            this.textBoxEMAILUtilisateurAD = new System.Windows.Forms.TextBox();
            this.textBoxNOMUtilisateurAD = new System.Windows.Forms.TextBox();
            this.btnAnnulUtiliAD = new System.Windows.Forms.Button();
            this.btnEnregitrerUtiAD = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelAjoutUtilisAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAjoutUtilisAD
            // 
            this.panelAjoutUtilisAD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelAjoutUtilisAD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAjoutUtilisAD.Controls.Add(this.pictureBox2);
            this.panelAjoutUtilisAD.Controls.Add(this.textBoxPRENOMUtilisateurAD);
            this.panelAjoutUtilisAD.Controls.Add(this.textBoxROLEUtilisateurAD);
            this.panelAjoutUtilisAD.Controls.Add(this.textBoxEMAILUtilisateurAD);
            this.panelAjoutUtilisAD.Controls.Add(this.textBoxNOMUtilisateurAD);
            this.panelAjoutUtilisAD.Controls.Add(this.btnAnnulUtiliAD);
            this.panelAjoutUtilisAD.Controls.Add(this.btnEnregitrerUtiAD);
            this.panelAjoutUtilisAD.Controls.Add(this.label6);
            this.panelAjoutUtilisAD.Controls.Add(this.label5);
            this.panelAjoutUtilisAD.Controls.Add(this.label4);
            this.panelAjoutUtilisAD.Controls.Add(this.label2);
            this.panelAjoutUtilisAD.Controls.Add(this.pictureBox1);
            this.panelAjoutUtilisAD.Controls.Add(this.label1);
            this.panelAjoutUtilisAD.Location = new System.Drawing.Point(285, 134);
            this.panelAjoutUtilisAD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelAjoutUtilisAD.Name = "panelAjoutUtilisAD";
            this.panelAjoutUtilisAD.Size = new System.Drawing.Size(916, 718);
            this.panelAjoutUtilisAD.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::IHECTHEQUE.Properties.Resources._40d2c858_390b_424f_837b_a4abcc85fce82;
            this.pictureBox2.Location = new System.Drawing.Point(660, 642);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // textBoxPRENOMUtilisateurAD
            // 
            this.textBoxPRENOMUtilisateurAD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxPRENOMUtilisateurAD.Location = new System.Drawing.Point(487, 196);
            this.textBoxPRENOMUtilisateurAD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPRENOMUtilisateurAD.Multiline = true;
            this.textBoxPRENOMUtilisateurAD.Name = "textBoxPRENOMUtilisateurAD";
            this.textBoxPRENOMUtilisateurAD.Size = new System.Drawing.Size(214, 40);
            this.textBoxPRENOMUtilisateurAD.TabIndex = 13;
            // 
            // textBoxROLEUtilisateurAD
            // 
            this.textBoxROLEUtilisateurAD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxROLEUtilisateurAD.Location = new System.Drawing.Point(523, 360);
            this.textBoxROLEUtilisateurAD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxROLEUtilisateurAD.Multiline = true;
            this.textBoxROLEUtilisateurAD.Name = "textBoxROLEUtilisateurAD";
            this.textBoxROLEUtilisateurAD.Size = new System.Drawing.Size(214, 40);
            this.textBoxROLEUtilisateurAD.TabIndex = 12;
            // 
            // textBoxEMAILUtilisateurAD
            // 
            this.textBoxEMAILUtilisateurAD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxEMAILUtilisateurAD.Location = new System.Drawing.Point(107, 360);
            this.textBoxEMAILUtilisateurAD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEMAILUtilisateurAD.Multiline = true;
            this.textBoxEMAILUtilisateurAD.Name = "textBoxEMAILUtilisateurAD";
            this.textBoxEMAILUtilisateurAD.Size = new System.Drawing.Size(214, 40);
            this.textBoxEMAILUtilisateurAD.TabIndex = 11;
            // 
            // textBoxNOMUtilisateurAD
            // 
            this.textBoxNOMUtilisateurAD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxNOMUtilisateurAD.Location = new System.Drawing.Point(107, 196);
            this.textBoxNOMUtilisateurAD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNOMUtilisateurAD.Multiline = true;
            this.textBoxNOMUtilisateurAD.Name = "textBoxNOMUtilisateurAD";
            this.textBoxNOMUtilisateurAD.Size = new System.Drawing.Size(214, 40);
            this.textBoxNOMUtilisateurAD.TabIndex = 1;
            // 
            // btnAnnulUtiliAD
            // 
            this.btnAnnulUtiliAD.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAnnulUtiliAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulUtiliAD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnnulUtiliAD.Location = new System.Drawing.Point(487, 631);
            this.btnAnnulUtiliAD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnnulUtiliAD.Name = "btnAnnulUtiliAD";
            this.btnAnnulUtiliAD.Size = new System.Drawing.Size(154, 50);
            this.btnAnnulUtiliAD.TabIndex = 10;
            this.btnAnnulUtiliAD.Text = "Annuler";
            this.btnAnnulUtiliAD.UseVisualStyleBackColor = false;
            // 
            // btnEnregitrerUtiAD
            // 
            this.btnEnregitrerUtiAD.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEnregitrerUtiAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregitrerUtiAD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnregitrerUtiAD.Location = new System.Drawing.Point(648, 631);
            this.btnEnregitrerUtiAD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEnregitrerUtiAD.Name = "btnEnregitrerUtiAD";
            this.btnEnregitrerUtiAD.Size = new System.Drawing.Size(208, 50);
            this.btnEnregitrerUtiAD.TabIndex = 9;
            this.btnEnregitrerUtiAD.Text = "Enregistrer";
            this.btnEnregitrerUtiAD.UseVisualStyleBackColor = false;
            this.btnEnregitrerUtiAD.Click += new System.EventHandler(this.btnEnregitrerUtiAD_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(115, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "EMAIL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(518, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "ROLE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(483, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "PRENOM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(115, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IHECTHEQUE.Properties.Resources._5a089aae_90c0_407a_aba4_d9f26acefe0f;
            this.pictureBox1.Location = new System.Drawing.Point(40, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(80, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter un utiilisateur";
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandTimeout = 30;
            this.sqlCommand2.EnableOptimizedParameterBinding = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1523, 75);
            this.panel1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.GhostWhite;
            this.label8.Location = new System.Drawing.Point(60, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(322, 35);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ajouter un utilisateur";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::IHECTHEQUE.Properties.Resources.a036b1a1_56a1_4687_a3cb_285f7cb5ada9;
            this.pictureBox3.Location = new System.Drawing.Point(-40, 906);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1536, 28);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // UCAjoutUtilisateurADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAjoutUtilisAD);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCAjoutUtilisateurADMIN";
            this.Size = new System.Drawing.Size(1495, 1002);
            this.panelAjoutUtilisAD.ResumeLayout(false);
            this.panelAjoutUtilisAD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAjoutUtilisAD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEnregitrerUtiAD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxPRENOMUtilisateurAD;
        private System.Windows.Forms.TextBox textBoxROLEUtilisateurAD;
        private System.Windows.Forms.TextBox textBoxEMAILUtilisateurAD;
        private System.Windows.Forms.TextBox textBoxNOMUtilisateurAD;
        private System.Windows.Forms.Button btnAnnulUtiliAD;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
