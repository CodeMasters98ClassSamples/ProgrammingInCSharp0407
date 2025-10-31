namespace ProgrammingInCSharp0407.StorePanel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            button1 = new Button();
            codeTextBox = new TextBox();
            label2 = new Label();
            productDataGridView = new DataGridView();
            nameTextBox = new TextBox();
            label1 = new Label();
            addProductButton = new Button();
            ((System.ComponentModel.ISupportInitialize)productDataGridView).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(334, 46);
            button2.Name = "button2";
            button2.Size = new Size(155, 35);
            button2.TabIndex = 15;
            button2.Text = "حذف";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(173, 46);
            button1.Name = "button1";
            button1.Size = new Size(155, 35);
            button1.TabIndex = 14;
            button1.Text = "ریست فرم";
            button1.UseVisualStyleBackColor = true;
            // 
            // codeTextBox
            // 
            codeTextBox.Location = new Point(363, 12);
            codeTextBox.Name = "codeTextBox";
            codeTextBox.Size = new Size(181, 23);
            codeTextBox.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(293, 15);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 12;
            label2.Text = "نام محصول";
            // 
            // productDataGridView
            // 
            productDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDataGridView.Location = new Point(12, 98);
            productDataGridView.Name = "productDataGridView";
            productDataGridView.Size = new Size(776, 343);
            productDataGridView.TabIndex = 11;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(82, 9);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(181, 23);
            nameTextBox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 9;
            label1.Text = "نام محصول";
            // 
            // addProductButton
            // 
            addProductButton.Location = new Point(12, 46);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(155, 35);
            addProductButton.TabIndex = 8;
            addProductButton.Text = "افرودن";
            addProductButton.UseVisualStyleBackColor = true;
            addProductButton.Click += addProductButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(codeTextBox);
            Controls.Add(label2);
            Controls.Add(productDataGridView);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Controls.Add(addProductButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)productDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox codeTextBox;
        private Label label2;
        private DataGridView productDataGridView;
        private TextBox nameTextBox;
        private Label label1;
        private Button addProductButton;
    }
}
