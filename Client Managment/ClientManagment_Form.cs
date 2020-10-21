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

        //Add a Client
        private void add_Button_Click(object sender, EventArgs e)
        {
            String name = textBox_Name.Text;
            String surename = textBox_Surename.Text;
            String location = textBox_Location.Text;
            String business = comboBox_Company.Text;

            if (name.Trim().Equals("") || surename.Trim().Equals("") || location.Trim().Equals(""))
            {
                MessageBox.Show("Όλα τα στοιχεία του πελάτη είναι απαιτούμενα!", "Κενά Στοιχεία", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Boolean insertClient = client.insertClient(name, surename, location, business);

                if (insertClient)
                {
                    DataGridView_ClientList.DataSource = client.getClients();
                    MessageBox.Show("Ο πελάτης προστέθηκε επιτυχώς!", "Προσθήκη Πελάτη", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Σφάλμα - Ο πελάτης δεν προστέθηκε!", "Προσθήκη Πελάτη", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Update a Client
        private void button_Update_Click(object sender, EventArgs e)
        {
            String name = textBox_Name.Text;
            String surename = textBox_Surename.Text;
            String location = textBox_Location.Text;
            String business = comboBox_Company.Text;

            if (name.Trim().Equals("") || surename.Trim().Equals("") || location.Trim().Equals(""))
            {
                MessageBox.Show("Κάποια στοιχεία είναι άδεια!", "Κενά Στοιχεία", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Boolean editClient = client.editClient(name, surename, location, business);

                if (editClient)
                {
                    DataGridView_ClientList.DataSource = client.getClients();
                    MessageBox.Show("Ο πελάτης ανανεώθηκε επιτυχώς!", "Ανανέωση Πελάτη", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Σφάλμα - Ο πελάτης δεν ανανεώθηκε!", "Ανανέωση Πελάτη", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Display Selected Row to the text boxes.
        private void DataGridView_ClientList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_Name.Text = DataGridView_ClientList.CurrentRow.Cells[0].Value.ToString();
            textBox_Surename.Text = DataGridView_ClientList.CurrentRow.Cells[1].Value.ToString();
            textBox_Location.Text = DataGridView_ClientList.CurrentRow.Cells[2].Value.ToString();
            comboBox_Company.Text = DataGridView_ClientList.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
