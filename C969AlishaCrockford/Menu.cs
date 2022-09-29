using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969AlishaCrockford
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonMenuLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been logged out.");
            this.Close();
        }

        private void buttonMenuCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerDatabase customerDatabase = new CustomerDatabase();
            customerDatabase.Show();
        }

        private void buttonMenuAppointments_Click(object sender, EventArgs e)
        {
            this.Hide();
            Appointments appointments = new Appointments();
            appointments.ShowDialog();
        }

        private void buttonMenuReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports reports = new Reports();
            reports.ShowDialog();
        }
    }
}
