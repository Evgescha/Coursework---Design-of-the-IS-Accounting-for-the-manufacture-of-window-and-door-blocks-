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
    }
}
