using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCA_PasswordGenerator
{
    public partial class FrmPassword : Form
    {
        public FrmPassword()
        {
            DonnéesPubliques.IDLOG  = Convert.ToString(0); 
            InitializeComponent();
        }
        SqlConnection gObjetConnection = new SqlConnection();
        String strRequete;
        SqlCommand command;
        
        String Chiffre = "0123456789";
        String MAJ = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        String MIN = "abcdefghijklmnopqrstuvwxyz";
        String CARACSPECIAUX = @"!@#$%^&*()_+|}{:?><\][';/.,""";
        private void FrmPassword_Load(object sender, EventArgs e)
        {
            this.Text = "Compte : "+DonnéesPubliques.NOM+ " possédant "+DonnéesPubliques.NBPWD+" mots de passe";
            LblGnPWD.Font = new Font("Microsoft Sans Serif",8.25F, FontStyle.Bold);
            ErreurTXTPWD.Visible = false;
            TXTBOXERREUR.Visible = false;
            BtnPWDSHOW.Visible = false;
            DTGListPWD.Visible = false;
            LblMonCompte.Visible = false;
            PbxPicAccount.Visible = false;
        }
        private void MaConnexion()
        {
            // La propriété ConnectionString de notre objet gObjetConnection doit contenir les paramètres de connexion au serveur
            gObjetConnection.ConnectionString = "User ID = " + DonnéesPubliques.myValuelogin + ";PWD= " + DonnéesPubliques.myValueMpd + " ; Server= " + DonnéesPubliques.myValueServeur + "; Database= " + DonnéesPubliques.myValueBD + "; ";
            try //Tentative (try) d'ouverture d'un connexion avec le serveur de base de données
            {
                // Oyvrir la connexion en utilisant la méthode open() sur notre objet gObjetConnection
                gObjetConnection.Open();
            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("Impossible de se connecter au serveur de base de données." + probleme.Message);
            }
        }
        private void MaDeconnexion()
        {
            gObjetConnection.Close();
        }
        private void GenPWDMODE()
        {
            /**
             * Les éléments nécessaire pour générer un mot de passe
             * Quand on clique sur le libéllé 'Générer un mot de passe'
             * Ce mode s'active
             */
            // TRUE
            LBLGEN.Visible = true;
            LBLLABEL.Visible = true;
            LBLLONGUEUR.Visible = true;
            LBLQUITTER.Visible = true;
            LBLRESET.Visible = true;
            LBLSAVE.Visible = true;
            TXTPWD.Visible = true;
            LBPWD.Visible = true;
            TRKLONG.Visible = true;
            CHKCARACTSP.Visible = true;
            CHKCHIFFRE.Visible = true;
            CHKMAJ.Visible = true;
            CHKPINCODE.Visible = true;

            // FALSE
            TXTBOXERREUR.Visible = false;
            BtnPWDSHOW.Visible = false;
            DTGListPWD.Visible = false;
            LblMonCompte.Visible = false;
            PbxPicAccount.Visible = false;

        }
        private void GERPWDMODE()
        {
            LBLGEN.Visible = false;
            LBLLABEL.Visible = false;
            LBLLONGUEUR.Visible = false;
            LBLQUITTER.Visible = false;
            LBLRESET.Visible = false;
            LBLSAVE.Visible = false;
            TXTPWD.Visible = false;
            LBPWD.Visible = false;
            TRKLONG.Visible = false;
            CHKCARACTSP.Visible = false;
            CHKCHIFFRE.Visible = false;
            CHKMAJ.Visible = false;
            CHKPINCODE.Visible = false;
            ErreurTXTPWD.Visible = false;

            BtnPWDSHOW.Visible = true;
            DTGListPWD.Visible = true;
            LblMonCompte.Visible = true;
            PbxPicAccount.Visible = true;
        }
        private void LblGnPWD_Click(object sender, EventArgs e)
        {
            LblGnPWD.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            LblGrrPWD.Font = new Font("Microsoft Sans Serif", 8.25F);
            GenPWDMODE();
            
        }

        private void LBLGEN_Click(object sender, EventArgs e)
        {
            LBLGEN.BorderStyle = BorderStyle.None;
            LBLGEN.BorderStyle = BorderStyle.Fixed3D;
            LBPWD.Items.Clear();
            String characters = "";
            
            int NBPASS = 4;
            Random r = new Random();
            if (TRKLONG.Value > 1)
            {

                characters += MIN;
            if(CHKCHIFFRE.Checked)
            {
                characters += Chiffre;
            }
            if(CHKCARACTSP.Checked)
            {
                characters += CARACSPECIAUX;
            }
            if(CHKMAJ.Checked)
            {
                characters += MAJ;
            }
            if(CHKPINCODE.Checked)
            {
                characters = "";
                characters += Chiffre;
            }

            if(characters.Length >= 1)
            {
                do
                {
                        String password = "";
                        int i = 0;
                    for (i = 0; i < TRKLONG.Value; i++)
                    {
                        password += characters[r.Next(0, characters.Length)];
                    }
                    LBPWD.Items.Add(password);
                    NBPASS = NBPASS - 1;
                } while (NBPASS >= 1);
                
            }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner la longueur du mot de passe");
            }
        }

        private void LBLSAVE_Click(object sender, EventArgs e)
        {
            if (TXTPWD.TextLength > 1)
            {

                DateTime sdate = DateTime.Now;
            MaConnexion();
            strRequete = "INSERT INTO PWD (idLOG,Libelle,PWD,date_creation) VALUES ('" + DonnéesPubliques.IDLOGIN.ToString() + "','" + TXTPWD.Text + "','" + LBPWD.SelectedItem.ToString() + "','" + sdate + "')";

            try
            {
                command = new SqlCommand(strRequete, gObjetConnection);
                command.ExecuteNonQuery();


            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("Problème dans la requete : " + probleme.Message);
            }
            MaDeconnexion();

            MessageBox.Show("Votre mot de passe à bien été sauvegarder\nPour consulter votre mot de passe, veuillez consulter la rubrique 'Gérer mes mots de passes'\n Si votre mot de passe n'apparaît pas dans cette rubrique\n Contactez : services@Carpentier.fr", "Information lié à votre mot de passe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TXTPWD.Clear();
                LBPWD.Items.Clear();
                CHKCARACTSP.CheckState = 0;
                CHKCHIFFRE.CheckState = 0;
                CHKMAJ.CheckState = 0;
                CHKPINCODE.CheckState = 0;
                TRKLONG.Value = 0;
            } else
            {
                TXTBOXERREUR.Visible = true;
                TXTBOXERREUR.Visible = false;
                TXTBOXERREUR.Visible = true;
                TXTBOXERREUR.Visible = false;
                MessageBox.Show("Veuillez renseigner le champs ci dessus.", "Erreur de génération", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErreurTXTPWD.Visible = true;
                
            }
        }

        private void LBLQUITTER_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LBLRESET_Click(object sender, EventArgs e)
        {
            TXTPWD.Clear();
            LBPWD.Items.Clear();
            CHKCARACTSP.CheckState = 0;
            CHKCHIFFRE.CheckState = 0;
            CHKMAJ.CheckState = 0;
            CHKPINCODE.CheckState = 0;
            TRKLONG.Value = 0;
        }

        private void LblGrrPWD_Click(object sender, EventArgs e)
        {
            LblGrrPWD.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            LblGnPWD.Font = new Font("Microsoft Sans Serif", 8.25F);
            GERPWDMODE();
            
        }
        private void ListePWD()
        {
            try
            {
                MaConnect.Open();
                PWD.Fill(monDataSet, "Libelle");
                PWD.Fill(monDataSet, "PWD");
                PWD.Fill(monDataSet, "date_creation");
            }
            catch (System.Data.SqlClient.SqlException probleme)
            {

                MessageBox.Show("impossible de se connecter au serveur de base de données : " + probleme);
            }
            MaConnect.Close();
        }
        private void AFFICHEPWD ()
        {
            this.DTGListPWD.AllowUserToAddRows = false;
            this.DTGListPWD.AllowUserToResizeColumns = false;
            this.DTGListPWD.RowHeadersVisible = false;
            this.DTGListPWD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            DataTable uneTable = new DataTable();
            uneTable = monDataSet.Tables["Libelle"];
            DTGListPWD.DataSource = uneTable;

            DTGListPWD.AutoResizeColumns();
            DTGListPWD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DTGListPWD.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
        }

        private void BtnPWDSHOW_Click(object sender, EventArgs e)
        {
            DonnéesPubliques.IDLOG = DonnéesPubliques.IDLOGIN;
            ListePWD();
            AFFICHEPWD();
        }
    }
    
}
