using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Client_Managment
{
    public class Connect
    {
        private MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=client;password=theodoros1997");        
        
        //This function returns connection
        public  MySqlConnection GetMySqlConnection()
        {
            return connection;
        }

        //This function opens connection
        public void OpenMySqlConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Σφάλμα!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //This function closes connection
        public void CloseMySqlConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Σφάλμα!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
