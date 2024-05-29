using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TranslationAndNegotiationAgencies
{
    public partial class BTANauth : Form
    {
        public BTANauth()
        {
            InitializeComponent();
            Password.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-ULA90B9\\SQLEXPRESS;Initial Catalog=BTAN;Integrated Security=True"; // Замени на строку подключения к твоей БД

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Проверка в таблице Users
                    string userQuery = "SELECT COUNT(1) FROM Users WHERE Username=@username AND Password=@password";
                    SqlCommand userCommand = new SqlCommand(userQuery, connection);
                    userCommand.Parameters.AddWithValue("@username", Username.Text);
                    userCommand.Parameters.AddWithValue("@password", Password.Text);
                    int userResult = (int)userCommand.ExecuteScalar();

                    if (userResult == 1)
                    {

                        //MessageBox.Show("User login successful!");
                        UserStartForm userForm = new UserStartForm();
                        userForm.Show();
                        this.Hide();
                        return;
                    }
                    string adminQuery = "SELECT COUNT(1) FROM Admin WHERE Username=@username AND Password=@password";
                    SqlCommand adminCommand = new SqlCommand(adminQuery, connection);
                    adminCommand.Parameters.AddWithValue("@username", Username.Text);
                    adminCommand.Parameters.AddWithValue("@password", Password.Text);
                    int adminResult = (int)adminCommand.ExecuteScalar();

                    if (adminResult == 1)
                    {
                        //MessageBox.Show("Admin login successful!");
                        AdminStartForm adminForm = new AdminStartForm();
                        adminForm.Show();
                        this.Hide();
                        return;
                    }

                    else
                    {
                        MessageBox.Show("Неверный логин или пароль.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void checkpass_Click(object sender, EventArgs e)
        {
            if (checkpass.Checked)
            {
                Password.PasswordChar = '\0';
            }
            else
            {
                Password.PasswordChar = '*';
            }
        }

        private void reg_Click(object sender, EventArgs e)
        {
            BTANreg userreg = new BTANreg();
            userreg.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}