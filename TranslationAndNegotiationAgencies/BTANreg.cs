using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranslationAndNegotiationAgencies
{
    public partial class BTANreg : Form
    {
        // Строка подключения к БД
        private string connectionString = "Data Source=DESKTOP-ULA90B9\\SQLEXPRESS;Initial Catalog=BTAN;Integrated Security=True";

        public BTANreg()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка валидности ввода
                if (!ValidateInput())
                {
                    return;
                }

                // Получение данных из текстовых полей
                string username = regusername.Text;
                string password = regpassword.Text;

                // Подключение к БД
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Проверка наличия пользователя с таким же логином
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@Username", username);
                        int count = (int)checkCommand.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Пользователь с таким логином уже существует.");
                            return;
                        }
                    }

                    // Запрос на добавление пользователя в БД
                    string insertQuery = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@Username", username);
                        insertCommand.Parameters.AddWithValue("@Password", password);
                        insertCommand.ExecuteNonQuery();
                    }
                }

                // Успешная регистрация
                MessageBox.Show("Регистрация прошла успешно!");
                ClearInputFields();
                BTANauth backBTAN = new BTANauth();
                backBTAN.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                // Обработка исключений
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка");
            }
        }

        // Валидация ввода
        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(regusername.Text))
            {
                MessageBox.Show("Пожалуйста, введите логин.");
                regusername.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(regpassword.Text))
            {
                MessageBox.Show("Пожалуйста, введите пароль.");
                regpassword.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(regconfirmpass.Text))
            {
                MessageBox.Show("Пожалуйста, подтвердите пароль.");
                regconfirmpass.Focus();
                return false;
            }

            if (regpassword.Text != regconfirmpass.Text)
            {
                MessageBox.Show("Пароли не совпадают.");
                regpassword.Focus();
                return false;
            }

            // Проверка на валидный ввод в текстовых полях
            if (!IsEnglish(regusername.Text) || !IsEnglish(regpassword.Text) || !IsEnglish(regconfirmpass.Text))
            {
                MessageBox.Show("Допускается только латиница, а также использование цифр и символов.");
                return false;
            }

            return true;
        }

        // Проверка на английский язык и символы
        private bool IsEnglish(string text)
        {
            foreach (char c in text)
            {
                if (!((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9') || (c == ' ')))
                {
                    return false;
                }
            }
            return true;
        }

        // Очистка полей ввода
        private void ClearInputFields()
        {
            regusername.Text = "";
            regpassword.Text = "";
            regconfirmpass.Text = "";
        }

        private void regbackbutton_Click(object sender, EventArgs e)
        {
            BTANauth backBTAN = new BTANauth();
            backBTAN.Show();
            this.Hide();
        }
    }
}
