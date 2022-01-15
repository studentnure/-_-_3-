using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_3
{
    public partial class AddStudentForm : Form
    {
        public string StudentName { get; set; }
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void SaveButtonOnClick(object sender, EventArgs e)
        {
            StudentName = nameTextBox.Text;
            DialogResult = DialogResult.OK;
            Hide();
        }
    }
}
