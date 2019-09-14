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
    public partial class FrmConfirmPWD : Form
    {
        SqlConnection gObjetConnection = new SqlConnection();
        String strRequete;
        SqlCommand command;
        String email, password;
        public FrmConfirmPWD()
        {
            InitializeComponent();
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




        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaConnexion();
            email = textBox1.Text;
            password = textBox2.Text;
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


                if (nb1 == password)
                {

                    strRequete = "SELECT id FROM LOGIN WHERE mail = '" + email + "' and pass =  '" + nb1 + "'";
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
                        DonnéesPubliques.ConfirmViewPWD = true;


                    }
                    catch
                    {

                    }
                    
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Une erreur s'est produite ! Veuillez vérifier que vos identifiants sont corrects.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DonnéesPubliques.ConfirmViewPWD = false;
                    LblErreurConnect.Visible = true;
                }

            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("Problème dans la requete : " + probleme.Message);
            }

            MaDeconnexion();

        }
    }
    }
