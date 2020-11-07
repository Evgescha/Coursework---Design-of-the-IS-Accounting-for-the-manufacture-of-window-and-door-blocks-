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
    public partial class StoreDoor : Form
    {
        public StoreDoor()
        {
            InitializeComponent();
        }

        private void StoreDoor_FormClosing(object sender, FormClosingEventArgs e)
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
        //type door
        private void button4_Click(object sender, EventArgs e)
        {
            Login.typeDoor = new TypeDoor();
            Login.typeDoor.Show();
            this.Hide();
        }
        // dictionary door
        private void button5_Click(object sender, EventArgs e)
        {
            Login.dictionaryDoor = new DictionaryDoor();
            Login.dictionaryDoor.Show();
            this.Hide();
        }
    }
}
