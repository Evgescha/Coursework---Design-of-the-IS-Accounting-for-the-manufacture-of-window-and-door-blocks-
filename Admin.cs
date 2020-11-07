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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login.login.Show();
            this.Hide();

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
        //storeWindow
        private void button1_Click(object sender, EventArgs e)
        {
            Login.storeWindow = new StoreWindow();
            Login.storeWindow.Show();
            this.Hide();
        }
        //storeDoor
        private void button2_Click(object sender, EventArgs e)
        {
            Login.storeDoor = new StoreDoor();
            Login.storeDoor.Show();
            this.Hide();
        }
        //users
        private void button3_Click(object sender, EventArgs e)
        {
            Login.users = new Users();
            Login.users.Show();
            this.Hide();
        }
        //back
        private void button4_Click(object sender, EventArgs e)
        {
            Login.login.Show();
            this.Hide();
        }
    }
}
