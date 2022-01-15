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
    public partial class SetWifiForm : Form
    {
        public string Password { get; set; }

        public SetWifiForm()
        {
            InitializeComponent();
        }

        private void SubmitButtonClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(passwordTextbox.Text))
            {
                Password = passwordTextbox.Text;
                DialogResult = DialogResult.OK;
                Hide();
            }
            else
            {
                MessageBox.Show("Password can't be empty");
            }
        }
    }
}
