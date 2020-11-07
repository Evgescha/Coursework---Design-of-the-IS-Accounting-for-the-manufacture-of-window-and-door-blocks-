using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2009_1956_DoorAndWindow
{
    public partial class TypeWindow : Form
    {
        public TypeWindow()
        {
            InitializeComponent();
        }

        private void TypeWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Login.storeWindow.Show();
        }

        private void TypeWindow_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.проветривание". При необходимости она может быть перемещена или удалена.
            this.проветриваниеTableAdapter.Fill(this.movedbDataSet.проветривание);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.направление_открытия_окна". При необходимости она может быть перемещена или удалена.
            this.направление_открытия_окнаTableAdapter.Fill(this.movedbDataSet.направление_открытия_окна);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.створки". При необходимости она может быть перемещена или удалена.
            this.створкиTableAdapter.Fill(this.movedbDataSet.створки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.материалы_для_окон". При необходимости она может быть перемещена или удалена.
            this.материалы_для_оконTableAdapter.Fill(this.movedbDataSet.материалы_для_окон);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.оконный_блок". При необходимости она может быть перемещена или удалена.
            this.оконный_блокTableAdapter.Fill(this.movedbDataSet.оконный_блок);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            add();
        }
        //edit
        private void button2_Click(object sender, EventArgs e)
        {
            edit();
        }
        //delete
        private void button3_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void add()
        {
            if (!isFieldFill()) return;

            try
            {
                DataRowView row = (DataRowView)оконныйБлокBindingSource.AddNew();

                row[1] = textBox1.Text;
                row[2] = textBox2.Text;
                row[3] = textBox3.Text;
                row[4] = comboBox1.SelectedValue;
                row[5] = comboBox2.SelectedValue;
                row[6] = comboBox3.SelectedValue;
                row[7] = comboBox4.SelectedValue;
                row[8] = textBox4.Text;

                оконныйБлокBindingSource.EndEdit();
                this.оконный_блокTableAdapter.Update(movedbDataSet);
                this.оконный_блокTableAdapter.Fill(this.movedbDataSet.оконный_блок);
                clearFields();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void edit()
        {
            if (!isFieldFill()) return;

            try
            {
                dataGridView1.CurrentRow.Cells[1].Value = textBox1.Text;
                dataGridView1.CurrentRow.Cells[2].Value = textBox2.Text;
                dataGridView1.CurrentRow.Cells[3].Value = textBox3.Text;
                dataGridView1.CurrentRow.Cells[4].Value = comboBox1.SelectedValue;
                dataGridView1.CurrentRow.Cells[5].Value = comboBox2.SelectedValue;
                dataGridView1.CurrentRow.Cells[6].Value = comboBox3.SelectedValue;
                dataGridView1.CurrentRow.Cells[7].Value = comboBox4.SelectedValue;
                dataGridView1.CurrentRow.Cells[8].Value = textBox4.Text;

                оконныйБлокBindingSource.EndEdit();
                this.оконный_блокTableAdapter.Update(((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row);
                this.оконный_блокTableAdapter.Fill(this.movedbDataSet.оконный_блок);

                clearFields();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void delete()
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentRow != null)
            {
                try
                {
                    movedbDataSet.AcceptChanges();
                    оконныйБлокBindingSource.RemoveAt(dataGridView1.CurrentRow.Index);
                    оконныйБлокBindingSource.EndEdit();
                    оконный_блокTableAdapter.Update(movedbDataSet.оконный_блок);
                    this.оконный_блокTableAdapter.Fill(this.movedbDataSet.оконный_блок);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private bool isFieldFill()
        {
            if (textBox1.Text.Length < 1 ||
                textBox2.Text.Length < 1 ||
                textBox3.Text.Length < 1 ||
                textBox4.Text.Length < 1) return false;
            return true;
        }
        private void clearFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }



        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1 && dataGridView1.CurrentRow == null) return;
            if (dataGridView1.CurrentRow != null)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                comboBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                comboBox3.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                comboBox4.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            }
        }


    
}
}
