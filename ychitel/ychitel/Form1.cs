using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ychitel
{
    public partial class Form1 : Form
    {
        private const string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\MrLak\\OneDrive\\Рабочий стол\\МДК\\praktika2\\praktika\\bin\\x64\\Debug\\admin.accdb;";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loginuser = textBox1.Text;
            string password = textBox2.Text;

            DataTable table = new DataTable();

            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                string query = "SELECT * FROM [Учителя] WHERE [Логин] = @ul AND [Пароль] = @up";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ul", loginuser);
                    command.Parameters.AddWithValue("@up", password);

                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    adapter.Fill(table);
                }
            }

            if (table.Rows.Count > 0)
            {
                Main userForm = new Main();
                userForm.Owner = this;
                userForm.Show();
                this.Hide();

                MessageBox.Show("Добро Пожаловать.");
            }
            else
            {
                MessageBox.Show("Ошибка при вводе данных аккаунта.");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
