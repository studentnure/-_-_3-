using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class AddComputerForm : Form
    {
        public string Name { get; set; }


        public AddComputerForm()
        {
            InitializeComponent();
        }

        private void AddButton(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameTextBox.Text))
            {
                Name = nameTextBox.Text;
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Hide();
            }
            else
            {
                MessageBox.Show("Name can't be empty");
            }
        }
    }
}
