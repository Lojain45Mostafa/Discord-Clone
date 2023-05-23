using Messaging_System_WPF.controller;
using Messaging_System_WPF.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messaging_System_WPF
{
    public partial class Login : Form
    {
        private LoginController loginController;
        public Login()
        {
            InitializeComponent();
            string connectionString = "Server=DESKTOP-LM1FJ15\\SQLEXPRESS; Database=Messaging-System; User=Nancy; Password=Nancy44";
            loginController = new LoginController(connectionString);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            SignUp register = new SignUp(); // Create an instance of the Login form
          ////  register.Show(); // Show the Login form
       //     Dashboard dashboard = new Dashboard();
       //     dashboard.Show();
         dataViewUsers viewUsers = new dataViewUsers();
         viewUsers.Show(); 
            this.Hide(); // Hide the current form (assuming the code is inside the current form)
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

            bool isValidUser = loginController.LoginUser(email, password);

            if (isValidUser)
            {
                MessageBox.Show("Login successful!");
                HomeDraft home = new HomeDraft();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password!");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
