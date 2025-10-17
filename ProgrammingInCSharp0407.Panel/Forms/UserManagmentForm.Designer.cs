namespace ProgrammingInCSharp0407.Panel.Forms
{
    partial class UserManagmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            nationalCodeTextBox = new TextBox();
            phoneNumberTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            regitserButton = new Button();
            resetRegistrationButton = new Button();
            userDataGridView = new DataGridView();
            birthDateTimePicker = new DateTimePicker();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).BeginInit();
            SuspendLayout();
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(97, 12);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(173, 23);
            firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(97, 54);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(173, 23);
            lastNameTextBox.TabIndex = 1;
            // 
            // nationalCodeTextBox
            // 
            nationalCodeTextBox.Location = new Point(393, 12);
            nationalCodeTextBox.Name = "nationalCodeTextBox";
            nationalCodeTextBox.Size = new Size(201, 23);
            nationalCodeTextBox.TabIndex = 2;
            nationalCodeTextBox.TextChanged += textBox1_TextChanged;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(393, 54);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(201, 23);
            phoneNumberTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 16);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 4;
            label1.Text = "نام";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(349, 16);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "کدملی";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 57);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 6;
            label3.Text = "نام خانوادگی";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(329, 57);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 7;
            label4.Text = "تلفن همراه";
            // 
            // regitserButton
            // 
            regitserButton.Location = new Point(22, 128);
            regitserButton.Name = "regitserButton";
            regitserButton.Size = new Size(285, 29);
            regitserButton.TabIndex = 8;
            regitserButton.Text = "ثبت نام";
            regitserButton.UseVisualStyleBackColor = true;
            regitserButton.Click += regitserButton_Click;
            // 
            // resetRegistrationButton
            // 
            resetRegistrationButton.Location = new Point(313, 128);
            resetRegistrationButton.Name = "resetRegistrationButton";
            resetRegistrationButton.Size = new Size(281, 29);
            resetRegistrationButton.TabIndex = 9;
            resetRegistrationButton.Text = "ریست فرم";
            resetRegistrationButton.UseVisualStyleBackColor = true;
            resetRegistrationButton.Click += resetRegistrationButton_Click;
            // 
            // userDataGridView
            // 
            userDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGridView.Location = new Point(22, 198);
            userDataGridView.Name = "userDataGridView";
            userDataGridView.Size = new Size(570, 296);
            userDataGridView.TabIndex = 10;
            // 
            // birthDateTimePicker
            // 
            birthDateTimePicker.Location = new Point(97, 99);
            birthDateTimePicker.Name = "birthDateTimePicker";
            birthDateTimePicker.Size = new Size(497, 23);
            birthDateTimePicker.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 105);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 12;
            label5.Text = "تاریخ تولد";
            // 
            // button1
            // 
            button1.Location = new Point(22, 163);
            button1.Name = "button1";
            button1.Size = new Size(285, 29);
            button1.TabIndex = 13;
            button1.Text = "حذف";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(313, 163);
            button2.Name = "button2";
            button2.Size = new Size(281, 29);
            button2.TabIndex = 14;
            button2.Text = "آپدیت";
            button2.UseVisualStyleBackColor = true;
            // 
            // UserManagmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 506);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(birthDateTimePicker);
            Controls.Add(userDataGridView);
            Controls.Add(resetRegistrationButton);
            Controls.Add(regitserButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(nationalCodeTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Name = "UserManagmentForm";
            Text = "UserManagmentForm";
            Load += UserManagmentForm_Load;
            ((System.ComponentModel.ISupportInitialize)userDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox nationalCodeTextBox;
        private TextBox phoneNumberTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button regitserButton;
        private Button resetRegistrationButton;
        private DataGridView userDataGridView;
        private DateTimePicker birthDateTimePicker;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}