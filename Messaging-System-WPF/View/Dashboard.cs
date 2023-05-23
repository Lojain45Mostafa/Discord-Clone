using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Messaging_System_WPF.View
{
    public partial class Dashboard : Form
    {
        
        [DllImport("user32.dll")]
        private static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);

        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        // ...

        // Add this after your InitializeComponent(); of the program

       
        public Dashboard()
        {
            InitializeComponent();
            // Get the screen size
            dataGridView.Visible = false;
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            // Calculate the round rectangle size based on the screen size
            int roundRectWidth = (int)(screenWidth * 0.9); // Adjust the factor as desired
            int roundRectHeight = (int)(screenHeight * 0.9); // Adjust the factor as desired

            // Calculate the round rectangle position based on the screen size
            int roundRectX = (screenWidth - roundRectWidth) / 2;
            int roundRectY = (screenHeight - roundRectHeight) / 2;

            // Create the round rectangle region
            Region region = Region.FromHrgn(CreateRoundRectRgn(roundRectX, roundRectY, roundRectWidth, roundRectHeight, 25, 25));
            IntPtr regionHandle = CreateRoundRectRgn(0, 0, textBox1.Width, textBox1.Height, 10, 10);
            SetWindowRgn(textBox1.Handle, regionHandle, true);
            textBox1.Padding = new Padding(10, 0, 0, 0);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            MainLabel.Text = "View Users";
            panelNav.Height = ViewUserButton.Height;
            panelNav.Top = ViewUserButton.Top;
            panelNav.Left = ViewUserButton.Left;
            AllUsersPanel.Visible = false;
            ActiveUsersPanel.Visible = false;
            ActivityProgressPanel.Visible = false;
            ActivityGraphPanel.Visible = false;
            dataGridView.Visible = true;
            dataGridView.Location = new Point(305, 125);
            

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            MainLabel.Text = "Dashboard";
            panelNav.Height = DashboardButton.Height;
            panelNav.Top= DashboardButton.Top;
            panelNav.Left= DashboardButton.Left;
            dataGridView.Visible = false;
            AllUsersPanel.Visible = true;
            ActiveUsersPanel.Visible = true;
            ActivityProgressPanel.Visible = true;
            ActivityGraphPanel.Visible = true;
        }

        private void DashboardButton_Leave(object sender, EventArgs e)
        {
            DashboardButton.BackColor = Color.FromArgb(24, 30, 54); 
        }

        private void ViewUserButton_Leave(object sender, EventArgs e)
        {
            ViewUserButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            MainLabel.Text = "Add User";
            panelNav.Height = AddUserButton.Height;
            panelNav.Top = AddUserButton.Top;
            panelNav.Left = AddUserButton.Left;

        }

        private void AddUserButton_Leave(object sender, EventArgs e)
        {
            AddUserButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void UpdateUserButton_Click(object sender, EventArgs e)
        {
            MainLabel.Text = "Edit User";
            panelNav.Height = UpdateUserButton.Height;
            panelNav.Top = UpdateUserButton.Top;
            panelNav.Left = UpdateUserButton.Left;
        }

        private void UpdateUserButton_Leave(object sender, EventArgs e)
        {
            UpdateUserButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            MainLabel.Text = "Delete User";
            panelNav.Height = DeleteUserButton.Height;
            panelNav.Top = DeleteUserButton.Top;
            panelNav.Left = DeleteUserButton.Left;
        }

        private void DeleteUserButton_Leave(object sender, EventArgs e)
        {
            DeleteUserButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void bunifuChartCanvas1_Load(object sender, EventArgs e)
        {

        }

        //private void Button_click(object sender, EventArgs e)
        //{
        //    Bunifu.Framework.UI.BunifuFlatButton button = (Bunifu.Framework.UI.BunifuFlatButton)sender;
        //    switch (button.Name)
        //    {
        //        case "DashboardButton":
        //            MainLabel.Text = "dashboard"; break;
        //        case "ViewUserButton":
        //            MainLabel.Text = "View"; break;

        //    }
        //}
    }
}
