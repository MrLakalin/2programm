using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ychitel.dnevnikDataSetTableAdapters;

namespace ychitel
{
    public partial class Main : Form
    {
        // Текущая активная таблица
        private string _currentTable = null;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Загружаем данные через TableAdapter'ы
            this.иСП33TableAdapter.Fill(this.dnevnikDataSet.ИСП33);
            this.фС12TableAdapter.Fill(this.dnevnikDataSet.ФС12);

            // Настраиваем ComboBox
            comboBoxTables.Items.Clear();
            comboBoxTables.Items.Add("ИСП33");
            comboBoxTables.Items.Add("ФС12");
            comboBoxTables.SelectedIndex = 0; // по умолчанию — первая таблица
        }

        private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Сохраняем изменения в текущей таблице перед переключением
            SaveCurrentTable();

            string selectedTable = comboBoxTables.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedTable)) return;

            // Привязываем DataGridView к нужному BindingSource
            if (selectedTable == "ИСП33")
            {
                dataGridView1.DataSource = this.иСП33BindingSource;
            }
            else if (selectedTable == "ФС12")
            {
                dataGridView1.DataSource = this.фС12BindingSource;
            }

            _currentTable = selectedTable;
        }

        /// <summary>
        /// Сохраняет изменения в текущей таблице
        /// </summary>
        private void SaveCurrentTable()
        {
            if (_currentTable == "ИСП33")
            {
                this.иСП33BindingSource.EndEdit();
                this.иСП33TableAdapter.Update(this.dnevnikDataSet.ИСП33);
            }
            else if (_currentTable == "ФС12")
            {
                this.фС12BindingSource.EndEdit();
                this.фС12TableAdapter.Update(this.dnevnikDataSet.ФС12);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Явное сохранение по кнопке
            SaveCurrentTable();
            MessageBox.Show("Данные успешно сохранены в базу Access!", "Сохранение",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}