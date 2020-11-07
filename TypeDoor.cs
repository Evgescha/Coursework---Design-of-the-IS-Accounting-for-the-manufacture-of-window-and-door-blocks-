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
    }
}
