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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Login.admin.Show();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.роли_пользователей". При необходимости она может быть перемещена или удалена.
            this.роли_пользователейTableAdapter.Fill(this.movedbDataSet.роли_пользователей);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.movedbDataSet.пользователи);

            fixDataGridColumnsText();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1 && dataGridView1.CurrentRow == null) return;
            if (dataGridView1.CurrentRow != null) {
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                comboBox1.SelectedValue = int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            }

        }
        private void fixDataGridColumnsText() {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                comboBox1.SelectedItem = comboBox1.Items[
                                            ролиПользователейBindingSource.Find(
                                                        "Код",
                                                        int.Parse(dataGridView1[4, i].Value.ToString())
                                                        )
                                            ];
                dataGridView1[5, i].Value = comboBox1.Text;
            }
        }
        //add
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

        private void add() {
            if (!isFieldFill()) return;

            try {
                DataRowView row = (DataRowView)пользователиBindingSource.AddNew();

                row[1] = textBox1.Text;
                row[2] = textBox2.Text;
                row[3] = textBox3.Text;
                row[4] = comboBox1.SelectedValue;

                пользователиBindingSource.EndEdit();
                this.пользователиTableAdapter.Update(movedbDataSet);
                this.пользователиTableAdapter.Fill(this.movedbDataSet.пользователи);
                clearFields();
                fixDataGridColumnsText();
            } catch(Exception e) {
                MessageBox.Show(e.Message);
            }
        }

        private void edit() {
            if (!isFieldFill()) return;

            try
            {
                dataGridView1.CurrentRow.Cells[1].Value = textBox1.Text;
                dataGridView1.CurrentRow.Cells[2].Value = textBox2.Text;
                dataGridView1.CurrentRow.Cells[3].Value = textBox3.Text;
                dataGridView1.CurrentRow.Cells[4].Value = comboBox1.SelectedValue;
                dataGridView1.CurrentRow.Cells[5].Value = comboBox1.Text;

                пользователиBindingSource.EndEdit();
                this.пользователиTableAdapter.Update(((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row);
                this.пользователиTableAdapter.Fill(this.movedbDataSet.пользователи);

                fixDataGridColumnsText();
                clearFields();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void delete() {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentRow != null) {
                try
                {
                    пользователиBindingSource.RemoveAt(dataGridView1.CurrentRow.Index);
                    пользователиTableAdapter.Update(movedbDataSet.пользователи);
                    this.пользователиTableAdapter.Fill(this.movedbDataSet.пользователи);
                    fixDataGridColumnsText();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private bool isFieldFill() {
            if (textBox1.Text.Length < 1 ||
                textBox2.Text.Length < 1 ||
                textBox3.Text.Length < 1) return false;
            return true;
        }
        private void clearFields() {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
