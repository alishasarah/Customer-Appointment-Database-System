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
    public partial class AddAppointment : Form
    {
        public string connString = "server=127.0.0.1;user=sqlUser;pwd=Passw0rd!;Database=client_schedule;";
        public AddAppointment()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string customerID = textAddApptCustomer.Text;
            string userID = textAddApptUser.Text;
            string _virtual = btnVirtual.Text;
            string inPerson = btnInPerson.Text;
            string start = dateTimeStart.Text;
            string end = dateTimeEnd.Text;
            Convert.ToDateTime(start);
            Convert.ToDateTime(end);

            bool noOverlap()
            {
                bool overlap = false;
                var conn = new MySqlConnection();
                conn.ConnectionString = connString;
                conn.Open();
                string apptOverlap = $"SELECT * FROM appointment WHERE start between '{start}' AND '{end}' AND userId = '{userID}' OR end between '{start}' AND '{end}' AND userId = '{userID}'";
                var overlapCMD = new MySqlCommand(apptOverlap, conn);
                int overlapID = Convert.ToInt32(overlapCMD.ExecuteScalar());

                if (overlapID != 0)
                {
                    overlap = false;
                }
                else
                {
                    overlap = true;
                }
                return overlap;
            }
            bool customerExists()
            {
                bool cust = false;
                var connection = new MySqlConnection();
                connection.ConnectionString = connString;
                connection.Open();
                string custIDCheck = $"SELECT * FROM customer WHERE customerId = '{customerID}'";
                var custIDCMD = new MySqlCommand(custIDCheck, connection);
                int custIDIndex = Convert.ToInt32(custIDCMD.ExecuteScalar());

                if (custIDIndex != 0)
                {
                    cust = true;
                }
                else
                {
                    cust = false;
                }
                return cust;
            }

            bool userExists()
            {
                bool user = false;
                var connection = new MySqlConnection();
                connection.ConnectionString = connString;
                connection.Open();
                string userIDCheck = $"SELECT * FROM user WHERE userId = '{userID}'";
                var userIDCMD = new MySqlCommand(userIDCheck, connection);
                int userIDIndex = Convert.ToInt32(userIDCMD.ExecuteScalar());

                if (userIDIndex != 0)
                {
                    user = true;
                }
                else
                {
                    user = false;
                }
                return user;
            }

            if (string.IsNullOrEmpty(textAddApptCustomer.Text) || 
                ((btnInPerson.Checked = false) && (btnVirtual.Checked = false)) || 
                dateTimeStart.Value < DateTime.Now || 
                dateTimeStart.Value > dateTimeEnd.Value || 
                dateTimeEnd.Value < DateTime.Now)
            {
                MessageBox.Show("Please fill out all values and ensure that the start time is prior to the end time.");
                return;
            }
            else if (dateTimeStart.Value.ToLocalTime().Hour < 8 
                || dateTimeStart.Value.ToLocalTime().Hour > 23
                || dateTimeEnd.Value.ToLocalTime().Hour < 8 
                || dateTimeEnd.Value.ToLocalTime().Hour > 23)
            {
                MessageBox.Show("Please enter a valid appointment between our business hours of 8am and 6pm.");
                return;
            }
            else if (noOverlap() == false)
            {
                MessageBox.Show("There is a scheduling conflict with existing appointments for this user.");
            }
            else if (customerExists() == false)
            {
                MessageBox.Show("There is no customer in the database that matches that customer ID.");
                return;
            }
            else if (userExists() == false)
            {
                MessageBox.Show("Please enter a valid user ID.");
                return;
            }
            else
            {

                var conn = new MySqlConnection();
                conn.ConnectionString = connString;
                conn.Open();

                string apptIDQuery = "SELECT appointmentId FROM appointment ORDER BY appointmentId DESC LIMIT 1";
                var apptIDCMD = new MySqlCommand(apptIDQuery, conn);
                int apptID = Convert.ToInt32(apptIDCMD.ExecuteScalar()) + 1;

                if (btnVirtual.Text == "Virtual ")
                {
                    string apptAdd = $"INSERT INTO appointment VALUES({apptID}, '{customerID}', '{userID}', '', '', '', '', '{_virtual}', '', '{start}', '{end}', NOW(), '', NOW(), '')";
                    var apptAddCMD = new MySqlCommand(apptAdd, conn);
                    apptAddCMD.Prepare();
                    apptAddCMD.ExecuteNonQuery();
                }

                else
                {
                    string apptAdd = $"INSERT INTO appointment VALUES({apptID}, '{customerID}', '{userID}', '', '', '', '', '{inPerson}', '', '{start}', '{end}', NOW(), '', NOW(), '')";
                    var apptAddCMD = new MySqlCommand(apptAdd, conn);
                    apptAddCMD.Prepare();
                    apptAddCMD.ExecuteNonQuery();
                }

                this.Hide();
                Appointments appointments = new Appointments();
                appointments.ShowDialog();
            }
        }

        private void btnVirtual_CheckedChanged(object sender, EventArgs e)
        {
            btnVirtual.Text = "Virtual ";
        }

        private void btnInPerson_CheckedChanged(object sender, EventArgs e)
        {
            btnInPerson.Text = "In-Person ";
;        }

        private void buttonAppointmentLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been logged out.");
            this.Hide();
            LoginScreen login = new LoginScreen();
            login.ShowDialog();
        }

        private void buttonAppointmentBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Appointments appointments = new Appointments();
            appointments.ShowDialog();
        }
    }
}
