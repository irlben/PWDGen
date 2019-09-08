using System;

namespace BCA_PasswordGenerator
{
    partial class FrmPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPassword));
            this.LblGnPWD = new System.Windows.Forms.Label();
            this.LblGrrPWD = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TRKLONG = new System.Windows.Forms.TrackBar();
            this.CHKCHIFFRE = new System.Windows.Forms.CheckBox();
            this.CHKCARACTSP = new System.Windows.Forms.CheckBox();
            this.CHKMAJ = new System.Windows.Forms.CheckBox();
            this.CHKPINCODE = new System.Windows.Forms.CheckBox();
            this.LBLLONGUEUR = new System.Windows.Forms.Label();
            this.TXTPWD = new System.Windows.Forms.TextBox();
            this.LBLLABEL = new System.Windows.Forms.Label();
            this.LBPWD = new System.Windows.Forms.ListBox();
            this.LBLSAVE = new System.Windows.Forms.Label();
            this.LBLQUITTER = new System.Windows.Forms.Label();
            this.LBLRESET = new System.Windows.Forms.Label();
            this.LBLGEN = new System.Windows.Forms.Label();
            this.ErreurTXTPWD = new System.Windows.Forms.Label();
            this.TXTBOXERREUR = new System.Windows.Forms.TextBox();
            this.LblMonCompte = new System.Windows.Forms.Label();
            this.PbxPicAccount = new System.Windows.Forms.PictureBox();
            this.DTGListPWD = new System.Windows.Forms.DataGridView();
            this.MaConnect = new System.Data.SqlClient.SqlConnection();
            this.monDataSet = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataTable2 = new System.Data.DataTable();
            this.dataTable3 = new System.Data.DataTable();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.PWD = new System.Data.SqlClient.SqlDataAdapter();
            this.BtnPWDSHOW = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TRKLONG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPicAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGListPWD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3)).BeginInit();
            this.SuspendLayout();
            // 
            // LblGnPWD
            // 
            this.LblGnPWD.AutoSize = true;
            this.LblGnPWD.Location = new System.Drawing.Point(27, 9);
            this.LblGnPWD.Name = "LblGnPWD";
            this.LblGnPWD.Size = new System.Drawing.Size(126, 13);
            this.LblGnPWD.TabIndex = 0;
            this.LblGnPWD.Text = "Générer un mot de passe";
            this.LblGnPWD.Click += new System.EventHandler(this.LblGnPWD_Click);
            // 
            // LblGrrPWD
            // 
            this.LblGrrPWD.AutoSize = true;
            this.LblGrrPWD.Location = new System.Drawing.Point(219, 9);
            this.LblGrrPWD.Name = "LblGrrPWD";
            this.LblGrrPWD.Size = new System.Drawing.Size(125, 13);
            this.LblGrrPWD.TabIndex = 1;
            this.LblGrrPWD.Text = "Gérer les mots de passes";
            this.LblGrrPWD.Click += new System.EventHandler(this.LblGrrPWD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "|";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "____________________________________________________________";
            this.label3.UseMnemonic = false;
            // 
            // TRKLONG
            // 
            this.TRKLONG.Location = new System.Drawing.Point(7, 105);
            this.TRKLONG.Maximum = 25;
            this.TRKLONG.Name = "TRKLONG";
            this.TRKLONG.Size = new System.Drawing.Size(201, 45);
            this.TRKLONG.TabIndex = 4;
            // 
            // CHKCHIFFRE
            // 
            this.CHKCHIFFRE.AutoSize = true;
            this.CHKCHIFFRE.Location = new System.Drawing.Point(19, 145);
            this.CHKCHIFFRE.Name = "CHKCHIFFRE";
            this.CHKCHIFFRE.Size = new System.Drawing.Size(56, 17);
            this.CHKCHIFFRE.TabIndex = 5;
            this.CHKCHIFFRE.Text = "Chiffre";
            this.CHKCHIFFRE.UseVisualStyleBackColor = true;
            // 
            // CHKCARACTSP
            // 
            this.CHKCARACTSP.AutoSize = true;
            this.CHKCARACTSP.Location = new System.Drawing.Point(105, 145);
            this.CHKCARACTSP.Name = "CHKCARACTSP";
            this.CHKCARACTSP.Size = new System.Drawing.Size(107, 17);
            this.CHKCARACTSP.TabIndex = 6;
            this.CHKCARACTSP.Text = "Caract. Spéciaux";
            this.CHKCARACTSP.UseVisualStyleBackColor = true;
            // 
            // CHKMAJ
            // 
            this.CHKMAJ.AutoSize = true;
            this.CHKMAJ.Location = new System.Drawing.Point(19, 169);
            this.CHKMAJ.Name = "CHKMAJ";
            this.CHKMAJ.Size = new System.Drawing.Size(47, 17);
            this.CHKMAJ.TabIndex = 7;
            this.CHKMAJ.Text = "MAJ";
            this.CHKMAJ.UseVisualStyleBackColor = true;
            // 
            // CHKPINCODE
            // 
            this.CHKPINCODE.AutoSize = true;
            this.CHKPINCODE.Location = new System.Drawing.Point(105, 169);
            this.CHKPINCODE.Name = "CHKPINCODE";
            this.CHKPINCODE.Size = new System.Drawing.Size(77, 17);
            this.CHKPINCODE.TabIndex = 8;
            this.CHKPINCODE.Text = "PIN CODE";
            this.CHKPINCODE.UseVisualStyleBackColor = true;
            // 
            // LBLLONGUEUR
            // 
            this.LBLLONGUEUR.AutoSize = true;
            this.LBLLONGUEUR.Location = new System.Drawing.Point(39, 89);
            this.LBLLONGUEUR.Name = "LBLLONGUEUR";
            this.LBLLONGUEUR.Size = new System.Drawing.Size(133, 13);
            this.LBLLONGUEUR.TabIndex = 9;
            this.LBLLONGUEUR.Text = "Longueur du mot de passe";
            // 
            // TXTPWD
            // 
            this.TXTPWD.BackColor = System.Drawing.SystemColors.Window;
            this.TXTPWD.Location = new System.Drawing.Point(61, 211);
            this.TXTPWD.MaxLength = 20;
            this.TXTPWD.Name = "TXTPWD";
            this.TXTPWD.Size = new System.Drawing.Size(111, 20);
            this.TXTPWD.TabIndex = 10;
            // 
            // LBLLABEL
            // 
            this.LBLLABEL.AutoSize = true;
            this.LBLLABEL.Location = new System.Drawing.Point(16, 214);
            this.LBLLABEL.Name = "LBLLABEL";
            this.LBLLABEL.Size = new System.Drawing.Size(39, 13);
            this.LBLLABEL.TabIndex = 11;
            this.LBLLABEL.Text = "Label :";
            // 
            // LBPWD
            // 
            this.LBPWD.FormattingEnabled = true;
            this.LBPWD.Location = new System.Drawing.Point(19, 261);
            this.LBPWD.Name = "LBPWD";
            this.LBPWD.Size = new System.Drawing.Size(341, 186);
            this.LBPWD.TabIndex = 12;
            // 
            // LBLSAVE
            // 
            this.LBLSAVE.AutoSize = true;
            this.LBLSAVE.BackColor = System.Drawing.Color.Azure;
            this.LBLSAVE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBLSAVE.Location = new System.Drawing.Point(30, 482);
            this.LBLSAVE.Name = "LBLSAVE";
            this.LBLSAVE.Size = new System.Drawing.Size(70, 15);
            this.LBLSAVE.TabIndex = 13;
            this.LBLSAVE.Text = "Sauvegarder";
            this.LBLSAVE.Click += new System.EventHandler(this.LBLSAVE_Click);
            // 
            // LBLQUITTER
            // 
            this.LBLQUITTER.AutoSize = true;
            this.LBLQUITTER.BackColor = System.Drawing.Color.Red;
            this.LBLQUITTER.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBLQUITTER.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBLQUITTER.Location = new System.Drawing.Point(304, 482);
            this.LBLQUITTER.Name = "LBLQUITTER";
            this.LBLQUITTER.Size = new System.Drawing.Size(40, 15);
            this.LBLQUITTER.TabIndex = 14;
            this.LBLQUITTER.Text = "Quitter";
            this.LBLQUITTER.Click += new System.EventHandler(this.LBLQUITTER_Click);
            // 
            // LBLRESET
            // 
            this.LBLRESET.AutoSize = true;
            this.LBLRESET.BackColor = System.Drawing.Color.Azure;
            this.LBLRESET.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBLRESET.Location = new System.Drawing.Point(125, 482);
            this.LBLRESET.Name = "LBLRESET";
            this.LBLRESET.Size = new System.Drawing.Size(62, 15);
            this.LBLRESET.TabIndex = 15;
            this.LBLRESET.Text = "Réinitialiser";
            this.LBLRESET.Click += new System.EventHandler(this.LBLRESET_Click);
            // 
            // LBLGEN
            // 
            this.LBLGEN.AutoSize = true;
            this.LBLGEN.BackColor = System.Drawing.Color.LightGreen;
            this.LBLGEN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBLGEN.Location = new System.Drawing.Point(313, 243);
            this.LBLGEN.Name = "LBLGEN";
            this.LBLGEN.Size = new System.Drawing.Size(47, 15);
            this.LBLGEN.TabIndex = 16;
            this.LBLGEN.Text = "Générer";
            this.LBLGEN.Click += new System.EventHandler(this.LBLGEN_Click);
            // 
            // ErreurTXTPWD
            // 
            this.ErreurTXTPWD.AutoSize = true;
            this.ErreurTXTPWD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErreurTXTPWD.ForeColor = System.Drawing.Color.Red;
            this.ErreurTXTPWD.Location = new System.Drawing.Point(173, 211);
            this.ErreurTXTPWD.Name = "ErreurTXTPWD";
            this.ErreurTXTPWD.Size = new System.Drawing.Size(14, 20);
            this.ErreurTXTPWD.TabIndex = 17;
            this.ErreurTXTPWD.Text = "!";
            // 
            // TXTBOXERREUR
            // 
            this.TXTBOXERREUR.BackColor = System.Drawing.Color.Red;
            this.TXTBOXERREUR.Location = new System.Drawing.Point(57, 201);
            this.TXTBOXERREUR.Multiline = true;
            this.TXTBOXERREUR.Name = "TXTBOXERREUR";
            this.TXTBOXERREUR.Size = new System.Drawing.Size(115, 40);
            this.TXTBOXERREUR.TabIndex = 18;
            // 
            // LblMonCompte
            // 
            this.LblMonCompte.AutoSize = true;
            this.LblMonCompte.Location = new System.Drawing.Point(310, 49);
            this.LblMonCompte.Name = "LblMonCompte";
            this.LblMonCompte.Size = new System.Drawing.Size(43, 13);
            this.LblMonCompte.TabIndex = 19;
            this.LblMonCompte.Text = "Compte";
            // 
            // PbxPicAccount
            // 
            this.PbxPicAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbxPicAccount.BackgroundImage")));
            this.PbxPicAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PbxPicAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PbxPicAccount.Image = ((System.Drawing.Image)(resources.GetObject("PbxPicAccount.Image")));
            this.PbxPicAccount.InitialImage = ((System.Drawing.Image)(resources.GetObject("PbxPicAccount.InitialImage")));
            this.PbxPicAccount.Location = new System.Drawing.Point(304, 65);
            this.PbxPicAccount.Name = "PbxPicAccount";
            this.PbxPicAccount.Size = new System.Drawing.Size(56, 51);
            this.PbxPicAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxPicAccount.TabIndex = 20;
            this.PbxPicAccount.TabStop = false;
            // 
            // DTGListPWD
            // 
            this.DTGListPWD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGListPWD.Location = new System.Drawing.Point(7, 261);
            this.DTGListPWD.Name = "DTGListPWD";
            this.DTGListPWD.Size = new System.Drawing.Size(353, 251);
            this.DTGListPWD.TabIndex = 21;
            // 
            // MaConnect
            // 
            this.MaConnect.ConnectionString = "Data Source=LAPTOP-MVV4G7JH;Initial Catalog=BCA_PASSWORDGENERATOR;User ID=sa;Pass" +
    "word=info";
            this.MaConnect.FireInfoMessageEventOnUserErrors = false;
            // 
            // monDataSet
            // 
            this.monDataSet.DataSetName = "NewDataSet";
            this.monDataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1,
            this.dataTable2,
            this.dataTable3});
            // 
            // dataTable1
            // 
            this.dataTable1.TableName = "Libelle";
            // 
            // dataTable2
            // 
            this.dataTable2.TableName = "Password";
            // 
            // dataTable3
            // 
            this.dataTable3.TableName = "Date";
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT Libelle, PWD, date_creation FROM PWD WHERE (idLOG = 5)";
            this.sqlSelectCommand1.Connection = this.MaConnect;
            // 
            // PWD
            // 
            this.PWD.SelectCommand = this.sqlSelectCommand1;
            this.PWD.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "PWD", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Libelle", "Libelle"),
                        new System.Data.Common.DataColumnMapping("PWD", "PWD"),
                        new System.Data.Common.DataColumnMapping("date_creation", "date_càreation"),
                        new System.Data.Common.DataColumnMapping("id", "id")})});
            // 
            // BtnPWDSHOW
            // 
            this.BtnPWDSHOW.Location = new System.Drawing.Point(12, 230);
            this.BtnPWDSHOW.Name = "BtnPWDSHOW";
            this.BtnPWDSHOW.Size = new System.Drawing.Size(141, 25);
            this.BtnPWDSHOW.TabIndex = 22;
            this.BtnPWDSHOW.Text = "Afficher les mots de passe";
            this.BtnPWDSHOW.UseVisualStyleBackColor = true;
            this.BtnPWDSHOW.Click += new System.EventHandler(this.BtnPWDSHOW_Click);
            // 
            // FrmPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(372, 524);
            this.ControlBox = false;
            this.Controls.Add(this.BtnPWDSHOW);
            this.Controls.Add(this.DTGListPWD);
            this.Controls.Add(this.PbxPicAccount);
            this.Controls.Add(this.LblMonCompte);
            this.Controls.Add(this.TXTBOXERREUR);
            this.Controls.Add(this.ErreurTXTPWD);
            this.Controls.Add(this.LBLGEN);
            this.Controls.Add(this.LBLRESET);
            this.Controls.Add(this.LBLQUITTER);
            this.Controls.Add(this.LBLSAVE);
            this.Controls.Add(this.LBPWD);
            this.Controls.Add(this.LBLLABEL);
            this.Controls.Add(this.TXTPWD);
            this.Controls.Add(this.LBLLONGUEUR);
            this.Controls.Add(this.CHKPINCODE);
            this.Controls.Add(this.CHKMAJ);
            this.Controls.Add(this.CHKCARACTSP);
            this.Controls.Add(this.CHKCHIFFRE);
            this.Controls.Add(this.TRKLONG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblGrrPWD);
            this.Controls.Add(this.LblGnPWD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmPassword";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TRKLONG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPicAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGListPWD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblGnPWD;
        private System.Windows.Forms.Label LblGrrPWD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar TRKLONG;
        private System.Windows.Forms.CheckBox CHKCHIFFRE;
        private System.Windows.Forms.CheckBox CHKCARACTSP;
        private System.Windows.Forms.CheckBox CHKMAJ;
        private System.Windows.Forms.CheckBox CHKPINCODE;
        private System.Windows.Forms.Label LBLLONGUEUR;
        private System.Windows.Forms.TextBox TXTPWD;
        private System.Windows.Forms.Label LBLLABEL;
        private System.Windows.Forms.ListBox LBPWD;
        private System.Windows.Forms.Label LBLSAVE;
        private System.Windows.Forms.Label LBLQUITTER;
        private System.Windows.Forms.Label LBLRESET;
        private System.Windows.Forms.Label LBLGEN;
        private System.Windows.Forms.Label ErreurTXTPWD;
        private System.Windows.Forms.TextBox TXTBOXERREUR;
        private System.Windows.Forms.Label LblMonCompte;
        private System.Windows.Forms.PictureBox PbxPicAccount;
        private System.Windows.Forms.DataGridView DTGListPWD;
        private System.Data.SqlClient.SqlConnection MaConnect;
        private System.Data.DataSet monDataSet;
        private System.Data.DataTable dataTable1;
        private System.Data.DataTable dataTable2;
        private System.Data.DataTable dataTable3;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlDataAdapter PWD;
        private System.Windows.Forms.Button BtnPWDSHOW;
    }
}