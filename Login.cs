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
    public partial class Login : Form
    {
        public static Admin admin;
        public static DictionaryDoor dictionaryDoor;
        public static DictionaryWindow dictionaryWindow;
        public static Login login;
        public static StoreDoor storeDoor;
        public static StoreWindow storeWindow;
        public static TypeDoor typeDoor;
        public static TypeWindow typeWindow;
        public static Users users;
        public static int userID = -1, userRole;
        public static string userFIO;


        public Login()
        {
            InitializeComponent();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.movedbDataSet.пользователи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "movedbDataSet.пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.movedbDataSet.пользователи);
            login = this;
        }
        //exit
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //login
        private void button1_Click(object sender, EventArgs e)
        {
            loginingFirstStep();
        }
        //method login
        private void loginingFirstStep() {
            if (!isFieldFill())
                MessageBox.Show("Не все поля заполнены");
            userID = -1;
            string log = textBox1.Text;
            string pass = textBox2.Text;
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                if (dataGridView1[2, i].Value.ToString().Equals(log) &&
                    dataGridView1[3, i].Value.ToString().Equals(pass)) {
                    userID = int.Parse(dataGridView1[0, i].Value.ToString());
                    userFIO = dataGridView1[1, i].Value.ToString();
                    userRole = int.Parse(dataGridView1[4, i].Value.ToString());
                }
            if (userID == -1)
                MessageBox.Show("Пользователь не найден");
            else loginingSecondStep();
        }
        // select window from role
        private void loginingSecondStep() {
            //doow
            if (userRole==2) {
                storeDoor = new StoreDoor();
                storeDoor.Show();
            }
            //window
            else if (userRole==3) {
                storeWindow = new StoreWindow();
                storeWindow.Show();                
            }
            //admin
            else {
                admin = new Admin();
                admin.Show();
            }
            this.Hide();
        }
        // check buttins
        private bool isFieldFill() {
            if (textBox1.Text.Length < 1 && textBox2.Text.Length < 1)
                return false;
            return true;
        }

    }
}
