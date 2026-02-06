namespace IHECTHEQUE
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.roundedPanel1 = new RoundedPanel();
            this.pbEye = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chkSouvenir = new System.Windows.Forms.CheckBox();
            this.lblCréerCompte = new System.Windows.Forms.Label();
            this.btnLoginConnexion = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblOublie = new System.Windows.Forms.Label();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roundedPanel1.Controls.Add(this.pbEye);
            this.roundedPanel1.Controls.Add(this.pictureBox3);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.Controls.Add(this.txtPassword);
            this.roundedPanel1.Controls.Add(this.pictureBox1);
            this.roundedPanel1.Controls.Add(this.pictureBox2);
            this.roundedPanel1.Controls.Add(this.chkSouvenir);
            this.roundedPanel1.Controls.Add(this.lblCréerCompte);
            this.roundedPanel1.Controls.Add(this.btnLoginConnexion);
            this.roundedPanel1.Controls.Add(this.txtEmail);
            this.roundedPanel1.Controls.Add(this.lblOublie);
            this.roundedPanel1.Location = new System.Drawing.Point(655, 208);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(591, 704);
            this.roundedPanel1.TabIndex = 9;
            // 
            // pbEye
            // 
            this.pbEye.BackgroundImage = global::IHECTHEQUE.Properties.Resources.oeuil_mdp;
            this.pbEye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbEye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbEye.Location = new System.Drawing.Point(463, 326);
            this.pbEye.Name = "pbEye";
            this.pbEye.Size = new System.Drawing.Size(57, 34);
            this.pbEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEye.TabIndex = 9;
            this.pbEye.TabStop = false;
            this.pbEye.Click += new System.EventHandler(this.pbEye_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::IHECTHEQUE.Properties.Resources.bib_logo;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(215, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(99, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(170, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bibliothèque\r\nUniversitaire\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPassword.Location = new System.Drawing.Point(99, 332);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(358, 28);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Mot de passe\r\n";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::IHECTHEQUE.Properties.Resources.env2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(50, 263);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::IHECTHEQUE.Properties.Resources.cadenas;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(50, 332);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // chkSouvenir
            // 
            this.chkSouvenir.AutoSize = true;
            this.chkSouvenir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkSouvenir.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSouvenir.Location = new System.Drawing.Point(50, 450);
            this.chkSouvenir.Name = "chkSouvenir";
            this.chkSouvenir.Size = new System.Drawing.Size(221, 29);
            this.chkSouvenir.TabIndex = 4;
            this.chkSouvenir.Text = "Se souvenir de moi";
            this.chkSouvenir.UseVisualStyleBackColor = false;
            // 
            // lblCréerCompte
            // 
            this.lblCréerCompte.AutoSize = true;
            this.lblCréerCompte.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCréerCompte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCréerCompte.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCréerCompte.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lblCréerCompte.Location = new System.Drawing.Point(120, 633);
            this.lblCréerCompte.Name = "lblCréerCompte";
            this.lblCréerCompte.Size = new System.Drawing.Size(337, 30);
            this.lblCréerCompte.TabIndex = 7;
            this.lblCréerCompte.Text = "Vous n’avez pas de compte ?";
            this.lblCréerCompte.Click += new System.EventHandler(this.lblCréerCompte_Click);
            // 
            // btnLoginConnexion
            // 
            this.btnLoginConnexion.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLoginConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginConnexion.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginConnexion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLoginConnexion.Location = new System.Drawing.Point(157, 538);
            this.btnLoginConnexion.Name = "btnLoginConnexion";
            this.btnLoginConnexion.Size = new System.Drawing.Size(271, 58);
            this.btnLoginConnexion.TabIndex = 5;
            this.btnLoginConnexion.Text = "Se connecter ->";
            this.btnLoginConnexion.UseVisualStyleBackColor = false;
            this.btnLoginConnexion.Click += new System.EventHandler(this.btnLoginConnexion_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEmail.Location = new System.Drawing.Point(107, 274);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(350, 28);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Text = "Adresse email";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lblOublie
            // 
            this.lblOublie.AutoSize = true;
            this.lblOublie.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOublie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOublie.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOublie.ForeColor = System.Drawing.Color.Red;
            this.lblOublie.Location = new System.Drawing.Point(327, 450);
            this.lblOublie.Name = "lblOublie";
            this.lblOublie.Size = new System.Drawing.Size(206, 24);
            this.lblOublie.TabIndex = 6;
            this.lblOublie.Text = "Mot de passe oublié ?";
            this.lblOublie.Click += new System.EventHandler(this.lblOublie_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IHECTHEQUE.Properties.Resources.Design_sans_titre__6_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1793, 1024);
            this.Controls.Add(this.roundedPanel1);
            this.DoubleBuffered = true;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox chkSouvenir;
        private System.Windows.Forms.Button btnLoginConnexion;
        private System.Windows.Forms.Label lblOublie;
        private System.Windows.Forms.Label lblCréerCompte;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pbEye;
    }
}