namespace ProgrammingInCSharp0407.Panel.Forms
{
    partial class ProductManagementForm
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
            addProductButton = new Button();
            label1 = new Label();
            nameTextBox = new TextBox();
            productDataGridView = new DataGridView();
            codeTextBox = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)productDataGridView).BeginInit();
            SuspendLayout();
            // 
            // addProductButton
            // 
            addProductButton.Location = new Point(12, 43);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(155, 35);
            addProductButton.TabIndex = 0;
            addProductButton.Text = "افرودن";
            addProductButton.UseVisualStyleBackColor = true;
            addProductButton.Click += addProductButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "نام محصول";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(82, 6);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(181, 23);
            nameTextBox.TabIndex = 2;
            // 
            // productDataGridView
            // 
            productDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDataGridView.Location = new Point(12, 95);
            productDataGridView.Name = "productDataGridView";
            productDataGridView.Size = new Size(776, 343);
            productDataGridView.TabIndex = 3;
            productDataGridView.CellContentClick += productDataGridView_CellContentClick;
            // 
            // codeTextBox
            // 
            codeTextBox.Location = new Point(363, 9);
            codeTextBox.Name = "codeTextBox";
            codeTextBox.Size = new Size(181, 23);
            codeTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(293, 12);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 4;
            label2.Text = "نام محصول";
            // 
            // button1
            // 
            button1.Location = new Point(173, 43);
            button1.Name = "button1";
            button1.Size = new Size(155, 35);
            button1.TabIndex = 6;
            button1.Text = "ریست فرم";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(334, 43);
            button2.Name = "button2";
            button2.Size = new Size(155, 35);
            button2.TabIndex = 7;
            button2.Text = "حذف";
            button2.UseVisualStyleBackColor = true;
            // 
            // ProductManagementForm
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
            Name = "ProductManagementForm";
            Text = "ProductManagementForm";
            ((System.ComponentModel.ISupportInitialize)productDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addProductButton;
        private Label label1;
        private TextBox nameTextBox;
        private DataGridView productDataGridView;
        private TextBox codeTextBox;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}