using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Client_Managment
{
    class Connect
    {
        private MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;database=client;password=theodoros1997");        
        
        //This function returns connection
        public MySqlConnection GetMySqlConnection()
        {
            return connection;
        }

        //This function opens connection
        public void OpenMySqlConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //This function closes connection
        public void CloseMySqlConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
