using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingInCSharp0407.Panel.Forms
{
    public partial class LayoutPanelForm : Form
    {
        public LayoutPanelForm()
        {
            InitializeComponent();
        }

        private void managmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManagmentForm managmentForm = new UserManagmentForm();
            managmentForm.ShowDialog();
        }

        private void managmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductManagementForm productManagementForm = new ProductManagementForm();
            productManagementForm.ShowDialog();
        }
    }
}
