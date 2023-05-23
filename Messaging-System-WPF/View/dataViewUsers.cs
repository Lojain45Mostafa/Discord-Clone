using Messaging_System_WPF.Controller;
using Messaging_System_WPF.Controllers;
using Messaging_System_WPF.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Messaging_System_WPF.View
{
    public partial class dataViewUsers : Form
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

        public dataViewUsers()
        {
            InitializeComponent();
            InitializeDataGridView();
            IntPtr regionHandle = CreateRoundRectRgn(0, 0, textBox1.Width, textBox1.Height, 10, 10);
            SetWindowRgn(textBox1.Handle, regionHandle, true);
            LoadUsers();

        }
        private void InitializeDataGridView()
        {
            // the hash column 
            // Add the update button column
         
            Panel panel = new Panel();
            panel.Size = dataGridView.Size;
            panel.Location = dataGridView.Location;

            // Add the Panel control to the form
            Controls.Add(panel);

            // Set the DataGridView properties
            dataGridView.Parent = panel;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.RowHeadersVisible = false;
            dataGridView.Columns.Add("Name", "Name");
            dataGridView.Columns.Add("Email", "Email");
            dataGridView.Columns.Add("Password", "Password");
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dataGridView.Columns["Name"].DefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView.Columns["Email"].DefaultCellStyle.ForeColor = Color.Red;
            dataGridView.Columns["Password"].DefaultCellStyle.Font = new Font(dataGridView.Font, FontStyle.Bold);
            DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn();
            updateButtonColumn.Name = "Update";
            updateButtonColumn.HeaderText = "Update";
            updateButtonColumn.Text = "Update";
            updateButtonColumn.UseColumnTextForButtonValue = true;
            updateButtonColumn.DefaultCellStyle.BackColor = Color.Blue;
            updateButtonColumn.DefaultCellStyle.ForeColor = Color.White;
            dataGridView.Columns.Add(updateButtonColumn);

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.DefaultCellStyle.BackColor = Color.Red;
            deleteButtonColumn.DefaultCellStyle.ForeColor = Color.White;
            dataGridView.Columns.Add(deleteButtonColumn);

            dataGridView.CellFormatting += DataGridView_CellFormatting;

        }
        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell is DataGridViewButtonCell)
                {
                    var buttonCell = (DataGridViewButtonCell)cell;
                    if (buttonCell.OwningColumn.Name == "Update")
                    {
                        buttonCell.Style.BackColor = Color.Blue;
                        buttonCell.Style.ForeColor = Color.White;
                    }
                    else if (buttonCell.OwningColumn.Name == "Delete")
                    {
                        buttonCell.Style.BackColor = Color.Red;
                        buttonCell.Style.ForeColor = Color.White;
                    }
                }
            }
        }

        private void LoadUsers()
        {
            string connectionString = "Server=DESKTOP-LM1FJ15\\SQLEXPRESS; Database=Messaging-System; User=Nancy; Password=Nancy44";
            ViewUserController controller = new ViewUserController(connectionString);
            List<User> users = controller.ReadUsers();

            dataGridView.Rows.Clear();

            foreach (User user in users)
            {
                dataGridView.Rows.Add(user.Name, user.Email, user.Password, user.profile_picture);
            }
        }
            private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
