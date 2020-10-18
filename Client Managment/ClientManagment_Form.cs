using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Client_Managment
{
    public partial class ClientManagment_Form : Form
    {
        public ClientManagment_Form()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClientManagment_Form_Load(object sender, EventArgs e)
        {
            company_comboBox.SelectedIndex = 1;
        }

        private void add_Button_Click(object sender, EventArgs e)
        {
            Connect con = new Connect();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = "select * from client.client_info where ClientName = 'Όνομα' and ClientSurename = 'Επίθετο' and ClientLocation = 'Τοποθεσία' and Business = 'Επιχείρηση'";

            command.CommandText = query;
            command.Connection = con.GetMySqlConnection();

            adapter.SelectCommand = command;
            adapter.Fill(table);
        }
    }
}
