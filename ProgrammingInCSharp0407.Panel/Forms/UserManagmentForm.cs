using ProgrammingInCSharp0407.Panel.Models;

namespace ProgrammingInCSharp0407.Panel.Forms
{
    public partial class UserManagmentForm : Form
    {
        public UserManagmentForm()
        {
            InitializeComponent();
        }

        private void UserManagmentForm_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void regitserButton_Click(object sender, EventArgs e)
        {

            //Data Collect From User
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string nationalCode = nationalCodeTextBox.Text;
            string phoneNumber = phoneNumberTextBox.Text;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                return;
            }

            //DataType name
            //User user = new User();
            //User user = new();
            //var user = new User();
            //user.FirstName = firstName;
            //user.LastName = lastName;
            //user.NationalCode = nationalCode;
            //user.PhoneNumber = phoneNumber;
            User user = new User(nationalCode: nationalCode, phoneNumber: phoneNumber)
            {
                LastName = lastName,
                FirstName = firstName,
            };

            User user1 = new User(nationalCode: "", phoneNumber: "");
            ResetForm();
        }

        private void resetRegistrationButton_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            firstNameTextBox.Text = null;
            lastNameTextBox.Text = null;
            nationalCodeTextBox.Text = null;
            phoneNumberTextBox.Text = null;
        }
    }
}
