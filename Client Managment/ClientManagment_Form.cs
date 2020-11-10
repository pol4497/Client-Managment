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
using System.Configuration;

namespace Client_Managment
{
    public partial class ClientManagment_Form : Form
    {
        Connect connect = new Connect();

        public ClientManagment_Form()
        {
            InitializeComponent();
        }

        private void ClientManagment_Form_Load(object sender, EventArgs e)
        {
            comboBox_Company.SelectedIndex = 0;
            LoadData();
        }

        private void clear_Button_Click(object sender, EventArgs e)
        {
            textBox_Name.Clear();
            textBox_Surename.Clear();
            textBox_Location.Clear();           
        }

        //Add Client Function
        private void add_Button_Click(object sender, EventArgs e)
        {
            string name = textBox_Name.Text;
            string surename = textBox_Surename.Text;
            string location = textBox_Location.Text;
            string business = comboBox_Company.Text;

            try
            {
                if (name.Trim().Equals("") || surename.Trim().Equals("") || location.Trim().Equals(""))
                {
                    MessageBox.Show("Όλα τα στοιχεία του πελάτη είναι απαιτούμενα!", "Κενά Στοιχεία", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    connect.OpenMySqlConnection();

                    string insertQuery = @"insert into client.client_info(ClientName, ClientSurename, ClientLocation, Business) " +
                                                                  "values('" + name + "', '" + surename + "', '" + location + "', '" + business + "')";
                    MySqlCommand command = new MySqlCommand(insertQuery, connect.GetMySqlConnection());
                    command.ExecuteNonQuery();

                    connect.CloseMySqlConnection();

                    MessageBox.Show("Ο πελάτης προστέθηκε επιτυχώς!", "Προσθήκη Πελάτη", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                }
                textBox_Name.Clear();
                textBox_Surename.Clear();
                textBox_Location.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Σφάλμα!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        //Update Client Function
        private void button_Update_Click(object sender, EventArgs e)
        {
            string name = textBox_Name.Text;
            string surename = textBox_Surename.Text;
            string location = textBox_Location.Text;
            string business = comboBox_Company.Text;

            try
            {
                if (name.Trim().Equals("") || surename.Trim().Equals("") || location.Trim().Equals(""))
                {
                    MessageBox.Show("Όλα τα στοιχεία του πελάτη είναι απαιτούμενα!", "Κενά Στοιχεία", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    connect.OpenMySqlConnection();

                    string editQuery = @"update client.client_info set ClientName='" + name + "', ClientSurename='" + surename + "', " +
                                        "ClientLocation='" + location + "', Business='" + business + "' where ClientName='" + name + "'";
                    MySqlCommand command = new MySqlCommand(editQuery, connect.GetMySqlConnection());
                    command.ExecuteNonQuery();

                    connect.CloseMySqlConnection();

                    MessageBox.Show("Ο πελάτης ανανεώθηκε επιτυχώς!", "Ανανέωση Πελάτη", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    LoadData();
                }
                textBox_Name.Clear();
                textBox_Surename.Clear();
                textBox_Location.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Σφάλμα!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                                   
        }

        //Delete Client Function
        private void button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                connect.OpenMySqlConnection();

                string editQuery = @"delete from client.client_info where ClientName='" + textBox_Name.Text + "'";
                MySqlCommand command = new MySqlCommand(editQuery, connect.GetMySqlConnection());
                command.ExecuteNonQuery();

                connect.CloseMySqlConnection();

                if (textBox_Name.Text.Trim().Equals("") || textBox_Surename.Text.Trim().Equals("") || textBox_Location.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Ο πελάτης δεν υπάρχει.", "Κενά Στοιχεία", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Ο πελάτης διαγράφτηκε επιτυχώς!", "Διαγραφή Πελάτη", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    textBox_Name.Clear();
                    textBox_Surename.Clear();
                    textBox_Location.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Σφάλμα!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Search the data
        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                connect.OpenMySqlConnection();
                MySqlCommand command = new MySqlCommand("select * from client.client_info where ClientName like '" + textBox_Search.Text + "'", connect.GetMySqlConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(table);
                DataGridView_ClientList.Rows.Clear();
                foreach (DataRow item in table.Rows)
                {
                    int n = DataGridView_ClientList.Rows.Add();
                    DataGridView_ClientList.Rows[n].Cells[0].Value = item["ClientName"].ToString();
                    DataGridView_ClientList.Rows[n].Cells[1].Value = item["ClientSurename"].ToString();
                    DataGridView_ClientList.Rows[n].Cells[2].Value = item["ClientLocation"].ToString();
                    DataGridView_ClientList.Rows[n].Cells[3].Value = item["Business"].ToString();
                }

                if (textBox_Search.Text == "")
                {
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Σφάλμα!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Read the data
        public void LoadData()
        {
            try
            {
                connect.OpenMySqlConnection();
                MySqlCommand command = new MySqlCommand("select * from client.client_info", connect.GetMySqlConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();

                adapter.SelectCommand = command;
                adapter.Fill(table);
                DataGridView_ClientList.Rows.Clear();
                foreach (DataRow item in table.Rows)
                {
                    int n = DataGridView_ClientList.Rows.Add();
                    DataGridView_ClientList.Rows[n].Cells[0].Value = item["ClientName"].ToString();
                    DataGridView_ClientList.Rows[n].Cells[1].Value = item["ClientSurename"].ToString();
                    DataGridView_ClientList.Rows[n].Cells[2].Value = item["ClientLocation"].ToString();
                    DataGridView_ClientList.Rows[n].Cells[3].Value = item["Business"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Σφάλμα!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        //Display Selected Row to the text boxes.
        private void DataGridView_ClientList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox_Name.Text = DataGridView_ClientList.CurrentRow.Cells[0].Value.ToString();
                textBox_Surename.Text = DataGridView_ClientList.CurrentRow.Cells[1].Value.ToString();
                textBox_Location.Text = DataGridView_ClientList.CurrentRow.Cells[2].Value.ToString();
                comboBox_Company.Text = DataGridView_ClientList.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Σφάλμα!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
