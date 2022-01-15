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
    public partial class AddSubjectForm : Form
    {
        public string SubjectName { get; set; }
        public AddSubjectForm()
        {
            InitializeComponent();
        }

        private void SaveButtonOnClick(object sender, EventArgs e)
        {
            SubjectName = nameTextBox.Text;
            DialogResult = DialogResult.OK;
            Hide();
        }
    }
}
