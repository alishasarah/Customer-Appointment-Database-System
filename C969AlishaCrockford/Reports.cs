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
    public partial class Reports : Form
    {
        public string connString = "server=127.0.0.1;user=sqlUser;pwd=Passw0rd!;Database=client_schedule;";
        public Reports()
        {
            InitializeComponent();
        }

        private void buttonReportsBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void buttonReportsLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been logged out.");
            this.Hide();
            LoginScreen login = new LoginScreen();
            login.ShowDialog();
        }

        private void btnVirtual_CheckedChanged(object sender, EventArgs e)
        {
            btnOctober.Visible = true;
            btnNovember.Visible = true;
            btnDecember.Visible = true;

            if (btnOctober.Checked == true)
            {
                btnVirtual.Checked = true;
                var conn = new MySqlConnection();
                conn.ConnectionString = connString;
                conn.Open();
                using (DataTable dataTable = new DataTable())
                {
                    using (MySqlCommand cmd = new MySqlCommand($"SELECT appointmentId, appointment.customerId, appointment.userId, type, start, end FROM appointment" +
                    " INNER JOIN customer AS customer ON appointment.customerId = customer.customerId" +
                    " INNER JOIN user AS user ON appointment.userId = user.userId" +
                        " WHERE type = 'Virtual ' AND start BETWEEN @fromDate AND @toDate", conn))
                    {
                        cmd.Parameters.AddWithValue("@fromDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@toDate", DateTime.Parse("2022-10-31 23:59:59"));
                        MySqlDataAdapter weekCMD = new MySqlDataAdapter(cmd);
                        weekCMD.Fill(dataTable);
                    }
                    if (dataTable.Rows.Count == 1)
                    {
                        textBoxResult.Text = "There is " + dataTable.Rows.Count + " virtual appointment in October.";
                    }
                    else if (dataTable.Rows.Count > 1)
                    {
                        textBoxResult.Text = "There are " + dataTable.Rows.Count + " virtual appointments in October.";
                    }
                    else
                    {
                        textBoxResult.Text = "There are no virtual appointments in October.";
                    }
                }
            }
                if (btnNovember.Checked == true)
                {
                    btnVirtual.Checked = true;
                    var conn1 = new MySqlConnection();
                    conn1.ConnectionString = connString;
                    conn1.Open();
                    using (DataTable dataTable1 = new DataTable())
                    {
                        using (MySqlCommand cmd = new MySqlCommand($"SELECT appointmentId, appointment.customerId, appointment.userId, type, start, end FROM appointment" +
                        " INNER JOIN customer AS customer ON appointment.customerId = customer.customerId" +
                        " INNER JOIN user AS user ON appointment.userId = user.userId" +
                            " WHERE type = 'Virtual ' AND start BETWEEN @fromDate AND @toDate", conn1))
                        {
                            cmd.Parameters.AddWithValue("@fromDate", DateTime.Parse("2022-11-01 00:00:00"));
                            cmd.Parameters.AddWithValue("@toDate", DateTime.Parse("2022-11-30 23:59:59"));
                            MySqlDataAdapter weekCMD = new MySqlDataAdapter(cmd);
                            weekCMD.Fill(dataTable1);
                        }
                        if (dataTable1.Rows.Count == 1)
                        {
                            textBoxResult.Text = "There is " + dataTable1.Rows.Count + " virtual appointment in November.";
                        }
                        else if (dataTable1.Rows.Count > 1)
                        {
                            textBoxResult.Text = "There are " + dataTable1.Rows.Count + " virtual appointments in November.";
                        }
                        else
                        {
                            textBoxResult.Text = "There are no virtual appointments in November.";
                        }
                    }
                
                }
            if (btnDecember.Checked == true)
            {
                btnVirtual.Checked = true;
                var conn2 = new MySqlConnection();
                conn2.ConnectionString = connString;
                conn2.Open();
                using (DataTable dataTable2 = new DataTable())
                {
                    using (MySqlCommand cmd = new MySqlCommand($"SELECT appointmentId, appointment.customerId, appointment.userId, type, start, end FROM appointment" +
                    " INNER JOIN customer AS customer ON appointment.customerId = customer.customerId" +
                    " INNER JOIN user AS user ON appointment.userId = user.userId" +
                        " WHERE type = 'Virtual ' AND start BETWEEN @fromDate AND @toDate", conn2))
                    {
                        cmd.Parameters.AddWithValue("@fromDate", DateTime.Parse("2022-12-01 00:00:00"));
                        cmd.Parameters.AddWithValue("@toDate", DateTime.Parse("2022-12-31 23:59:59"));
                        MySqlDataAdapter weekCMD = new MySqlDataAdapter(cmd);
                        weekCMD.Fill(dataTable2);
                    }
                    if (dataTable2.Rows.Count == 1)
                    {
                        textBoxResult.Text = "There is " + dataTable2.Rows.Count + " virtual appointment in December.";
                    }
                    else if (dataTable2.Rows.Count > 1)
                    {
                        textBoxResult.Text = "There are " + dataTable2.Rows.Count + " virtual appointments in December.";
                    }
                    else
                    {
                        textBoxResult.Text = "There are no virtual appointments in December.";
                    }
                }

            }
        }

        private void btnInPerson_CheckedChanged(object sender, EventArgs e)
        {
            btnOctober.Visible = true;
            btnNovember.Visible = true;
            btnDecember.Visible = true;

            if (btnOctober.Checked == true)
            {
                btnInPerson.Checked = true;
                var conn = new MySqlConnection();
                conn.ConnectionString = connString;
                conn.Open();
                using (DataTable dataTable = new DataTable())
                {
                    using (MySqlCommand cmd = new MySqlCommand($"SELECT appointmentId, appointment.customerId, appointment.userId, type, start, end FROM appointment" +
                    " INNER JOIN customer AS customer ON appointment.customerId = customer.customerId" +
                    " INNER JOIN user AS user ON appointment.userId = user.userId" +
                        " WHERE type = 'In-Person ' AND start BETWEEN @fromDate AND @toDate", conn))
                    {
                        cmd.Parameters.AddWithValue("@fromDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@toDate", DateTime.Parse("2022-10-31 23:59:59"));
                        MySqlDataAdapter weekCMD = new MySqlDataAdapter(cmd);
                        weekCMD.Fill(dataTable);
                    }
                    if (dataTable.Rows.Count == 1)
                    {
                        textBoxResult.Text = "There is " + dataTable.Rows.Count + " in-person appointment in October.";
                    }
                    else if (dataTable.Rows.Count > 1)
                    {
                        textBoxResult.Text = "There are " + dataTable.Rows.Count + " in-person appointments in October.";
                    }
                    else
                    {
                        textBoxResult.Text = "There are no in-person appointments in October.";
                    }
                }
            }
            if (btnNovember.Checked == true)
            {
                btnInPerson.Checked = true;
                var conn1 = new MySqlConnection();
                conn1.ConnectionString = connString;
                conn1.Open();
                using (DataTable dataTable1 = new DataTable())
                {
                    using (MySqlCommand cmd = new MySqlCommand($"SELECT appointmentId, appointment.customerId, appointment.userId, type, start, end FROM appointment" +
                    " INNER JOIN customer AS customer ON appointment.customerId = customer.customerId" +
                    " INNER JOIN user AS user ON appointment.userId = user.userId" +
                        " WHERE type = 'In-Person ' AND start BETWEEN @fromDate AND @toDate", conn1))
                    {
                        cmd.Parameters.AddWithValue("@fromDate", DateTime.Parse("2022-11-01 00:00:00"));
                        cmd.Parameters.AddWithValue("@toDate", DateTime.Parse("2022-11-30 23:59:59"));
                        MySqlDataAdapter weekCMD = new MySqlDataAdapter(cmd);
                        weekCMD.Fill(dataTable1);
                    }
                    if (dataTable1.Rows.Count == 1)
                    {
                        textBoxResult.Text = "There is " + dataTable1.Rows.Count + " in-person appointment in November.";
                    }
                    else if (dataTable1.Rows.Count > 1)
                    {
                        textBoxResult.Text = "There are " + dataTable1.Rows.Count + " in-person appointments in November.";
                    }
                    else
                    {
                        textBoxResult.Text = "There are no in-person appointments in November.";
                    }
                }

            }
            if (btnDecember.Checked == true)
            {
                btnInPerson.Checked = true;
                var conn2 = new MySqlConnection();
                conn2.ConnectionString = connString;
                conn2.Open();
                using (DataTable dataTable2 = new DataTable())
                {
                    using (MySqlCommand cmd = new MySqlCommand($"SELECT appointmentId, appointment.customerId, appointment.userId, type, start, end FROM appointment" +
                    " INNER JOIN customer AS customer ON appointment.customerId = customer.customerId" +
                    " INNER JOIN user AS user ON appointment.userId = user.userId" +
                        " WHERE type = 'In-Person ' AND start BETWEEN @fromDate AND @toDate", conn2))
                    {
                        cmd.Parameters.AddWithValue("@fromDate", DateTime.Parse("2022-12-01 00:00:00"));
                        cmd.Parameters.AddWithValue("@toDate", DateTime.Parse("2022-12-31 23:59:59"));
                        MySqlDataAdapter weekCMD = new MySqlDataAdapter(cmd);
                        weekCMD.Fill(dataTable2);
                    }
                    if (dataTable2.Rows.Count == 1)
                    {
                        textBoxResult.Text = "There is " + dataTable2.Rows.Count + " in-person appointment in December.";
                    }
                    else if (dataTable2.Rows.Count > 1)
                    {
                        textBoxResult.Text = "There are " + dataTable2.Rows.Count + " in-person appointments in December.";
                    }
                    else
                    {
                        textBoxResult.Text = "There are no in-person appointments in December.";
                    }
                }

            }
        }

        private void btnUser1_CheckedChanged(object sender, EventArgs e)
        {
            var conn = new MySqlConnection();
            conn.ConnectionString = connString;
            conn.Open();
            using (DataTable dataTable = new DataTable())
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT appointmentId, appointment.customerId, appointment.userId, type, start, end FROM appointment" +
                " INNER JOIN customer AS customer ON appointment.customerId = customer.customerId" +
                " INNER JOIN user AS user ON appointment.userId = user.userId" +
                    " WHERE appointment.userId = '1'", conn))
                {
                    MySqlDataAdapter weekCMD = new MySqlDataAdapter(cmd);
                    weekCMD.Fill(dataTable);
                    dataGridViewAppt.DataSource = dataTable;
                }
            }
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

        private void btnUser2_CheckedChanged(object sender, EventArgs e)
        {
            var conn = new MySqlConnection();
            conn.ConnectionString = connString;
            conn.Open();
            using (DataTable dataTable = new DataTable())
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT appointmentId, appointment.customerId, appointment.userId, type, start, end FROM appointment" +
                " INNER JOIN customer AS customer ON appointment.customerId = customer.customerId" +
                " INNER JOIN user AS user ON appointment.userId = user.userId" +
                    " WHERE appointment.userId = '2'", conn))
                {
                    MySqlDataAdapter weekCMD = new MySqlDataAdapter(cmd);
                    weekCMD.Fill(dataTable);
                    dataGridViewAppt.DataSource = dataTable;
                }
            }
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

        private void btnTotalNumber_CheckedChanged(object sender, EventArgs e)
        {
            var conn = new MySqlConnection();
            conn.ConnectionString = connString;
            conn.Open();
            using (DataTable dataTable = new DataTable())
            {
                using (MySqlCommand cmd = new MySqlCommand($"SELECT appointmentId, appointment.customerId, appointment.userId, type, start, end FROM appointment" +
                " INNER JOIN customer AS customer ON appointment.customerId = customer.customerId" +
                " INNER JOIN user AS user ON appointment.userId = user.userId" +
                " WHERE start BETWEEN @fromDate AND @toDate", conn))
                {
                    cmd.Parameters.AddWithValue("@fromDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@toDate", DateTime.Parse("2050-12-31 23:59:59"));
                    MySqlDataAdapter weekCMD = new MySqlDataAdapter(cmd);
                    weekCMD.Fill(dataTable);
                }
                if (dataTable.Rows.Count == 1)
                {
                    textBoxResult.Text = "There is " + dataTable.Rows.Count + " future appointment.";
                }
                else if (dataTable.Rows.Count > 1)
                {
                    textBoxResult.Text = "There are " + dataTable.Rows.Count + " total future appointments.";
                }
                else
                {
                    textBoxResult.Text = "There are no scheduled future appointments at this time.";
                }
            }
        }
    }
}
