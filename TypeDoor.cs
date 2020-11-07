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
    public partial class TypeDoor : Form
    {
        public TypeDoor()
        {
            InitializeComponent();
        }

        private void TypeDoor_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();            
            Login.storeDoor.Show();
        }

        private void TypeDoor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.тип_открытия_двери". При необходимости она может быть перемещена или удалена.
            this.тип_открытия_двериTableAdapter.Fill(this.movedbDataSet.тип_открытия_двери);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.ограждающие_свойства_двери". При необходимости она может быть перемещена или удалена.
            this.ограждающие_свойства_двериTableAdapter.Fill(this.movedbDataSet.ограждающие_свойства_двери);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.материалы_для_дверей". При необходимости она может быть перемещена или удалена.
            this.материалы_для_дверейTableAdapter.Fill(this.movedbDataSet.материалы_для_дверей);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.створки". При необходимости она может быть перемещена или удалена.
            this.створкиTableAdapter.Fill(this.movedbDataSet.створки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.тип_двери". При необходимости она может быть перемещена или удалена.
            this.тип_двериTableAdapter.Fill(this.movedbDataSet.тип_двери);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.дверной_блок". При необходимости она может быть перемещена или удалена.
            this.дверной_блокTableAdapter.Fill(this.movedbDataSet.дверной_блок);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.тип_открытия_двери". При необходимости она может быть перемещена или удалена.
            this.тип_открытия_двериTableAdapter.Fill(this.movedbDataSet.тип_открытия_двери);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.дверной_блок". При необходимости она может быть перемещена или удалена.
            this.дверной_блокTableAdapter.Fill(this.movedbDataSet.дверной_блок);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.ограждающие_свойства_двери". При необходимости она может быть перемещена или удалена.
            this.ограждающие_свойства_двериTableAdapter.Fill(this.movedbDataSet.ограждающие_свойства_двери);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.материалы_для_дверей". При необходимости она может быть перемещена или удалена.
            this.материалы_для_дверейTableAdapter.Fill(this.movedbDataSet.материалы_для_дверей);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.створки". При необходимости она может быть перемещена или удалена.
            this.створкиTableAdapter.Fill(this.movedbDataSet.створки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.тип_двери". При необходимости она может быть перемещена или удалена.
            this.тип_двериTableAdapter.Fill(this.movedbDataSet.тип_двери);            
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
                DataRowView row = (DataRowView)двернойБлокBindingSource.AddNew();

                row[1] = textBox1.Text;
                row[2] = textBox2.Text;
                row[3] = textBox3.Text;
                row[4] = comboBox1.SelectedValue;
                row[5] = comboBox2.SelectedValue;
                row[6] = comboBox3.SelectedValue;
                row[7] = comboBox4.SelectedValue;
                row[8] = comboBox5.SelectedValue;
                row[9] = textBox4.Text;

                двернойБлокBindingSource.EndEdit();
                this.дверной_блокTableAdapter.Update(movedbDataSet);
                this.дверной_блокTableAdapter.Fill(this.movedbDataSet.дверной_блок);
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
                dataGridView1.CurrentRow.Cells[8].Value = comboBox5.SelectedValue;
                dataGridView1.CurrentRow.Cells[9].Value = textBox4.Text;

                двернойБлокBindingSource.EndEdit();
                this.дверной_блокTableAdapter.Update(((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row);
                this.дверной_блокTableAdapter.Fill(this.movedbDataSet.дверной_блок);

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
                    двернойБлокBindingSource.RemoveAt(dataGridView1.CurrentRow.Index);
                    двернойБлокBindingSource.EndEdit();
                    дверной_блокTableAdapter.Update(movedbDataSet.дверной_блок);
                    this.дверной_блокTableAdapter.Fill(this.movedbDataSet.дверной_блок);
                    
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
                textBox4.Text.Length < 1 ) return false;
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
                comboBox5.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            }
        }


    }
}
