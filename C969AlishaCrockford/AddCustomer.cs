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
    public partial class AddCustomer : Form
    {
        public string connString = "server=127.0.0.1;user=sqlUser;pwd=Passw0rd!;Database=client_schedule;";
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void buttonAddCustSubmit_Click(object sender, EventArgs e)
        {
            string customerName = textAddCustName.Text;
            string address = textAddCustAddress.Text;
            string phone = textAddCustPhone.Text;
            string city = textAddCustCity.Text;
            string country = textAddCustCountry.Text;

            if (string.IsNullOrEmpty(textAddCustName.Text) || string.IsNullOrEmpty(textAddCustAddress.Text) || string.IsNullOrEmpty(textAddCustPhone.Text) || string.IsNullOrEmpty(textAddCustCity.Text) || string.IsNullOrEmpty(textAddCustCountry.Text))
            {
                MessageBox.Show("Please fill out all values.");
                return;
            }
            else
            {
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

                string customerIDQuery = "SELECT customerId FROM customer ORDER by customerId DESC LIMIT 1";
                var customerIDCMD = new MySqlCommand(customerIDQuery, conn);
                int customerID = Convert.ToInt32(customerIDCMD.ExecuteScalar()) + 1;

                string customerAdd = $"INSERT INTO customer VALUES({customerID}, '{customerName}', '{addressID}', 1, NOW(), 'test', NOW(), 'test')";
                var customerAddCMD = new MySqlCommand(customerAdd, conn);
                customerAddCMD.Prepare();
                customerAddCMD.ExecuteNonQuery();

                this.Hide();
                CustomerDatabase customerDatabase = new CustomerDatabase();
                customerDatabase.ShowDialog();
            }
            
        }

        private void buttonAddCustomerBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerDatabase customerDatabase = new CustomerDatabase();
            customerDatabase.ShowDialog();
        }

        private void buttonAddCustomerLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been logged out.");
            this.Hide();
            LoginScreen login = new LoginScreen();
            login.ShowDialog();
        }
    }
}
