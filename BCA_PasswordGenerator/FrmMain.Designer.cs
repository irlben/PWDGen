namespace BCA_PasswordGenerator
{
    partial class FrmMain
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTNCONNEC = new System.Windows.Forms.Button();
            this.BTNCREA = new System.Windows.Forms.Button();
            this.CONNEC_MAIL = new System.Windows.Forms.TextBox();
            this.CONNEC_MDP = new System.Windows.Forms.TextBox();
            this.CONNECT_BTN = new System.Windows.Forms.Button();
            this.CREA_NOM = new System.Windows.Forms.TextBox();
            this.CREA_MAIL = new System.Windows.Forms.TextBox();
            this.CONNEC_STAYCONNEC = new System.Windows.Forms.RadioButton();
            this.CREA_MDP = new System.Windows.Forms.TextBox();
            this.CREA_BTN = new System.Windows.Forms.Button();
            this.LblErreurConnect = new System.Windows.Forms.Label();
            this.LBLINFO = new System.Windows.Forms.Label();
            this.LBLINFO1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // BTNCONNEC
            // 
            this.BTNCONNEC.Location = new System.Drawing.Point(195, 269);
            this.BTNCONNEC.Name = "BTNCONNEC";
            this.BTNCONNEC.Size = new System.Drawing.Size(94, 23);
            this.BTNCONNEC.TabIndex = 0;
            this.BTNCONNEC.Text = "Se connecter";
            this.BTNCONNEC.UseVisualStyleBackColor = true;
            this.BTNCONNEC.Click += new System.EventHandler(this.BTNCONNEC_Click);
            // 
            // BTNCREA
            // 
            this.BTNCREA.Location = new System.Drawing.Point(195, 298);
            this.BTNCREA.Name = "BTNCREA";
            this.BTNCREA.Size = new System.Drawing.Size(94, 23);
            this.BTNCREA.TabIndex = 1;
            this.BTNCREA.Text = "Créer un compte";
            this.BTNCREA.UseVisualStyleBackColor = true;
            this.BTNCREA.Click += new System.EventHandler(this.BTNCREA_Click);
            // 
            // CONNEC_MAIL
            // 
            this.CONNEC_MAIL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CONNEC_MAIL.Location = new System.Drawing.Point(186, 136);
            this.CONNEC_MAIL.Name = "CONNEC_MAIL";
            this.CONNEC_MAIL.Size = new System.Drawing.Size(115, 20);
            this.CONNEC_MAIL.TabIndex = 2;
            this.CONNEC_MAIL.Text = "exemple@mail.com";
            this.CONNEC_MAIL.Click += new System.EventHandler(this.CONNEC_MAIL_Click);
            // 
            // CONNEC_MDP
            // 
            this.CONNEC_MDP.Location = new System.Drawing.Point(186, 166);
            this.CONNEC_MDP.Name = "CONNEC_MDP";
            this.CONNEC_MDP.Size = new System.Drawing.Size(115, 20);
            this.CONNEC_MDP.TabIndex = 3;
            this.CONNEC_MDP.Text = "Mot de passe";
            this.CONNEC_MDP.UseSystemPasswordChar = true;
            this.CONNEC_MDP.Click += new System.EventHandler(this.CONNEC_MDP_Click);
            // 
            // CONNECT_BTN
            // 
            this.CONNECT_BTN.Location = new System.Drawing.Point(201, 212);
            this.CONNECT_BTN.Name = "CONNECT_BTN";
            this.CONNECT_BTN.Size = new System.Drawing.Size(86, 23);
            this.CONNECT_BTN.TabIndex = 4;
            this.CONNECT_BTN.Text = "Connexion";
            this.CONNECT_BTN.UseVisualStyleBackColor = true;
            this.CONNECT_BTN.Click += new System.EventHandler(this.CONNECT_BTN_Click);
            // 
            // CREA_NOM
            // 
            this.CREA_NOM.Location = new System.Drawing.Point(187, 110);
            this.CREA_NOM.Name = "CREA_NOM";
            this.CREA_NOM.Size = new System.Drawing.Size(114, 20);
            this.CREA_NOM.TabIndex = 5;
            this.CREA_NOM.Text = "Nom";
            this.CREA_NOM.Click += new System.EventHandler(this.CREA_NOM_Click);
            // 
            // CREA_MAIL
            // 
            this.CREA_MAIL.Location = new System.Drawing.Point(187, 136);
            this.CREA_MAIL.Name = "CREA_MAIL";
            this.CREA_MAIL.Size = new System.Drawing.Size(114, 20);
            this.CREA_MAIL.TabIndex = 6;
            this.CREA_MAIL.Text = "exemple@mail.com";
            this.CREA_MAIL.Click += new System.EventHandler(this.CREA_MAIL_Click);
            // 
            // CONNEC_STAYCONNEC
            // 
            this.CONNEC_STAYCONNEC.AutoSize = true;
            this.CONNEC_STAYCONNEC.Location = new System.Drawing.Point(186, 189);
            this.CONNEC_STAYCONNEC.Name = "CONNEC_STAYCONNEC";
            this.CONNEC_STAYCONNEC.Size = new System.Drawing.Size(115, 17);
            this.CONNEC_STAYCONNEC.TabIndex = 7;
            this.CONNEC_STAYCONNEC.TabStop = true;
            this.CONNEC_STAYCONNEC.Text = "Se souvenir de moi";
            this.CONNEC_STAYCONNEC.UseVisualStyleBackColor = true;
            // 
            // CREA_MDP
            // 
            this.CREA_MDP.Location = new System.Drawing.Point(185, 166);
            this.CREA_MDP.Name = "CREA_MDP";
            this.CREA_MDP.Size = new System.Drawing.Size(115, 20);
            this.CREA_MDP.TabIndex = 8;
            this.CREA_MDP.Text = "Mot de passe";
            this.CREA_MDP.UseSystemPasswordChar = true;
            this.CREA_MDP.Click += new System.EventHandler(this.CREA_MDP_Click);
            // 
            // CREA_BTN
            // 
            this.CREA_BTN.Location = new System.Drawing.Point(195, 212);
            this.CREA_BTN.Name = "CREA_BTN";
            this.CREA_BTN.Size = new System.Drawing.Size(100, 23);
            this.CREA_BTN.TabIndex = 9;
            this.CREA_BTN.Text = "Créer le compte";
            this.CREA_BTN.UseVisualStyleBackColor = true;
            this.CREA_BTN.Click += new System.EventHandler(this.CREA_BTN_Click);
            // 
            // LblErreurConnect
            // 
            this.LblErreurConnect.AutoSize = true;
            this.LblErreurConnect.ForeColor = System.Drawing.Color.DarkRed;
            this.LblErreurConnect.Location = new System.Drawing.Point(73, 52);
            this.LblErreurConnect.Name = "LblErreurConnect";
            this.LblErreurConnect.Size = new System.Drawing.Size(362, 13);
            this.LblErreurConnect.TabIndex = 10;
            this.LblErreurConnect.Text = "Une erreur s\'est produite ! Veuillez vérifier que vos identifiants sont corrects." +
    "";
            // 
            // LBLINFO
            // 
            this.LBLINFO.AutoSize = true;
            this.LBLINFO.Location = new System.Drawing.Point(84, 65);
            this.LBLINFO.Name = "LBLINFO";
            this.LBLINFO.Size = new System.Drawing.Size(341, 13);
            this.LBLINFO.TabIndex = 11;
            this.LBLINFO.Text = "Une application permettant de génerer et de gérer ses mot de passes.  ";
            // 
            // LBLINFO1
            // 
            this.LBLINFO1.AutoSize = true;
            this.LBLINFO1.Location = new System.Drawing.Point(41, 78);
            this.LBLINFO1.Name = "LBLINFO1";
            this.LBLINFO1.Size = new System.Drawing.Size(460, 13);
            this.LBLINFO1.TabIndex = 12;
            this.LBLINFO1.Text = "Vous devez créer un compte afin de pouvoir commencer votre expérience sur cette a" +
    "pplication. ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Pour plus d\'informations sur les différents projets : ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(288, 400);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(120, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "cpntben.wordpress.com";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(513, 422);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBLINFO1);
            this.Controls.Add(this.LBLINFO);
            this.Controls.Add(this.LblErreurConnect);
            this.Controls.Add(this.CREA_BTN);
            this.Controls.Add(this.CREA_MDP);
            this.Controls.Add(this.CONNEC_STAYCONNEC);
            this.Controls.Add(this.CREA_MAIL);
            this.Controls.Add(this.CREA_NOM);
            this.Controls.Add(this.CONNECT_BTN);
            this.Controls.Add(this.CONNEC_MDP);
            this.Controls.Add(this.CONNEC_MAIL);
            this.Controls.Add(this.BTNCREA);
            this.Controls.Add(this.BTNCONNEC);
            this.Name = "FrmMain";
            this.Text = "Accueil - Connexion/Créer un compte";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNCONNEC;
        private System.Windows.Forms.Button BTNCREA;
        private System.Windows.Forms.TextBox CONNEC_MAIL;
        private System.Windows.Forms.TextBox CONNEC_MDP;
        private System.Windows.Forms.Button CONNECT_BTN;
        private System.Windows.Forms.TextBox CREA_NOM;
        private System.Windows.Forms.TextBox CREA_MAIL;
        private System.Windows.Forms.RadioButton CONNEC_STAYCONNEC;
        private System.Windows.Forms.TextBox CREA_MDP;
        private System.Windows.Forms.Button CREA_BTN;
        private System.Windows.Forms.Label LblErreurConnect;
        private System.Windows.Forms.Label LBLINFO;
        private System.Windows.Forms.Label LBLINFO1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

