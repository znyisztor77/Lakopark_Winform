using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Lakopark_Winform
{
    class Adatbazis
    {
        MySqlConnection connection = null;
        MySqlCommand sql = null;

        //SELECT  * FROM lakopark NATURAL JOIN epuletek;

        public Adatbazis()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();

            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "lakopark";
            sb.CharacterSet = "utf8";
            connection = new MySqlConnection(sb.ConnectionString);

            try
            {
                kapcsolatNyit();

            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                kapcsolatZar();
            }
        }

        internal List<Lakopark> parkadatokBetoltese()
        {
            List<Lakopark> lp = new List<Lakopark>();

            return lp;
        }

        private void kapcsolatZar()
        {
            if (connection.State != System.Data.ConnectionState.Closed) connection.Close();
        }

        private void kapcsolatNyit()
        {
            if (connection.State != System.Data.ConnectionState.Open) connection.Open();
           
        }
    }
}
