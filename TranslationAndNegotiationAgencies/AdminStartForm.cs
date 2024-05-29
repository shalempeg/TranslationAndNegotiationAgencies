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
    public partial class AdminStartForm : Form
    {
        private string connectionString = "Data Source=DESKTOP-ULA90B9\\SQLEXPRESS;Initial Catalog=BTAN;Integrated Security=True";
        public AdminStartForm()
        {
            InitializeComponent();
        }

        private void AdminStartForm_Load(object sender, EventArgs e)
        {
            this.recordsTableAdapter.Fill(this.bTANDataSet1.records);
        }
        private void recGridAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = recGridAdmin.Rows[e.RowIndex];
                string phoneNumber = row.Cells[7].Value.ToString();
                if (!string.IsNullOrEmpty(phoneNumber))
                {
                    phoneNumber = "+7" + phoneNumber;
                }
                clientnumber.Text = phoneNumber;
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (recGridAdmin.SelectedRows.Count > 0)
            {
                int selectedRowIndex = recGridAdmin.SelectedRows[0].Index;
                int recordId = Convert.ToInt32(recGridAdmin.Rows[selectedRowIndex].Cells[0].Value);
                string query = "DELETE FROM records WHERE ID = @ID";
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@ID", recordId);
                        int rowsAffected = command.ExecuteNonQuery();
                        LoadDataIntoDataGridView();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Произошла ошибка при удалении записи из базы данных: " + ex.Message);
                    }
                }
            }
        }
        private void LoadDataIntoDataGridView()
        {
            try
            {
                bTANDataSet1.records.Clear();
                this.recordsTableAdapter.Fill(this.bTANDataSet1.records);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при загрузке данных в DataGridView: " + ex.Message);
            }
        }

        private void logoutadmin_Click(object sender, EventArgs e)
        {
            BTANauth exitadmBTAN = new BTANauth();
            exitadmBTAN.Show();
            this.Hide();
        }
    }
}

