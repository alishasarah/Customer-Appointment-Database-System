using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace C969AlishaCrockford
{
    public partial class LoginScreen : Form
    {
        public string connString = "server=127.0.0.1;user=sqlUser;pwd=Passw0rd!;Database=client_schedule;";
        public string error = "Your username and password did not match.";

        public void trackLogin(string logTxt)
        {
            DirectoryInfo track = new DirectoryInfo(".");
            string login = track + "\\logFile.txt";
            if (!File.Exists(login))
            {
                var fileTxt = File.Create(login);
                fileTxt.Close();
                TextWriter text = new StreamWriter(login);
                text.WriteLine(logTxt);
                text.Close();
            }
            else
            {
                using (var text = new StreamWriter(login, true))
                {
                    text.WriteLine(logTxt);
                }
            }
        }

        public LoginScreen()
        {
            InitializeComponent();
            languageCheck(CultureInfo.CurrentUICulture.LCID); //translates login screen to Spanish based on location
        }

        private void languageCheck(int LCID)
        {
            if (LCID != 1033)
            {
                labelLoginScreenWelcome.Text = "Bienvenido a Global Consultations, Inc.";
                labelLoginScreenCredentials.Text = "Por favor ingrese sus credenciales.";
                labelLoginUsername.Text = "Nombre: ";
                labelLoginPassword.Text = "Clave: ";
                buttonLoginSubmit.Text = "Enviar";
                error = "Su nombre de usuario y contrasena no coinciden.";
            }
        }
        bool isValid()
        {
            string username = textBoxLoginUsername.Text;
            string password = textBoxLoginPassword.Text;
            bool userID = false;
            var connection = new MySqlConnection();
            connection.ConnectionString = connString;
            connection.Open();
            string loginCheck = $"SELECT userId FROM user WHERE username = '{username}' AND password = '{password}'";
            var loginCMD = new MySqlCommand(loginCheck, connection);
            int loginIndex = Convert.ToInt32(loginCMD.ExecuteScalar());

            if (loginIndex != 0)
            {
                userID = true;
            }
            else
            {
                userID = false;
            }
            return userID;
        }




        private void buttonLoginSubmit_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime then = DateTime.Now.AddMinutes(15);

            if (isValid() == true)
            {
                trackLogin("Username: '" + textBoxLoginUsername.Text + " logged in successfully at " + DateTime.Now);
                if (textBoxLoginUsername.Text == "test" && textBoxLoginPassword.Text == "test")
                {
                    string userID = "1";
                    var conn = new MySqlConnection();
                    conn.ConnectionString = connString;
                    conn.Open();

                    using (DataTable dataTable = new DataTable())
                    {
                        using (MySqlCommand cmd = new MySqlCommand($"SELECT * FROM appointment WHERE start BETWEEN @fromDate AND @toDate AND userId = '{userID}'", conn))
                        {
                            cmd.Parameters.AddWithValue("@fromDate", DateTime.Now);
                            cmd.Parameters.AddWithValue("@toDate", DateTime.Now.AddMinutes(15));
                            MySqlDataAdapter weekCMD = new MySqlDataAdapter(cmd);
                            weekCMD.Fill(dataTable);
                            //dataGridViewAppt.DataSource = dataTable;
                            if (dataTable.Rows.Count > 0)
                            {
                                MessageBox.Show("You have an appointment scheduled within the next 15 minutes;");
                                this.Hide();
                                Menu main = new Menu();
                                main.ShowDialog();
                            }
                            else
                            {
                                this.Hide();
                                Menu main = new Menu();
                                main.ShowDialog();
                            }

                        }
                    }
                }

                else if (textBoxLoginUsername.Text == "test2" && textBoxLoginPassword.Text == "test2")
                {
                    string userID2 = "2";
                    var conn2 = new MySqlConnection();
                    conn2.ConnectionString = connString;
                    conn2.Open();

                    using (DataTable dataTable = new DataTable())
                    {
                        using (MySqlCommand cmd = new MySqlCommand($"SELECT * FROM appointment WHERE start BETWEEN @fromDate AND @toDate AND userId = '{userID2}'", conn2))
                        {
                            cmd.Parameters.AddWithValue("@fromDate", DateTime.Now);
                            cmd.Parameters.AddWithValue("@toDate", DateTime.Now.AddMinutes(15));
                            MySqlDataAdapter weekCMD = new MySqlDataAdapter(cmd);
                            weekCMD.Fill(dataTable);
                            //dataGridViewAppt.DataSource = dataTable;
                            if (dataTable.Rows.Count > 0)
                            {
                                MessageBox.Show("You have an appointment scheduled within the next 15 minutes;");
                                this.Hide();
                                Menu main = new Menu();
                                main.ShowDialog();
                            }
                            else
                            {
                                this.Hide();
                                Menu main = new Menu();
                                main.ShowDialog();
                            }

                        }
                    }
                }
            }
            else
            {
                trackLogin("Username: '" + textBoxLoginUsername.Text + " unsuccessfully attempted a login at " + DateTime.Now);
                MessageBox.Show(error);
                return;
            }
             
        }
    }
}

