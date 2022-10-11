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
    public partial class Appointments : Form
    {
        public string connString = "server=127.0.0.1;user=sqlUser;pwd=Passw0rd!;Database=client_schedule;";
        public Appointments()
        {
            InitializeComponent();
            string connString = "server=127.0.0.1;user=sqlUser;pwd=Passw0rd!;Database=client_schedule;";
            string Query = ("SELECT appointmentId, appointment.customerId, appointment.userId, type, start, end FROM appointment" + 
                " INNER JOIN customer AS customer ON appointment.customerId = customer.customerId" +
                " INNER JOIN user AS user ON appointment.userId = user.userId");
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand cmd = new MySqlCommand(Query, conn);
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dbTable = new DataTable();
            sda.Fill(dbTable);
            BindingSource dbSource = new BindingSource();
            dbSource.DataSource = dbTable;
            dataGridViewAppt.DataSource = dbSource;
            sda.Update(dbTable);

            dataGridViewAppt.Columns["appointmentId"].HeaderText = "Appointment ID";
            dataGridViewAppt.Columns["customerId"].HeaderText = "Customer ID";
            dataGridViewAppt.Columns["userId"].HeaderText = "User ID";
            dataGridViewAppt.Columns["type"].HeaderText = "Type";
            dataGridViewAppt.Columns["start"].HeaderText = "Start";
            dataGridViewAppt.Columns["end"].HeaderText = "End";
            dataGridViewAppt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAppt.RowHeadersVisible = false;
            dataGridViewAppt.AllowUserToAddRows = false;
            dataGridViewAppt.ReadOnly = true;
        }

        public void updateAppt()
        {
            var conn = new MySqlConnection();
            conn.ConnectionString = connString;
            conn.Open();

            string selectAppt = "SELECT * FROM appointment";
            var selectApptCMD = new MySqlCommand(selectAppt, conn);
            var selectApptAdapter = new MySqlDataAdapter(selectApptCMD);
            DataTable dbTable = new DataTable();
            selectApptAdapter.Fill(dbTable);
            for (int i = 0; i < dbTable.Rows.Count; i++)
            {
                var currentStart = dbTable.Rows[i]["start"];
                var currentEnd = dbTable.Rows[i]["end"];
                DateTime a = (DateTime)currentStart;
                DateTime b = (DateTime)currentEnd;
                dbTable.Rows[i]["start"] = a.ToLocalTime();
                dbTable.Rows[i]["end"] = b.ToLocalTime();
            }
            dataGridViewAppt.DataSource = dbTable;
            dataGridViewAppt.ClearSelection();

        }

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
            Menu menu = new Menu();
            menu.ShowDialog();
        }

		private void buttonAppointmentAdd_Click(object sender, EventArgs e)
		{
            this.Hide();
            AddAppointment addAppointment = new AddAppointment();
            addAppointment.ShowDialog();
		}

		private void buttonAppointmentModify_Click(object sender, EventArgs e)
		{
            textAddApptCustomer.Text = dataGridViewAppt.SelectedRows[0].Cells[1].Value.ToString();
            textAddApptUser.Text = dataGridViewAppt.SelectedRows[0].Cells[2].Value.ToString();
            dateTimeStart.Value = DateTime.Parse(dataGridViewAppt.SelectedRows[0].Cells[4].Value.ToString());
            dateTimeEnd.Value = DateTime.Parse(dataGridViewAppt.SelectedRows[0].Cells[5].Value.ToString());
            string apptType = Convert.ToString(dataGridViewAppt.SelectedRows[0].Cells[3].Value);
            if (apptType == "Virtual ")
            {
                btnVirtual.Checked = true;
            }
            else
            {
                btnInPerson.Checked = true;
            }
            textAddApptCustomer.ReadOnly = false;
            textAddApptCustomer.Enabled = true;
            textAddApptUser.ReadOnly = false;
            textAddApptUser.Enabled = true;
            btnVirtual.Enabled = true;
            btnInPerson.Enabled = true;
            dateTimeStart.Enabled = true;
            dateTimeEnd.Enabled = true;

        }

        private void buttonAppointmentDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewAppt.SelectedRows)
            {
                string message = "Would you like to delete this appointment?";
                string caption = "";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.Yes)
                {
                    var conn = new MySqlConnection();
                    conn.ConnectionString = connString;
                    conn.Open();
                    int apptId = (int)dataGridViewAppt.SelectedRows[0].Cells[0].Value;
                    string deleteAppt = $"DELETE FROM appointment WHERE appointmentId={apptId}";
                    var delete = new MySqlCommand(deleteAppt, conn);
                    delete.Prepare();
                    delete.ExecuteNonQuery();
                    dataGridViewAppt.Rows.RemoveAt(row.Index);
                    MessageBox.Show("The selected appointment has been deleted.");
                    dataGridViewAppt.CurrentCell.Selected = false;
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
            string appointmentID = dataGridViewAppt.SelectedRows[0].Cells[0].Value.ToString();
            string customerID = textAddApptCustomer.Text;
            string userID = textAddApptUser.Text;
            string _virtual = btnVirtual.Text;
            string inPerson = btnInPerson.Text;
            string start = dateTimeStart.Text;
            string end = dateTimeEnd.Text;
            Convert.ToDateTime(start);
            Convert.ToDateTime(end);

            var conn = new MySqlConnection();
            conn.ConnectionString = connString;
            conn.Open();

            bool noOverlap()
            {
                bool overlap = false;
                var connection = new MySqlConnection();
                connection.ConnectionString = connString;
                connection.Open();
                string apptOverlap = $"SELECT * FROM appointment WHERE start between '{start}' AND '{end}' AND userId = '{userID}' OR end between '{start}' AND '{end}' AND userId = '{userID}'";
                var overlapCMD = new MySqlCommand(apptOverlap, connection);
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
                || dateTimeStart.Value.ToLocalTime().Hour > 18
                || dateTimeEnd.Value.ToLocalTime().Hour < 8
                || dateTimeEnd.Value.ToLocalTime().Hour > 18)
            {
                MessageBox.Show("Please enter a valid appointment between our business hours of 8am and 6pm.");
                return;
            }
            else if (noOverlap() == false)
            {
                MessageBox.Show("There is a scheduling conflict with existing appointments for this user.");
                return;
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
                if (btnVirtual.Checked == true)
                {
                    string updateAppt = $"UPDATE appointment SET customerId = '{customerID}', userId = '{userID}', type = '{_virtual}', start = '{start}', end = '{end}' WHERE appointmentId = {appointmentID}";
                    var updateApptCMD = new MySqlCommand(updateAppt, conn);
                    updateApptCMD.Prepare();
                    updateApptCMD.ExecuteNonQuery();
                }
                else
                {
                    string updateAppt = $"UPDATE appointment SET customerId = '{customerID}', userId = '{userID}', type = '{inPerson}', start = '{start}', end = '{end}' WHERE appointmentId = {appointmentID}";
                    var updateApptCMD = new MySqlCommand(updateAppt, conn);
                    updateApptCMD.Prepare();
                    updateApptCMD.ExecuteNonQuery();
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
        }

        private void radioButtonApptWeek_CheckedChanged(object sender, EventArgs e)
        {
            var conn = new MySqlConnection();
            conn.ConnectionString = connString;
            conn.Open();
            using (DataTable dataTable = new DataTable())
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT appointmentId, appointment.customerId, appointment.userId, type, start, end FROM appointment" +
                " INNER JOIN customer AS customer ON appointment.customerId = customer.customerId" +
                " INNER JOIN user AS user ON appointment.userId = user.userId" +
                    " WHERE start BETWEEN @fromDate AND @toDate", conn))
                {
                    cmd.Parameters.AddWithValue("@fromDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@toDate", DateTime.Now.AddDays(7));
                    MySqlDataAdapter weekCMD = new MySqlDataAdapter(cmd);
                    weekCMD.Fill(dataTable);
                    dataGridViewAppt.DataSource = dataTable;
                }
            }
        }

        private void radioButtonApptMonth_CheckedChanged(object sender, EventArgs e)
        {
            var conn = new MySqlConnection();
            conn.ConnectionString = connString;
            conn.Open();
            using (DataTable dataTable = new DataTable())
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT appointmentId, appointment.customerId, appointment.userId, type, start, end FROM appointment" +
                " INNER JOIN customer AS customer ON appointment.customerId = customer.customerId" +
                " INNER JOIN user AS user ON appointment.userId = user.userId" +
                    " WHERE start BETWEEN @fromDate AND @toDate", conn))
                {
                    cmd.Parameters.AddWithValue("@fromDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@toDate", DateTime.Now.AddDays(30));
                    MySqlDataAdapter weekCMD = new MySqlDataAdapter(cmd);
                    weekCMD.Fill(dataTable);
                    dataGridViewAppt.DataSource = dataTable;
                }
            }
        }

        private void radioButtonApptAll_CheckedChanged(object sender, EventArgs e)
        {
            string connString = "server=127.0.0.1;user=sqlUser;pwd=Passw0rd!;Database=client_schedule;";
            string Query = ("SELECT appointmentId, appointment.customerId, appointment.userId, type, start, end FROM appointment" +
                " INNER JOIN customer AS customer ON appointment.customerId = customer.customerId" +
                " INNER JOIN user AS user ON appointment.userId = user.userId");
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand cmd = new MySqlCommand(Query, conn);
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmd;
            DataTable dbTable = new DataTable();
            sda.Fill(dbTable);
            BindingSource dbSource = new BindingSource();
            dbSource.DataSource = dbTable;
            dataGridViewAppt.DataSource = dbSource;
            sda.Update(dbTable);
        }

    }
}
