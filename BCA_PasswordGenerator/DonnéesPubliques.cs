using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA_PasswordGenerator
{
    class DonnéesPubliques
    {
        #region déclaration des paramètres de connexion du serveur
        public static String myValuelogin = "sa"; // login du serveur SQL Server
        public static String myValueMpd = "info"; // mot de passe du serveur SQL Server
        public static String myValueServeur = Environment.MachineName; // nom du serveur SQL Server
        public static String myValueBD = "BCA_PASSWORDGENERATOR"; // nom de la base de données 
        #endregion

        public static String IDLOGIN;
        public static String NOM;
        public static int NBPWD;
        public static bool ConfirmViewPWD;

        
    }
}
