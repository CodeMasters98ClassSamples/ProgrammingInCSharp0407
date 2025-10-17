using ProgrammingInCSharp0407.Panel.Helpers;
using ProgrammingInCSharp0407.Panel.Models;
using ProgrammingInCSharp0407.Panel.Services;

namespace ProgrammingInCSharp0407.Panel.Forms
{
    public partial class UserManagmentForm : Form
    {
        UserService userService;
        public UserManagmentForm()
        {
            InitializeComponent();
            userService = new UserService();
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
            DateTime birthDate = birthDateTimePicker.Value;

            //Validation
            if (!PhoneNumberHelper.IsValidPhoneNumber(phoneNumber))
            {
                MessageBox.Show("لطفا شماره تلفن همراه را به صورت صحصح وارد نمایید.");
                return;
            }

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("لطفا اطلاعات خواسته شده را به صورت صحیح وارد نمایید.");
                return;
            }


            //Object
            User user = new User(nationalCode: nationalCode, phoneNumber: phoneNumber, firstName, lastName, birthDate);

            //Object add to collection
            userService.Add(user);

            //Show data
            FillDataGrid(userService.GetAll());

            //Reset my form
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

        private void FillDataGrid(List<User> myUsers)
        {
            userDataGridView.DataSource = null;
            userDataGridView.DataSource = myUsers;
            userDataGridView.Refresh();
        }
    }
}
