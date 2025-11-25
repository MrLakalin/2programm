using praktika.adminDataSetTableAdapters;
using praktika.dnevnikDataSetTableAdapters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktika
{
    public partial class Reg : Form
    {
        private readonly Dictionary<string, DataTable> _tables = new Dictionary<string, DataTable>();
        private readonly string _connString =
            "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=dnevnik.accdb;";

        public Reg()
        {
            InitializeComponent();
        }

        private void Reg_Load(object sender, EventArgs e)
        {
            LoadTable("ФС12");
            LoadTable("ИСП33");

            comboBoxTables.DataSource = _tables.Keys.ToList();
            comboBoxTables.SelectedIndex = 0;   // сразу показываем первую таблицу
            dataGridView1.DataSource = _tables[comboBoxTables.SelectedItem.ToString()];            
        }
        private void LoadTable(string tableName)
        {
            using (var conn = new OleDbConnection(_connString))
            using (var adapter = new OleDbDataAdapter($"SELECT * FROM [{tableName}]", conn))
            {
                var dt = new DataTable(tableName);
                adapter.Fill(dt);
                _tables[tableName] = dt;
            }
        }

        private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = comboBoxTables.SelectedItem?.ToString();
            if (selected == null) return;

            dataGridView1.DataSource = _tables[selected];
        }
    }
}
