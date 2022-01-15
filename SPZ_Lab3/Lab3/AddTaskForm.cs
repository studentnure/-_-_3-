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
    public partial class AddTaskForm : Form
    {
        public string TaskName { get; set; }
        private int _executionTime;
        public int ExecutionTime { get; set; }
        public string AdditionalInfo { get; set; }

        public AddTaskForm()
        {
            InitializeComponent();
        }

        private void SubmitButtonCLick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameTextbox.Text))
            {
                TaskName = nameTextbox.Text;
            }
            else
            {
                MessageBox.Show("Name can't be empty");
                return;
            }

            AdditionalInfo = addInfoTextbox.Text;

            if (int.TryParse(execTimeTextbox.Text, out _executionTime))
            {
                ExecutionTime = _executionTime;
                DialogResult = DialogResult.OK;
                Hide();
            }
            else
            {
                MessageBox.Show("Time should be a number");
            }
            
        }
    }
}
