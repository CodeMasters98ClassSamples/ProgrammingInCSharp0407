using PogrammingInCSharp.BaseBackend.Models;
using PogrammingInCSharp.BaseBackend.Services;
using ProgrammingInCSharp0407.Panel.Helpers;
using System.Windows.Forms;

namespace ProgrammingInCSharp0407.Panel.Forms
{
    public partial class UserManagmentForm : Form
    {
        int SelectedUserId = 0;
        UserService userService;

        // Declare the Delegate.
        public delegate void ReloadData(List<User> myUsers);

        // Declare the event.
        public event ReloadData ReloadDataEvent;

        public UserManagmentForm()
        {
            InitializeComponent();
            userService = new UserService();

            ReloadDataEvent += FillDataGrid; //معرفی متد به رویداد میباشد و در واقع فراخوانی نیست
            ReloadDataEvent.Invoke(userService.GetAll());
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
            SelectedUserId = 0;
        }

        private void FillDataGrid(List<User> myUsers)
        {
            userDataGridView.DataSource = null;
            userDataGridView.DataSource = myUsers;
            userDataGridView.Refresh();

            ResetForm();

            MessageBox.Show("Record Updated successfully");

        }


        private void userDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore header row clicks
            if (e.RowIndex >= 0)
            {
                // Get the current row
                var row = userDataGridView.Rows[e.RowIndex];

                // Access the ID from the row's data
                SelectedUserId = int.Parse(row.Cells["Id"].Value.ToString());

                // Display or use the ID
                firstNameTextBox.Text = row.Cells["FirstName"].Value?.ToString();
                lastNameTextBox.Text = row.Cells["LastName"].Value?.ToString();
                nationalCodeTextBox.Text = row.Cells["NationalCode"].Value?.ToString();
                phoneNumberTextBox.Text = row.Cells["PhoneNumber"].Value?.ToString();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {


            if (SelectedUserId == 0)
            {
                MessageBox.Show("Please select row!");
                return;
            }

            //I need user id
            //service call
            userService.Delete(SelectedUserId);
            ReloadDataEvent.Invoke(userService.GetAll());

       
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (SelectedUserId == 0)
            {
                MessageBox.Show("Please select row!");
                return;
            }

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
            User user = new User
            {
                Id = SelectedUserId,
                FirstName = firstName,
                LastName = lastName,
                BirthDate = birthDate,
                NationalCode = nationalCode,
                PhoneNumber = phoneNumber,
            };

            //Object add to collection
            userService.Update(user);
            ReloadDataEvent.Invoke(userService.GetAll());
        }
    }
}
