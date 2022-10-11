using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace C969AlishaCrockford
{
    public partial class CustomerDatabase : Form
    {
        public string connString = "server=127.0.0.1;user=sqlUser;pwd=Passw0rd!;Database=client_schedule;";
        public CustomerDatabase()
        {
            InitializeComponent();
            string connString = "server=127.0.0.1;user=sqlUser;pwd=Passw0rd!;Database=client_schedule;";
            string Query = ("SELECT customerId, customerName, customer.addressId, address, address2, address.cityId, city, postalCode, country, city.countryId, phone FROM customer" +
                    " INNER JOIN address AS address ON customer.addressId = address.addressId" +
                    " INNER JOIN city AS city ON address.cityId = city.cityId" +
                    " INNER JOIN country AS country ON city.countryId = country.countryId");
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand cmd = new MySqlCommand(Query, conn);
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dbTable = new DataTable();
            sda.Fill(dbTable);
            BindingSource dbSource = new BindingSource();
            dbSource.DataSource = dbTable;
            dataGridView1.DataSource = dbSource;
            sda.Update(dbTable);

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns["customerName"].HeaderText = "Name";
            dataGridView1.Columns["address"].HeaderText = "Address";
            dataGridView1.Columns["address2"].Visible = false;
            dataGridView1.Columns["phone"].HeaderText = "Phone";
            dataGridView1.Columns["city"].HeaderText = "City";
            dataGridView1.Columns["postalCode"].HeaderText = "Postal Code";
            dataGridView1.Columns["country"].HeaderText = "Country";
            dataGridView1.Columns["customerId"].Visible = false;
            dataGridView1.Columns["addressId"].Visible = false;
            dataGridView1.Columns["cityId"].Visible = false;
            dataGridView1.Columns["countryId"].Visible = false;

            textModifyCustName.Enabled = false;
            textModifyCustAddress.Enabled = false;
            textModifyCustPhone.Enabled = false;
            textModifyCustCity.Enabled = false;
            textModifyCustCountry.Enabled = false;
        }

        public void updateDatabase()
        {
        }

        private void buttonCustomerLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been logged out.");
            this.Close();
        }

        private void buttonCustomerBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void buttonCustomerLogout1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been logged out.");
            this.Hide();
            LoginScreen login = new LoginScreen();
            login.ShowDialog();
        }

        private void buttonCustomerModify_Click(object sender, EventArgs e)
        {
            textModifyCustName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textModifyCustAddress.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textModifyCustPhone.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            textModifyCustCity.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textModifyCustCountry.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();

            textModifyCustName.ReadOnly = false;
            textModifyCustAddress.ReadOnly = false;
            textModifyCustPhone.ReadOnly = false;
            textModifyCustCity.ReadOnly = false;
            textModifyCustCountry.ReadOnly = false;
            textModifyCustName.Enabled = true;
            textModifyCustAddress.Enabled = true;
            textModifyCustPhone.Enabled = true;
            textModifyCustCity.Enabled = true;
            textModifyCustCountry.Enabled = true;
        }

		private void buttonCustomerAdd_Click(object sender, EventArgs e)
		{

            this.Hide();
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
        }

        private void buttonCustomerDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string message = "Would you like to delete this customer record?";
                string caption = "";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.Yes)
                {
                    var conn = new MySqlConnection();
                    conn.ConnectionString = connString;
                    conn.Open();
                    int customerId = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    string deleteCustomer = $"DELETE FROM customer WHERE customerId={customerId}";
                    var delete = new MySqlCommand(deleteCustomer, conn);
                    delete.Prepare();
                    delete.ExecuteNonQuery();
                    dataGridView1.Rows.RemoveAt(row.Index);
                    MessageBox.Show("The selected customer record has been deleted.");
                    dataGridView1.CurrentCell.Selected = false;
                    return;
                }
                if (result == DialogResult.No)
                {
                    return;
                }

            }
        }

        private void buttonApptSave_Click(object sender, EventArgs e)
        {
            string customerId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string customerName = textModifyCustName.Text;
            string address = textModifyCustAddress.Text;
            string phone = textModifyCustPhone.Text;
            string city = textModifyCustCity.Text;
            string country = textModifyCustCountry.Text;

            var conn = new MySqlConnection();
            conn.ConnectionString = connString;
            conn.Open();

            string countryIDQuery = "SELECT countryId FROM country ORDER BY countryId DESC LIMIT 1";
            var countryIDCMD = new MySqlCommand(countryIDQuery, conn);
            int countryID = Convert.ToInt32(countryIDCMD.ExecuteScalar()) + 1;

            string countryAdd = $"INSERT INTO country VALUES({countryID}, '{country}', NOW(), 'test', NOW(), NOW())";
            var countryAddCMD = new MySqlCommand(countryAdd, conn);
            countryAddCMD.Prepare();
            countryAddCMD.ExecuteNonQuery();

            string cityIDQuery = "SELECT cityId FROM city ORDER by cityId DESC LIMIT 1";
            var cityIDCMD = new MySqlCommand(cityIDQuery, conn);
            int cityID = Convert.ToInt32(cityIDCMD.ExecuteScalar()) + 1;

            string cityAdd = $"INSERT INTO city VALUES({cityID}, '{city}', '{countryID}', NOW(), 'test', NOW(), 'test')";
            var cityAddCMD = new MySqlCommand(cityAdd, conn);
            cityAddCMD.Prepare();
            cityAddCMD.ExecuteNonQuery();

            string addressIDQuery = "SELECT addressId FROM address ORDER by addressId DESC LIMIT 1";
            var addressIDCMD = new MySqlCommand(addressIDQuery, conn);
            int addressID = Convert.ToInt32(addressIDCMD.ExecuteScalar()) + 1;

            string addressAdd = $"INSERT INTO address VALUES({addressID}, '{address}', '', {cityID}, 11111, '{phone}', NOW(), 'test', NOW(), 'test')";
            var addressAddCMD = new MySqlCommand(addressAdd, conn);
            addressAddCMD.Prepare();
            addressAddCMD.ExecuteNonQuery();

            string updateCustomer = $"UPDATE customer SET customerName = '{customerName}', addressId = '{addressID}' WHERE customerId = {customerId}";
            var updateCustomerCMD = new MySqlCommand(updateCustomer, conn);
            updateCustomerCMD.Prepare();
            updateCustomerCMD.ExecuteNonQuery();

            this.Hide();
            CustomerDatabase customerDatabase = new CustomerDatabase();
            customerDatabase.ShowDialog();
        }
    }
}
