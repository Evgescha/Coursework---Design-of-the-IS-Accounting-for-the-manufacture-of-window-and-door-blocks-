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
    public partial class DictionaryWindow : Form
    {
        public DictionaryWindow()
        {
            InitializeComponent();
        }

        private void DictionaryWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();          
            Login.storeWindow.Show();
        }
        //save window glass
        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                оконные_стеклаTableAdapter.Update(movedbDataSet.оконные_стекла);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //save prowetriwanie
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            try
            {
                проветриваниеTableAdapter.Update(movedbDataSet.проветривание);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //save material
        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            try
            {
                материалы_для_оконTableAdapter.Update(movedbDataSet.материалы_для_окон);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //save direction opening
        private void toolStripButton21_Click(object sender, EventArgs e)
        {
            try
            {
                направление_открытия_окнаTableAdapter.Update(movedbDataSet.направление_открытия_окна);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //save stvorki
        private void toolStripButton28_Click(object sender, EventArgs e)
        {
            try
            {
                створкиTableAdapter.Update(movedbDataSet.створки);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void DictionaryWindow_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.створки". При необходимости она может быть перемещена или удалена.
            this.створкиTableAdapter.Fill(this.movedbDataSet.створки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.направление_открытия_окна". При необходимости она может быть перемещена или удалена.
            this.направление_открытия_окнаTableAdapter.Fill(this.movedbDataSet.направление_открытия_окна);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.материалы_для_окон". При необходимости она может быть перемещена или удалена.
            this.материалы_для_оконTableAdapter.Fill(this.movedbDataSet.материалы_для_окон);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.проветривание". При необходимости она может быть перемещена или удалена.
            this.проветриваниеTableAdapter.Fill(this.movedbDataSet.проветривание);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.оконные_стекла". При необходимости она может быть перемещена или удалена.
            this.оконные_стеклаTableAdapter.Fill(this.movedbDataSet.оконные_стекла);

        }
    }
}
