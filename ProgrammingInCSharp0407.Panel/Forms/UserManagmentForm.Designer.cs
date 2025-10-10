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
            regitserButton.Location = new Point(22, 96);
            regitserButton.Name = "regitserButton";
            regitserButton.Size = new Size(285, 29);
            regitserButton.TabIndex = 8;
            regitserButton.Text = "ثبت نام";
            regitserButton.UseVisualStyleBackColor = true;
            regitserButton.Click += regitserButton_Click;
            // 
            // resetRegistrationButton
            // 
            resetRegistrationButton.Location = new Point(313, 96);
            resetRegistrationButton.Name = "resetRegistrationButton";
            resetRegistrationButton.Size = new Size(281, 29);
            resetRegistrationButton.TabIndex = 9;
            resetRegistrationButton.Text = "ریست فرم";
            resetRegistrationButton.UseVisualStyleBackColor = true;
            resetRegistrationButton.Click += resetRegistrationButton_Click;
            // 
            // UserManagmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 450);
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
    }
}