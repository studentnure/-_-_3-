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
    public partial class CompareForm : Form
    {
        private Form1 _main;
        public CompareForm(Form1 main)
        {
            InitializeComponent();

            _main = main;

            
        }

        private void CompareButtonClick(object sender, EventArgs e)
        {
            if (_main.computerManager.computerList.Count == 0)
            {
                MessageBox.Show("First add some computers");
                return;
            }
            Computer first, second;
            first = firstCompListbox.SelectedItem as Computer;
            second = secondCompListbox.SelectedItem as Computer;
            if (first == second)
            {
                MessageBox.Show($"{first.Name} == {second.Name}");
            }
            else
            {
                MessageBox.Show($"{first.Name} != {second.Name}");
            }
        }

        private void CompareFormLoad(object sender, EventArgs e)
        {
            firstCompListbox.DataSource = new BindingSource(_main.computerManager.computerList, null);
            secondCompListbox.DataSource = new BindingSource(_main.computerManager.computerList, null);
        }
    }
}
