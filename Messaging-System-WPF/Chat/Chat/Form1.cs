using Microsoft.AspNetCore.SignalR.Client;

namespace Chat
{
    public partial class Form1 : Form
    {
        HubConnection hubconnection;
        public Form1()
        {
            InitializeComponent();
            hubconnection = new HubConnectionBuilder().WithUrl("https://localhost:8080/Chat").Build();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Message_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}