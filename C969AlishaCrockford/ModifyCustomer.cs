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

namespace C969AlishaCrockford
{
    public partial class ModifyCustomer : Form
    {
        public string connString = "server=127.0.0.1;user=sqlUser;pwd=Passw0rd!;Database=client_schedule;";
        public string country;
        public string nameId;
        public string phone;
        public string addressId;
        public string cityId;
        public string customerId;
        public CustomerDatabase customerDatabase = null;
        public ModifyCustomer()
        {
            InitializeComponent();
        }

        public ModifyCustomer(Form callingForm)
        {
            InitializeComponent();
            //customerDatabase = callingForm as CustomerDatabase;
            //customerId = customerDatabase.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //var conn = new MySqlConnection();
            //conn.ConnectionString = connString;
            //conn.Open();

            //textModifyCustName.Text = customerDatabase.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            //textModifyCustAddress.Text = customerDatabase.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            //textModifyCustPhone.Text = customerDatabase.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            //textModifyCustCity.Text = customerDatabase.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            //textModifyCustCountry.Text = customerDatabase.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            //string searchCustomerIDQuery = $"SELECT * FROM customer WHERE customerId={customerId}";
            //var searchCMD = new MySqlCommand(searchCustomerIDQuery, conn);
            //DataTable newCustomer = new DataTable();

            //using (MySqlDataAdapter a = new MySqlDataAdapter(searchCMD))
            //{
            //    a.Fill(newCustomer);
            //}

            //textModifyCustName.Text = newCustomer.Rows[0][1].ToString();
            //nameId = newCustomer.Rows[0][1].ToString();

            //string searchAddressIDQuery = $"SELECT * FROM address WHERE addressId={newCustomer.Rows[0][2]}";
            //var searchAddressCMD = new MySqlCommand(searchAddressIDQuery, conn);
            //DataTable newAddress = new DataTable();

            //using (MySqlDataAdapter a = new MySqlDataAdapter(searchAddressCMD))
            //{
            //    a.Fill(newAddress);
            //}

            //textModifyCustAddress.Text = newAddress.Rows[0][1].ToString();
            //addressId = newAddress.Rows[0][0].ToString();
            //textModifyCustPhone.Text = newAddress.Rows[0][5].ToString();
            //phone = newAddress.Rows[0][5].ToString();

            //string searchCityQuery = $"SELECT * FROM city WHERE cityId={newAddress.Rows[0][3]}";
            //var searchCityCMD = new MySqlCommand(searchCityQuery, conn);
            //DataTable newCity = new DataTable();

            //using (MySqlDataAdapter a = new MySqlDataAdapter(searchCityCMD))
            //{
            //    a.Fill(newCity);
            //}

            //textModifyCustCity.Text = newCity.Rows[0][1].ToString();
            //cityId = newCity.Rows[0][0].ToString();

            //string searchCountryQuery = $"SELECT country.country FROM country WHERE countryId={newCity.Rows[0][2]}";
            //var searchCountryCMD = new MySqlCommand(searchCountryQuery, conn);
            //DataTable newCountry = new DataTable();

            //using (MySqlDataAdapter a = new MySqlDataAdapter(searchCountryCMD))
            //{
            //    a.Fill(newCountry);
            //}

            //textModifyCustCountry.Text = newCountry.Rows[0][0].ToString();
            //country = newCountry.Rows[0][0].ToString();

        }

        private void buttonModifyCustomerLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreen login = new LoginScreen();
            login.ShowDialog();
        }

        private void buttonModifyCustomerBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerDatabase customerDatabase = new CustomerDatabase();
            customerDatabase.ShowDialog();
        }

        private void buttonModifyCustSubmit_Click(object sender, EventArgs e)
        {
            string customerName = textModifyCustName.Text;
            string address = textModifyCustAddress.Text;
            string phone = textModifyCustPhone.Text;
            string city = textModifyCustCity.Text;
            string country = textModifyCustCountry.Text;

            if (string.IsNullOrEmpty(textModifyCustName.Text) || string.IsNullOrEmpty(textModifyCustAddress.Text) || string.IsNullOrEmpty(textModifyCustPhone.Text) || string.IsNullOrEmpty(textModifyCustCity.Text) || string.IsNullOrEmpty(textModifyCustCountry.Text))
            {
                MessageBox.Show("Please fill out all values.");
                return;
            }

            else
            {
               
            }
        }
    }
}
