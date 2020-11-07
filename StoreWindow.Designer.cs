namespace _2009_1956_DoorAndWindow
{
    partial class StoreWindow
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.movedbDataSet = new _2009_1956_DoorAndWindow.movedbDataSet();
            this.оконныйБлокBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.оконный_блокTableAdapter = new _2009_1956_DoorAndWindow.movedbDataSetTableAdapters.оконный_блокTableAdapter();
            this.пользователиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пользователиTableAdapter = new _2009_1956_DoorAndWindow.movedbDataSetTableAdapters.пользователиTableAdapter();
            this.изготовлениеОконныхБлоковBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.изготовление_оконных_блоковTableAdapter = new _2009_1956_DoorAndWindow.movedbDataSetTableAdapters.изготовление_оконных_блоковTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оконныйБлокDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаИзготовленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кемИзготовленоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movedbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оконныйБлокBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.изготовлениеОконныхБлоковBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оконный блок";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.оконныйБлокBindingSource;
            this.comboBox1.DisplayMember = "Название";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Код";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата изготовления";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.оконныйБлокDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.датаИзготовленияDataGridViewTextBoxColumn,
            this.кемИзготовленоDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2});
            this.dataGridView1.DataSource = this.изготовлениеОконныхБлоковBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(149, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(609, 340);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Типы окон";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 316);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 34);
            this.button5.TabIndex = 11;
            this.button5.Text = "Оконный справочник";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.пользователиBindingSource;
            this.comboBox2.DisplayMember = "ФИО";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(13, 174);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.ValueMember = "Код";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Кто сделал";
            // 
            // movedbDataSet
            // 
            this.movedbDataSet.DataSetName = "movedbDataSet";
            this.movedbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // оконныйБлокBindingSource
            // 
            this.оконныйБлокBindingSource.DataMember = "оконный блок";
            this.оконныйБлокBindingSource.DataSource = this.movedbDataSet;
            // 
            // оконный_блокTableAdapter
            // 
            this.оконный_блокTableAdapter.ClearBeforeFill = true;
            // 
            // пользователиBindingSource
            // 
            this.пользователиBindingSource.DataMember = "пользователи";
            this.пользователиBindingSource.DataSource = this.movedbDataSet;
            // 
            // пользователиTableAdapter
            // 
            this.пользователиTableAdapter.ClearBeforeFill = true;
            // 
            // изготовлениеОконныхБлоковBindingSource
            // 
            this.изготовлениеОконныхБлоковBindingSource.DataMember = "изготовление оконных блоков";
            this.изготовлениеОконныхБлоковBindingSource.DataSource = this.movedbDataSet;
            // 
            // изготовление_оконных_блоковTableAdapter
            // 
            this.изготовление_оконных_блоковTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодDataGridViewTextBoxColumn.Width = 51;
            // 
            // оконныйБлокDataGridViewTextBoxColumn
            // 
            this.оконныйБлокDataGridViewTextBoxColumn.DataPropertyName = "Оконный блок";
            this.оконныйБлокDataGridViewTextBoxColumn.HeaderText = "Оконный блок";
            this.оконныйБлокDataGridViewTextBoxColumn.Name = "оконныйБлокDataGridViewTextBoxColumn";
            this.оконныйБлокDataGridViewTextBoxColumn.ReadOnly = true;
            this.оконныйБлокDataGridViewTextBoxColumn.Visible = false;
            this.оконныйБлокDataGridViewTextBoxColumn.Width = 105;
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            this.количествоDataGridViewTextBoxColumn.ReadOnly = true;
            this.количествоDataGridViewTextBoxColumn.Width = 91;
            // 
            // датаИзготовленияDataGridViewTextBoxColumn
            // 
            this.датаИзготовленияDataGridViewTextBoxColumn.DataPropertyName = "Дата изготовления";
            this.датаИзготовленияDataGridViewTextBoxColumn.HeaderText = "Дата изготовления";
            this.датаИзготовленияDataGridViewTextBoxColumn.Name = "датаИзготовленияDataGridViewTextBoxColumn";
            this.датаИзготовленияDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаИзготовленияDataGridViewTextBoxColumn.Width = 120;
            // 
            // кемИзготовленоDataGridViewTextBoxColumn
            // 
            this.кемИзготовленоDataGridViewTextBoxColumn.DataPropertyName = "Кем изготовлено";
            this.кемИзготовленоDataGridViewTextBoxColumn.HeaderText = "Кем изготовлено";
            this.кемИзготовленоDataGridViewTextBoxColumn.Name = "кемИзготовленоDataGridViewTextBoxColumn";
            this.кемИзготовленоDataGridViewTextBoxColumn.ReadOnly = true;
            this.кемИзготовленоDataGridViewTextBoxColumn.Visible = false;
            this.кемИзготовленоDataGridViewTextBoxColumn.Width = 110;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Оконный блок";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 96;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Кем изготовлено";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 110;
            // 
            // StoreWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 357);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "StoreWindow";
            this.Text = "Учет окон";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StoreWindow_FormClosing);
            this.Load += new System.EventHandler(this.StoreWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movedbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оконныйБлокBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.изготовлениеОконныхБлоковBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private movedbDataSet movedbDataSet;
        private System.Windows.Forms.BindingSource оконныйБлокBindingSource;
        private movedbDataSetTableAdapters.оконный_блокTableAdapter оконный_блокTableAdapter;
        private System.Windows.Forms.BindingSource пользователиBindingSource;
        private movedbDataSetTableAdapters.пользователиTableAdapter пользователиTableAdapter;
        private System.Windows.Forms.BindingSource изготовлениеОконныхБлоковBindingSource;
        private movedbDataSetTableAdapters.изготовление_оконных_блоковTableAdapter изготовление_оконных_блоковTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оконныйБлокDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаИзготовленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кемИзготовленоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}