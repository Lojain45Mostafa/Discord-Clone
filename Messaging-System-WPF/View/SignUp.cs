using Messaging_System_WPF.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messaging_System_WPF.View
{
    public partial class SignUp : Form
    {
        private SignUpController signUpController;
        public SignUp()
        {
            InitializeComponent();
            string connectionString = "Server=DESKTOP-LM1FJ15\\SQLEXPRESS; Database=Messaging-System; User=Nancy; Password=Nancy44";
            signUpController = new SignUpController(connectionString);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            try
            {

                //  string name = textBox1.Text;
                //  string email = textBox2.Text;
                //   string password = textBox3.Text;
                //model.User newUser = new()
                //{
                //string Name = textBox1.Text;
                //string Email = textBox2.Text;
                //string Password = textBox3.Text;
                string profile_picture = "D:\\principles of software design\\labs\\tries\\Messaging-System-WPF\\Messaging-System-WPF\\imgs\\profile1.jpg";
                //};

                signUpController.CreateUser(textBox1.Text, textBox2.Text, textBox3.Text, profile_picture);

                MessageBox.Show("User created successfully!");
                // Additional logic or navigation can be added here
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur
                MessageBox.Show("Error creating user!" + ex.Message);

            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Login loginForm = new(); // Create an instance of the Login form
            loginForm.Show(); // Show the Login form
            this.Hide(); // Hide the current form (assuming the code is inside the current form)
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
