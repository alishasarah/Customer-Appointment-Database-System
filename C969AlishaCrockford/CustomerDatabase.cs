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

namespace C969AlishaCrockford
{
    public partial class CustomerDatabase : Form
    {
        public CustomerDatabase()
        {
            InitializeComponent();
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
            this.Close();
        }

        private void buttonCustomerModify_Click(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(constr);

                conn.Open();

                MessageBox.Show("Success!");
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("ex.Message");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                
            }
        }
    }
}
