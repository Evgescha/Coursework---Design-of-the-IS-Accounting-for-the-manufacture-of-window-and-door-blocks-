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
    public partial class StoreWindow : Form
    {
        public StoreWindow()
        {
            InitializeComponent();
        }

        private void StoreWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            if (Login.userID == 1)
            {
                Login.admin.Show();
            }

            else
            {
                Login.login.Show();
            }
        }
        //dictionary window
        private void button5_Click(object sender, EventArgs e)
        {
            Login.dictionaryWindow = new DictionaryWindow();
            Login.dictionaryWindow.Show();
            this.Hide();
        }
        //type window
        private void button4_Click(object sender, EventArgs e)
        {
            Login.typeWindow = new TypeWindow();
            Login.typeWindow.Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
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

        private void add()
        {
            if (!isFieldFill()) return;

            try
            {
                DataRowView row = (DataRowView)изготовлениеОконныхБлоковBindingSource.AddNew();

                row[1] = comboBox1.SelectedValue;
                row[2] = textBox1.Text;
                row[3] = dateTimePicker1.Text;
                row[4] = comboBox2.SelectedValue;

                изготовлениеОконныхБлоковBindingSource.EndEdit();
                this.изготовление_оконных_блоковTableAdapter.Update(movedbDataSet);
                this.изготовление_оконных_блоковTableAdapter.Fill(this.movedbDataSet.изготовление_оконных_блоков);
                clearFields();
                fixDataGridColumnsText();
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
                dataGridView1.CurrentRow.Cells[1].Value = comboBox1.SelectedValue;
                dataGridView1.CurrentRow.Cells[2].Value = textBox1.Text;
                dataGridView1.CurrentRow.Cells[3].Value = dateTimePicker1.Text;
                dataGridView1.CurrentRow.Cells[4].Value = comboBox2.SelectedValue;

                изготовлениеОконныхБлоковBindingSource.EndEdit();
                this.изготовление_оконных_блоковTableAdapter.Update(((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row);
                this.изготовление_оконных_блоковTableAdapter.Fill(this.movedbDataSet.изготовление_оконных_блоков);

                fixDataGridColumnsText();
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
                    изготовлениеОконныхБлоковBindingSource.RemoveAt(dataGridView1.CurrentRow.Index);
                    изготовление_оконных_блоковTableAdapter.Update(movedbDataSet.изготовление_оконных_блоков);
                    this.изготовление_оконных_блоковTableAdapter.Fill(this.movedbDataSet.изготовление_оконных_блоков);
                    fixDataGridColumnsText();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private bool isFieldFill()
        {
            if (textBox1.Text.Length < 1) return false;
            return true;
        }
        private void clearFields()
        {
            textBox1.Text = "";
        }

        private void fixDataGridColumnsText()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                comboBox1.SelectedItem = comboBox1.Items[
                                            оконныйБлокBindingSource.Find(
                                                        "Код",
                                                        int.Parse(dataGridView1[1, i].Value.ToString())
                                                        )
                                            ];
                dataGridView1[5, i].Value = comboBox1.Text;

                comboBox2.SelectedItem = comboBox2.Items[
                                            пользователиBindingSource.Find(
                                                        "Код",
                                                        int.Parse(dataGridView1[4, i].Value.ToString())
                                                        )
                                            ];
                dataGridView1[6, i].Value = comboBox2.Text;
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1 && dataGridView1.CurrentRow == null) return;
            if (dataGridView1.CurrentRow != null)
            {
                comboBox1.SelectedValue = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                comboBox2.SelectedValue = int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            }
        }

        private void StoreWindow_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.изготовление_оконных_блоков". При необходимости она может быть перемещена или удалена.
            this.изготовление_оконных_блоковTableAdapter.Fill(this.movedbDataSet.изготовление_оконных_блоков);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.movedbDataSet.пользователи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.оконный_блок". При необходимости она может быть перемещена или удалена.
            this.оконный_блокTableAdapter.Fill(this.movedbDataSet.оконный_блок);
            fixDataGridColumnsText();
        }
    }
}
