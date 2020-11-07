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
    }
}
