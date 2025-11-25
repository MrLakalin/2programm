namespace ychitel
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dnevnikDataSet = new ychitel.dnevnikDataSet();
            this.иСП33BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.иСП33TableAdapter = new ychitel.dnevnikDataSetTableAdapters.ИСП33TableAdapter();
            this.фС12BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фС12TableAdapter = new ychitel.dnevnikDataSetTableAdapters.ФС12TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnevnikDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.иСП33BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фС12BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Группа";
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Location = new System.Drawing.Point(74, 5);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(220, 21);
            this.comboBoxTables.TabIndex = 4;
            this.comboBoxTables.SelectedIndexChanged += new System.EventHandler(this.comboBoxTables_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(803, 419);
            this.dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dnevnikDataSet
            // 
            this.dnevnikDataSet.DataSetName = "dnevnikDataSet";
            this.dnevnikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // иСП33BindingSource
            // 
            this.иСП33BindingSource.DataMember = "ИСП33";
            this.иСП33BindingSource.DataSource = this.dnevnikDataSet;
            // 
            // иСП33TableAdapter
            // 
            this.иСП33TableAdapter.ClearBeforeFill = true;
            // 
            // фС12BindingSource
            // 
            this.фС12BindingSource.DataMember = "ФС12";
            this.фС12BindingSource.DataSource = this.dnevnikDataSet;
            // 
            // фС12TableAdapter
            // 
            this.фС12TableAdapter.ClearBeforeFill = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTables);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnevnikDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.иСП33BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фС12BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTables;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private dnevnikDataSet dnevnikDataSet;
        private System.Windows.Forms.BindingSource иСП33BindingSource;
        private dnevnikDataSetTableAdapters.ИСП33TableAdapter иСП33TableAdapter;
        private System.Windows.Forms.BindingSource фС12BindingSource;
        private dnevnikDataSetTableAdapters.ФС12TableAdapter фС12TableAdapter;
    }
}