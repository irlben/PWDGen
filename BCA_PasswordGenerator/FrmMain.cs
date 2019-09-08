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
    public partial class FrmMain : Form
    {
        Form FrmPassword = new FrmPassword();
        SqlConnection gObjetConnection = new SqlConnection();
        String strRequete;
        SqlCommand command;

        #region Déclaration des String de Création
        String nom;
        String email;
        String Password;

        #endregion

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
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LblErreurConnect.Visible = false;
            CONNECT_BTN.Visible = false;
            CONNEC_MAIL.Visible = false;
            CONNEC_MDP.Visible = false;
            CONNEC_STAYCONNEC.Visible = false;

            CREA_BTN.Visible = false;
            CREA_MAIL.Visible = false;
            CREA_MDP.Visible = false;
            CREA_NOM.Visible = false;
        }

        private void BTNCREA_Click(object sender, EventArgs e)
        {
            CREA_BTN.Visible = true;
            CREA_MAIL.Visible = true;
            CREA_MDP.Visible = true;
            CREA_NOM.Visible = true;
            BTNCREA.Visible = false;
            BTNCONNEC.Visible = true;
            CONNEC_STAYCONNEC.Visible = false;
            CONNEC_MDP.Visible = false;
            CONNEC_MAIL.Visible = false;
            CONNECT_BTN.Visible = false;
            LBLINFO.Visible = false;
            LBLINFO1.Visible = false;
            this.Text = "Accueil - Créer un compte";
        }

        private void BTNCONNEC_Click(object sender, EventArgs e)
        {
            CONNECT_BTN.Visible = true;
            CONNEC_MAIL.Visible = true;
            CONNEC_MDP.Visible = true;
            CONNEC_STAYCONNEC.Visible = true;
            BTNCREA.Visible = true;
            BTNCONNEC.Visible = false;
            LBLINFO.Visible = false;
            LBLINFO1.Visible = false;
            CREA_BTN.Visible = false;
            CREA_MAIL.Visible = false;
            CREA_MDP.Visible = false;
            CREA_NOM.Visible = false;

            this.Text = "Accueil - Connexion";
        }

        private void CREA_BTN_Click(object sender, EventArgs e)
        {
            CREA_BTN.Visible = false;
            CREA_MAIL.Visible = false;
            CREA_MDP.Visible = false;
            CREA_NOM.Visible = false;
            BTNCREA.Visible = true;
            BTNCONNEC.Visible = true;
           

            nom = CREA_NOM.Text;
            Password = CREA_MDP.Text;
            email = CREA_MAIL.Text;
            MaConnexion();
            strRequete = "INSERT INTO LOGIN (nom,mail,pass) VALUES ('" + nom + "','" + email + "','" + Password + "')";

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
        }

        private void CONNECT_BTN_Click(object sender, EventArgs e)
        {

            MaConnexion();
            email = CONNEC_MAIL.Text;
            Password = CONNEC_MDP.Text;
            String nb1;
            strRequete = "SELECT pass FROM LOGIN WHERE mail = '" + email + "'";
            try
            {
                // instanciation de l'objet command en passant comme argument au constructeur
                // la requete ainsi que la connexion
                command = new SqlCommand(strRequete, gObjetConnection);
                // Déclaration d'un objet destiné à recevoir le résultat de la requete

                // affectation de cet objet (avec le résultat la requete)
                // en utilisant la méthode ExecuteScalar() sur notre objet command
                try
                {
                    nb1 = command.ExecuteScalar().ToString();
                }
                catch
                {
                    nb1 = " ";
                }


                if (nb1 == Password)
                {
                    
                    strRequete = "SELECT id FROM LOGIN WHERE mail = '" + email + "' and pass =  '"+nb1+"'";
                    try
                    {
                        // instanciation de l'objet command en passant comme argument au constructeur
                        // la requete ainsi que la connexion
                        command = new SqlCommand(strRequete, gObjetConnection);
                        // Déclaration d'un objet destiné à recevoir le résultat de la requete

                        // affectation de cet objet (avec le résultat la requete)
                        // en utilisant la méthode ExecuteScalar() sur notre objet command
                      
                            nb1 = command.ExecuteScalar().ToString();
                        DonnéesPubliques.IDLOGIN = nb1;
                       
                       
                        
                    }
                    catch
                    {

                    }
                    strRequete = "SELECT nom FROM LOGIN WHERE id = '" + DonnéesPubliques.IDLOGIN.ToString() + "'";
                    try
                    {
                        // instanciation de l'objet command en passant comme argument au constructeur
                        // la requete ainsi que la connexion
                        command = new SqlCommand(strRequete, gObjetConnection);
                        // Déclaration d'un objet destiné à recevoir le résultat de la requete

                        // affectation de cet objet (avec le résultat la requete)
                        // en utilisant la méthode ExecuteScalar() sur notre objet command

                        nb1 = command.ExecuteScalar().ToString();
                        DonnéesPubliques.NOM = nb1;



                    }
                    catch
                    {

                    }
                    strRequete = "SELECT COUNT(*) FROM PWD WHERE idLOG = '" + DonnéesPubliques.IDLOGIN.ToString() + "'";
                    try
                    {
                        // instanciation de l'objet command en passant comme argument au constructeur
                        // la requete ainsi que la connexion
                        command = new SqlCommand(strRequete, gObjetConnection);
                        // Déclaration d'un objet destiné à recevoir le résultat de la requete

                        // affectation de cet objet (avec le résultat la requete)
                        // en utilisant la méthode ExecuteScalar() sur notre objet command

                        nb1 = command.ExecuteScalar().ToString();
                        DonnéesPubliques.NBPWD = Convert.ToInt16(nb1);



                    }
                    catch
                    {

                    }
                    Connect();

                }
                else
                {
                    MessageBox.Show("Une erreur s'est produite ! Veuillez vérifier que vos identifiants sont corrects.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LblErreurConnect.Visible = true;
                }

            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("Problème dans la requete : " + probleme.Message);
            }

            MaDeconnexion();

        }
        void Connect()
        {
            MaDeconnexion();


            if (CONNEC_STAYCONNEC.Checked)
            {
                
                MaConnexion();
                strRequete = "INSERT INTO AUTOCONNECT (idLOGIN,stayconnect) VALUES ('" + Convert.ToInt16(DonnéesPubliques.IDLOGIN) + "',1)";

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
                this.Hide();
                FrmPassword.ShowDialog();


            }else
            {
                this.Hide();
                FrmPassword.ShowDialog();
            }
        }

        private void CREA_NOM_Click(object sender, EventArgs e)
        {
            CREA_NOM.Clear();
        }

        private void CREA_MAIL_Click(object sender, EventArgs e)
        {
            CREA_MAIL.Clear();
        }

        private void CREA_MDP_Click(object sender, EventArgs e)
        {
            CREA_MDP.Clear();
        }

        private void CONNEC_MDP_Click(object sender, EventArgs e)
        {
            CONNEC_MDP.Clear();
        }

        private void CONNEC_MAIL_Click(object sender, EventArgs e)
        {
            CONNEC_MAIL.Clear();
        }
    }
}
