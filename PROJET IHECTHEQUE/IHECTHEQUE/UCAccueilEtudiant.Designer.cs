namespace IHECTHEQUE
{
    partial class UCAccueilEtudiant
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
            this.panelEmpruntsEnCours = new RoundedPanel();
            this.btnProlonger = new System.Windows.Forms.Button();
            this.lblDateRetour = new System.Windows.Forms.Label();
            this.lblTitreEmprunts = new System.Windows.Forms.Label();
            this.pictureBoxEmpET = new System.Windows.Forms.PictureBox();
            this.panelFavoris = new RoundedPanel();
            this.lblAuteurFavori = new System.Windows.Forms.Label();
            this.lblTitreFavori = new System.Windows.Forms.Label();
            this.pictureBoxFavorisET = new System.Windows.Forms.PictureBox();
            this.lblFavorisTitre = new System.Windows.Forms.Label();
            this.panelStatsLecture = new RoundedPanel();
            this.picStatGraphET = new System.Windows.Forms.PictureBox();
            this.lblStatTitre = new System.Windows.Forms.Label();
            this.panelRecommandations = new RoundedPanel();
            this.labelAuteurReco = new System.Windows.Forms.Label();
            this.labelTitreReco = new System.Windows.Forms.Label();
            this.pictureBoxReco = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelActualites = new RoundedPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBonjourNom = new System.Windows.Forms.Label();
            this.labelSousTitre = new System.Windows.Forms.Label();
            this.lblNomEtudiantAccueilET = new System.Windows.Forms.Label();
            this.panelEmpruntsEnCours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmpET)).BeginInit();
            this.panelFavoris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavorisET)).BeginInit();
            this.panelStatsLecture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatGraphET)).BeginInit();
            this.panelRecommandations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReco)).BeginInit();
            this.panelActualites.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEmpruntsEnCours
            // 
            this.panelEmpruntsEnCours.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelEmpruntsEnCours.BorderRadius = 20;
            this.panelEmpruntsEnCours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelEmpruntsEnCours.Controls.Add(this.btnProlonger);
            this.panelEmpruntsEnCours.Controls.Add(this.lblDateRetour);
            this.panelEmpruntsEnCours.Controls.Add(this.lblTitreEmprunts);
            this.panelEmpruntsEnCours.Controls.Add(this.pictureBoxEmpET);
            this.panelEmpruntsEnCours.Location = new System.Drawing.Point(26, 102);
            this.panelEmpruntsEnCours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEmpruntsEnCours.Name = "panelEmpruntsEnCours";
            this.panelEmpruntsEnCours.Size = new System.Drawing.Size(1448, 182);
            this.panelEmpruntsEnCours.TabIndex = 0;
            this.panelEmpruntsEnCours.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEmpruntsEnCours_Paint);
            // 
            // btnProlonger
            // 
            this.btnProlonger.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProlonger.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnProlonger.Location = new System.Drawing.Point(1315, 102);
            this.btnProlonger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProlonger.Name = "btnProlonger";
            this.btnProlonger.Size = new System.Drawing.Size(109, 48);
            this.btnProlonger.TabIndex = 8;
            this.btnProlonger.Text = "Prolonger";
            this.btnProlonger.UseVisualStyleBackColor = true;
            // 
            // lblDateRetour
            // 
            this.lblDateRetour.AutoSize = true;
            this.lblDateRetour.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRetour.ForeColor = System.Drawing.Color.Red;
            this.lblDateRetour.Location = new System.Drawing.Point(1264, 70);
            this.lblDateRetour.Name = "lblDateRetour";
            this.lblDateRetour.Size = new System.Drawing.Size(182, 21);
            this.lblDateRetour.TabIndex = 6;
            this.lblDateRetour.Text = "Retour le 15/05/2025";
            // 
            // lblTitreEmprunts
            // 
            this.lblTitreEmprunts.AutoSize = true;
            this.lblTitreEmprunts.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreEmprunts.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitreEmprunts.Location = new System.Drawing.Point(11, 10);
            this.lblTitreEmprunts.Name = "lblTitreEmprunts";
            this.lblTitreEmprunts.Size = new System.Drawing.Size(239, 24);
            this.lblTitreEmprunts.TabIndex = 6;
            this.lblTitreEmprunts.Text = "Mes emprunts en cours";
            // 
            // pictureBoxEmpET
            // 
            this.pictureBoxEmpET.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxEmpET.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxEmpET.Image = global::IHECTHEQUE.Properties.Resources.LIVREACCEUILMESEMPR;
            this.pictureBoxEmpET.Location = new System.Drawing.Point(15, 52);
            this.pictureBoxEmpET.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxEmpET.Name = "pictureBoxEmpET";
            this.pictureBoxEmpET.Size = new System.Drawing.Size(77, 112);
            this.pictureBoxEmpET.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEmpET.TabIndex = 0;
            this.pictureBoxEmpET.TabStop = false;
            // 
            // panelFavoris
            // 
            this.panelFavoris.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelFavoris.BorderRadius = 20;
            this.panelFavoris.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFavoris.Controls.Add(this.lblAuteurFavori);
            this.panelFavoris.Controls.Add(this.lblTitreFavori);
            this.panelFavoris.Controls.Add(this.pictureBoxFavorisET);
            this.panelFavoris.Controls.Add(this.lblFavorisTitre);
            this.panelFavoris.Location = new System.Drawing.Point(26, 308);
            this.panelFavoris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFavoris.Name = "panelFavoris";
            this.panelFavoris.Size = new System.Drawing.Size(691, 332);
            this.panelFavoris.TabIndex = 1;
            // 
            // lblAuteurFavori
            // 
            this.lblAuteurFavori.AutoSize = true;
            this.lblAuteurFavori.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuteurFavori.ForeColor = System.Drawing.Color.Black;
            this.lblAuteurFavori.Location = new System.Drawing.Point(364, 58);
            this.lblAuteurFavori.Name = "lblAuteurFavori";
            this.lblAuteurFavori.Size = new System.Drawing.Size(222, 19);
            this.lblAuteurFavori.TabIndex = 11;
            this.lblAuteurFavori.Text = "Par Paul Anthony Samuelson";
            // 
            // lblTitreFavori
            // 
            this.lblTitreFavori.AutoSize = true;
            this.lblTitreFavori.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreFavori.ForeColor = System.Drawing.Color.Black;
            this.lblTitreFavori.Location = new System.Drawing.Point(364, 5);
            this.lblTitreFavori.Name = "lblTitreFavori";
            this.lblTitreFavori.Size = new System.Drawing.Size(235, 42);
            this.lblTitreFavori.TabIndex = 9;
            this.lblTitreFavori.Text = "Les Fondements \r\nde l’analyse économique";
            // 
            // pictureBoxFavorisET
            // 
            this.pictureBoxFavorisET.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxFavorisET.Image = global::IHECTHEQUE.Properties.Resources.LIVRESACCEUILFAV;
            this.pictureBoxFavorisET.Location = new System.Drawing.Point(358, 89);
            this.pictureBoxFavorisET.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxFavorisET.Name = "pictureBoxFavorisET";
            this.pictureBoxFavorisET.Size = new System.Drawing.Size(252, 216);
            this.pictureBoxFavorisET.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFavorisET.TabIndex = 10;
            this.pictureBoxFavorisET.TabStop = false;
            // 
            // lblFavorisTitre
            // 
            this.lblFavorisTitre.AutoSize = true;
            this.lblFavorisTitre.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavorisTitre.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFavorisTitre.Location = new System.Drawing.Point(18, 31);
            this.lblFavorisTitre.Name = "lblFavorisTitre";
            this.lblFavorisTitre.Size = new System.Drawing.Size(232, 30);
            this.lblFavorisTitre.TabIndex = 9;
            this.lblFavorisTitre.Text = "Mes livres favoris";
            // 
            // panelStatsLecture
            // 
            this.panelStatsLecture.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelStatsLecture.BorderRadius = 20;
            this.panelStatsLecture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelStatsLecture.Controls.Add(this.picStatGraphET);
            this.panelStatsLecture.Controls.Add(this.lblStatTitre);
            this.panelStatsLecture.Location = new System.Drawing.Point(768, 308);
            this.panelStatsLecture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelStatsLecture.Name = "panelStatsLecture";
            this.panelStatsLecture.Size = new System.Drawing.Size(706, 332);
            this.panelStatsLecture.TabIndex = 2;
            // 
            // picStatGraphET
            // 
            this.picStatGraphET.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picStatGraphET.Image = global::IHECTHEQUE.Properties.Resources.photoACCEUILSTAT;
            this.picStatGraphET.Location = new System.Drawing.Point(43, 89);
            this.picStatGraphET.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picStatGraphET.Name = "picStatGraphET";
            this.picStatGraphET.Size = new System.Drawing.Size(638, 216);
            this.picStatGraphET.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStatGraphET.TabIndex = 13;
            this.picStatGraphET.TabStop = false;
            // 
            // lblStatTitre
            // 
            this.lblStatTitre.AutoSize = true;
            this.lblStatTitre.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatTitre.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblStatTitre.Location = new System.Drawing.Point(19, 31);
            this.lblStatTitre.Name = "lblStatTitre";
            this.lblStatTitre.Size = new System.Drawing.Size(281, 30);
            this.lblStatTitre.TabIndex = 12;
            this.lblStatTitre.Text = "Statistiques de lecture";
            // 
            // panelRecommandations
            // 
            this.panelRecommandations.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelRecommandations.BorderRadius = 20;
            this.panelRecommandations.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRecommandations.Controls.Add(this.labelAuteurReco);
            this.panelRecommandations.Controls.Add(this.labelTitreReco);
            this.panelRecommandations.Controls.Add(this.pictureBoxReco);
            this.panelRecommandations.Controls.Add(this.label1);
            this.panelRecommandations.Location = new System.Drawing.Point(26, 659);
            this.panelRecommandations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRecommandations.Name = "panelRecommandations";
            this.panelRecommandations.Size = new System.Drawing.Size(1448, 192);
            this.panelRecommandations.TabIndex = 2;
            // 
            // labelAuteurReco
            // 
            this.labelAuteurReco.AutoSize = true;
            this.labelAuteurReco.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuteurReco.ForeColor = System.Drawing.Color.Black;
            this.labelAuteurReco.Location = new System.Drawing.Point(284, 101);
            this.labelAuteurReco.Name = "labelAuteurReco";
            this.labelAuteurReco.Size = new System.Drawing.Size(273, 19);
            this.labelAuteurReco.TabIndex = 12;
            this.labelAuteurReco.Text = "Paul R. Krugman, Maurice Obstfeld";
            // 
            // labelTitreReco
            // 
            this.labelTitreReco.AutoSize = true;
            this.labelTitreReco.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreReco.ForeColor = System.Drawing.Color.Black;
            this.labelTitreReco.Location = new System.Drawing.Point(284, 64);
            this.labelTitreReco.Name = "labelTitreReco";
            this.labelTitreReco.Size = new System.Drawing.Size(234, 21);
            this.labelTitreReco.TabIndex = 12;
            this.labelTitreReco.Text = "Economie Internationale";
            // 
            // pictureBoxReco
            // 
            this.pictureBoxReco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxReco.Image = global::IHECTHEQUE.Properties.Resources.PHOTOACCEUILRECOMM;
            this.pictureBoxReco.Location = new System.Drawing.Point(40, 51);
            this.pictureBoxReco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxReco.Name = "pictureBoxReco";
            this.pictureBoxReco.Size = new System.Drawing.Size(227, 122);
            this.pictureBoxReco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxReco.TabIndex = 15;
            this.pictureBoxReco.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Recommandations personnalisées";
            // 
            // panelActualites
            // 
            this.panelActualites.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelActualites.BorderRadius = 20;
            this.panelActualites.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelActualites.Controls.Add(this.panel1);
            this.panelActualites.Controls.Add(this.label2);
            this.panelActualites.Location = new System.Drawing.Point(26, 866);
            this.panelActualites.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelActualites.Name = "panelActualites";
            this.panelActualites.Size = new System.Drawing.Size(1448, 122);
            this.panelActualites.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(22, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1402, 61);
            this.panel1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(468, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Découvrez notre nouvelle collection de romans contemporains.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nouveaux arrivages - Avril 2025";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(10, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Actualités de la bibliothèque";
            // 
            // labelBonjourNom
            // 
            this.labelBonjourNom.AutoSize = true;
            this.labelBonjourNom.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBonjourNom.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelBonjourNom.Location = new System.Drawing.Point(20, 14);
            this.labelBonjourNom.Name = "labelBonjourNom";
            this.labelBonjourNom.Size = new System.Drawing.Size(243, 35);
            this.labelBonjourNom.TabIndex = 4;
            this.labelBonjourNom.Text = "Bonjour           !";
            this.labelBonjourNom.Click += new System.EventHandler(this.labelBonjourNom_Click);
            // 
            // labelSousTitre
            // 
            this.labelSousTitre.AutoSize = true;
            this.labelSousTitre.Font = new System.Drawing.Font("Mongolian Baiti", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSousTitre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelSousTitre.Location = new System.Drawing.Point(22, 58);
            this.labelSousTitre.Name = "labelSousTitre";
            this.labelSousTitre.Size = new System.Drawing.Size(237, 16);
            this.labelSousTitre.TabIndex = 5;
            this.labelSousTitre.Text = "Voici votre bibliothèque aujourd’hui";
            this.labelSousTitre.Click += new System.EventHandler(this.labelSousTitre_Click);
            // 
            // lblNomEtudiantAccueilET
            // 
            this.lblNomEtudiantAccueilET.AutoSize = true;
            this.lblNomEtudiantAccueilET.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEtudiantAccueilET.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNomEtudiantAccueilET.Location = new System.Drawing.Point(150, 14);
            this.lblNomEtudiantAccueilET.Name = "lblNomEtudiantAccueilET";
            this.lblNomEtudiantAccueilET.Size = new System.Drawing.Size(82, 34);
            this.lblNomEtudiantAccueilET.TabIndex = 6;
            this.lblNomEtudiantAccueilET.Text = "Nom";
            this.lblNomEtudiantAccueilET.Click += new System.EventHandler(this.lblNomEtudiantAccueilET_Click);
            // 
            // UCAccueilEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.lblNomEtudiantAccueilET);
            this.Controls.Add(this.labelSousTitre);
            this.Controls.Add(this.labelBonjourNom);
            this.Controls.Add(this.panelActualites);
            this.Controls.Add(this.panelRecommandations);
            this.Controls.Add(this.panelStatsLecture);
            this.Controls.Add(this.panelFavoris);
            this.Controls.Add(this.panelEmpruntsEnCours);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCAccueilEtudiant";
            this.Size = new System.Drawing.Size(1495, 1002);
            this.Load += new System.EventHandler(this.UCAccueilEtudiant_Load);
            this.panelEmpruntsEnCours.ResumeLayout(false);
            this.panelEmpruntsEnCours.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmpET)).EndInit();
            this.panelFavoris.ResumeLayout(false);
            this.panelFavoris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavorisET)).EndInit();
            this.panelStatsLecture.ResumeLayout(false);
            this.panelStatsLecture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatGraphET)).EndInit();
            this.panelRecommandations.ResumeLayout(false);
            this.panelRecommandations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReco)).EndInit();
            this.panelActualites.ResumeLayout(false);
            this.panelActualites.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedPanel panelEmpruntsEnCours;
        private RoundedPanel panelFavoris;
        private RoundedPanel panelStatsLecture;
        private RoundedPanel panelRecommandations;
        private RoundedPanel panelActualites;
        private System.Windows.Forms.Label labelBonjourNom;
        private System.Windows.Forms.Label labelSousTitre;
        private System.Windows.Forms.Label lblTitreEmprunts;
        private System.Windows.Forms.PictureBox pictureBoxEmpET;
        private System.Windows.Forms.Label lblDateRetour;
        private System.Windows.Forms.Button btnProlonger;
        private System.Windows.Forms.Label lblFavorisTitre;
        private System.Windows.Forms.PictureBox pictureBoxFavorisET;
        private System.Windows.Forms.Label lblAuteurFavori;
        private System.Windows.Forms.Label lblTitreFavori;
        private System.Windows.Forms.Label lblStatTitre;
        private System.Windows.Forms.PictureBox picStatGraphET;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxReco;
        private System.Windows.Forms.Label labelAuteurReco;
        private System.Windows.Forms.Label labelTitreReco;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNomEtudiantAccueilET;
    }
}
