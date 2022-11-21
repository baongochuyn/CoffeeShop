using coffeeshop.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using coffeeshop.Controller;

namespace coffeeshop
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Do you want to exit?", "attention", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = new User();
            //{
            //    userName = "too",
            //    password = "tata",
            //    isAdmin = false
            //};
            //var path = Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName;

            //string fileName = path + ".\\json\\user.json";
            //string jsonString = File.ReadAllText(fileName);

            //List<User> listUser = JsonSerializer.Deserialize<List<User>>(jsonString);
            string userName = txbName.Text;
            string passWord = txbPassWord.Text;
            if (UserController.Instance.CheckPassword(userName,passWord))
            {
                fTableManager f = new fTableManager();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Username is incorrect");
            }


        }
   
    }
}
