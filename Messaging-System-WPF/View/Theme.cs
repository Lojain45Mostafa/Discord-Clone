using MaterialSkin;
using MaterialSkin.Controls;

namespace Messaging_System_WPF
{
    public partial class Theme : MaterialForm
    {
        public object TManager { get; private set; }

        public Theme()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            BackColor = System.Drawing.ColorTranslator.FromHtml("#6c63ff");

           

        }
        MaterialSkinManager TMan = MaterialSkinManager.Instance;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
            materialLabel1.Font = new Font("Roboto", 20);

        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(materialRadioButton1.Checked)
            {
                TMan.ColorScheme= new ColorScheme(Primary.Orange800,Primary.Orange900, Primary.Orange500, Accent.Orange200, TextShade.WHITE);
            }
        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (materialRadioButton2.Checked)
            {
                TMan.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green200, TextShade.WHITE);
            }
        }

        private void materialRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (materialRadioButton3.Checked)
            {
                TMan.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Blue200, TextShade.WHITE);
            }
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch1.Checked)
            {
                TMan.Theme = MaterialSkinManager.Themes.LIGHT; 
            }
            else
            {
                TMan.Theme = MaterialSkinManager.Themes.DARK;
            }
        }

        private void materialRadioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (materialRadioButton2.Checked)
            {
                TMan.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green200, TextShade.WHITE);
            }
        }
    }
}