using ProgrammingInCSharp0407.Panel.Forms;

namespace ProgrammingInCSharp0407.Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Business code
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            rememberMeCheckBox.Enabled = false;
            //Database check
            //file check

            //hard code
            if (username == "admin" && password == "1234")
            {
                LayoutPanelForm form = new LayoutPanelForm();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }

        }

    }
}
