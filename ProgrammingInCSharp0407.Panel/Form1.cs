using Newtonsoft.Json;
using ProgrammingInCSharp0407.Panel.Forms;
using ProgrammingInCSharp0407.Panel.Wrappers;
using System;

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

            string pathUserLoginFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "UserLogin.json");
            if (!File.Exists(pathUserLoginFile))
            {
                MessageBox.Show("Invaid File Path");
                return;
            }

            string content = File.ReadAllText(pathUserLoginFile);
            List<UserLogin> userLogins = JsonConvert.DeserializeObject<List<UserLogin>>(content);

            var loing = userLogins.Where(item => item.UserName == username && item.Password == password).FirstOrDefault();
            if (loing is not null)
            {
                LayoutPanelForm form = new LayoutPanelForm();
                form.ShowDialog();
                return;
            }

            //for (int i = 0; i < userLogins.Count; i++)
            //{
            //    if (username == userLogins[i].UserName && password == userLogins[i].Password)
            //    {
            //        LayoutPanelForm form = new LayoutPanelForm();
            //        form.ShowDialog();
            //        return;
            //    }
            //}

            //string pathUserLoginFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "UserLogin.txt");
            //if (!File.Exists(pathUserLoginFile))
            //{
            //    MessageBox.Show("Invaid File Path");
            //    return;
            //}

            //string[] lines = File.ReadAllLines(pathUserLoginFile);
            //for (int i = 0; i < lines.Length; i++)
            //{
            //    string currentLine = lines[i];//admin,1234
            //    string[] login = currentLine.Split(",");

            //    //Work with Files
            //    //Json File
            //    //Install Package & Usage Package
            //    if (username == login[0] && password == login[1])
            //    {
            //        LayoutPanelForm form = new LayoutPanelForm();
            //        form.ShowDialog();
            //        return;
            //    }
            //}


            MessageBox.Show("Invalid Login");
        }

    }
}
