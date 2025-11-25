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

namespace praktika
{
    public partial class Form1 : Form
    {
            private const string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=admin.accdb;";
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
                string query = "SELECT * FROM [Ученики] WHERE [Логин] = @ul AND [Пароль] = @up";
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
                Reg userForm = new Reg();
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
    }
}
