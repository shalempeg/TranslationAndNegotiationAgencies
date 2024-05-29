using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TranslationAndNegotiationAgencies
{
    public partial class record : Form
    {
        private string printedText = "";
        private PrintDocument pd = new PrintDocument();
        private string connectionString = "Data Source=DESKTOP-ULA90B9\\SQLEXPRESS;Initial Catalog=BTAN;Integrated Security=True";
        public record()
        {
            pd.PrintPage += new PrintPageEventHandler(PrintPage);
            InitializeComponent();
        }
        private void record_Load(object sender, EventArgs e)
        {
            this.translateTableAdapter.Fill(this.bTANDataSet.translate);

        }
        private void recGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = recGrid.Rows[e.RowIndex];
                textSurname.Text = row.Cells[1].Value.ToString();
                textName.Text = row.Cells[2].Value.ToString();
                textOtch.Text = row.Cells[3].Value.ToString();
                textVid.Text = row.Cells[4].Value.ToString();
                textLanguage.Text = row.Cells[5].Value.ToString();
                textLevel.Text = row.Cells[6].Value.ToString();
                recordbutton.Enabled = true;
            }
        }
        private void recordbutton_Click(object sender, EventArgs e)
        {
            string surnameText = textSurname.Text;
            string nameText = textName.Text;
            string otchText = textOtch.Text;
            string typeText = textVid.Text;
            string languageText = textLanguage.Text;
            string levelText = textLevel.Text;
            string phoneText = numberphone.Text;
            if (string.IsNullOrWhiteSpace(phoneText))
            {
                MessageBox.Show("Для записи обязательно вести Ваш номер телефона");
                return;
            }
            phoneText = phoneText.Replace(" ", "").Replace("-", "");
            if (phoneText.StartsWith("+7") || phoneText.StartsWith("8"))
            {
                if (phoneText.StartsWith("+7"))
                    phoneText = phoneText.Substring(2);
                else
                    phoneText = phoneText.Substring(1);
                if (!phoneText.All(char.IsDigit) ||
                    (phoneText.StartsWith("+") && phoneText.Length != 11) ||
                    (!phoneText.StartsWith("+") && phoneText.Length != 10))
                {
                    MessageBox.Show("Введен некорректный номер");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Введен некорректный номер");
                return;
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO records (Фамилия, Имя, Отчество, Вид, Язык, Уровень, Телефон_клиента) VALUES (@Фамилия, @Имя, @Отчество, @Вид, @Язык, @Уровень, @Телефон_клиента)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Фамилия", surnameText);
                    command.Parameters.AddWithValue("@Имя", nameText);
                    command.Parameters.AddWithValue("@Отчество", otchText);
                    command.Parameters.AddWithValue("@Вид", typeText);
                    command.Parameters.AddWithValue("@Язык", languageText);
                    command.Parameters.AddWithValue("@Уровень", levelText);
                    command.Parameters.AddWithValue("@Телефон_клиента", phoneText);
                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            printedText = $"Бюро переводов и ведения переговоров\n\n\nВы записаны на прием по услуге {typeText} \nФамилия: {surnameText} \nИмя: {nameText}\nОтчество: {otchText}\nЯзык: {languageText}\nУровень: {levelText}";
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = pd;
            printPreviewDialog.ShowDialog();
        }
        private void PrintPage(object sender, PrintPageEventArgs e)
        {

            Font printFont = new Font("Segoe UI", 12);
            SolidBrush brush = new SolidBrush(Color.Black);
            float x = 100;
            float y = 100;
            e.Graphics.DrawString(printedText, printFont, brush, x, y);
        }
        private void backfromrec_Click(object sender, EventArgs e)
        {
            UserStartForm startuserBTAN = new UserStartForm();
            startuserBTAN.Show();
            this.Hide();
        }
    }
}
