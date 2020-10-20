using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace Client_Managment
{

    //Add a new Client, edit the information, remove it 
    //and get all Clients

    class Client
    {
        Connect con = new Connect();

        //Insert new Client
        public bool insertClient(String name, String surename, String location, String business)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "insert into client_info(ClientName, ClientSurename, ClientLocation, Business) values (@name, @surename, @location, @business)";
            command.CommandText = insertQuery;
            command.Connection = con.GetMySqlConnection();

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@surename", MySqlDbType.VarChar).Value = surename;
            command.Parameters.Add("@location", MySqlDbType.VarChar).Value = location;
            command.Parameters.Add("@business", MySqlDbType.VarChar).Value = business;

            con.OpenMySqlConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                con.CloseMySqlConnection();
                return true;
            }
            else
            {
                con.CloseMySqlConnection();
                return false;
            }           
        }

        //Get Clients
        public DataTable getClients()
        {
            MySqlCommand command = new MySqlCommand("select * from client_info", con.GetMySqlConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
    }
}
