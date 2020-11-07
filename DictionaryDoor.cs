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
    public partial class DictionaryDoor : Form
    {
        public DictionaryDoor()
        {
            InitializeComponent();
        }

        private void DictionaryDoor_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();            
            Login.storeDoor.Show();            
        }

        private void DictionaryDoor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.тип_открытия_двери". При необходимости она может быть перемещена или удалена.
            this.тип_открытия_двериTableAdapter.Fill(this.movedbDataSet.тип_открытия_двери);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.тип_двери". При необходимости она может быть перемещена или удалена.
            this.тип_двериTableAdapter.Fill(this.movedbDataSet.тип_двери);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.материалы_для_дверей". При необходимости она может быть перемещена или удалена.
            this.материалы_для_дверейTableAdapter.Fill(this.movedbDataSet.материалы_для_дверей);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.ограждающие_свойства_двери". При необходимости она может быть перемещена или удалена.
            this.ограждающие_свойства_двериTableAdapter.Fill(this.movedbDataSet.ограждающие_свойства_двери);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.створки". При необходимости она может быть перемещена или удалена.
            this.створкиTableAdapter.Fill(this.movedbDataSet.створки);

        }
        //save stworki
        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            try            {
                створкиTableAdapter.Update(movedbDataSet.створки);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //save ograjd
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
            ограждающие_свойства_двериTableAdapter.Update(movedbDataSet.ограждающие_свойства_двери);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //save material
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            try
            {
            материалы_для_дверейTableAdapter.Update(movedbDataSet.материалы_для_дверей);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //save type door
        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            try
            {
            тип_двериTableAdapter.Update(movedbDataSet.тип_двери);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //save type opening door
        private void toolStripButton22_Click(object sender, EventArgs e)
        {
            try
            {
            тип_открытия_двериTableAdapter.Update(movedbDataSet.тип_открытия_двери);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
