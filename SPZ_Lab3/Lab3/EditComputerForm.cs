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
    public partial class EditComputerForm : Form
    {
        private Form1 _main;
        public string Name { get; set; }

        public EditComputerForm(Form1 main)
        {
            InitializeComponent();
            _main = main;
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            Name = nameTextbox.Text;
            DialogResult = DialogResult.OK;
            Hide();
        }

        private void EditComputerFormLoad(object sender, EventArgs e)
        {
            nameTextbox.Text = _main.selectedComputer.Name;
        }
    }
}
