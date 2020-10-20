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
        //Client client = new Client();
        Connect con = new Connect();
        Client client = new Client();

        public ClientManagment_Form()
        {
            InitializeComponent();
        }

        private void ClientManagment_Form_Load(object sender, EventArgs e)
        {
            comboBox_Company.SelectedIndex = 0;
            DataGridView_ClientList.DataSource = client.getClients();
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            textBox_Name.Clear();
            textBox_Surename.Clear();
            textBox_Location.Clear();
        }

        private void add_Button_Click(object sender, EventArgs e)
        {
            String name = textBox_Name.Text;
            String surename = textBox_Surename.Text;
            String location = textBox_Location.Text;
            String business = comboBox_Company.SelectedText;

            Boolean insertClient = client.insertClient("", "", "", "");

            if (name.Trim().Equals("") || surename.Trim().Equals("") || location.Trim().Equals(""))
            {
                MessageBox.Show("Όλα τα στοιχεία του πελάτη είναι απαιτούμενα!", "Κενά Στοιχεία", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (insertClient)
                {
                    MessageBox.Show("Ο πελάτης προστέθηκε επιτυχώς!", "Προσθήκη Πελάτη", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Σφάλμα - Ο πελάτης δεν προστέθηκε!", "Προσθήκη Πελάτη", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

           
    }
}
