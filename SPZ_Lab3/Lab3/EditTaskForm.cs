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
    public partial class EditTaskForm : Form
    {
        private TasksForm _main;
        public double ExecTime { get; set; }
        public string AddInfo { get; set; }

        public EditTaskForm(TasksForm main)
        {
            InitializeComponent();
            _main = main;
        }

        private void EditTaskFormLoad(object sender, EventArgs e)
        {
            executionTimeTextbox.Text = _main._main.computerManager.fullTaskList.ElementAt(_main.ChosenTaskIndex).Value.ExecutionTimeInSeconds.ToString();
            addInfoTextbox.Text = _main._main.computerManager.fullTaskList.ElementAt(_main.ChosenTaskIndex).Value.AdditionalInfo;
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            double tmp;

            if (double.TryParse(executionTimeTextbox.Text, out tmp) && tmp >= 0)
            {
                ExecTime = tmp;
            }
            else
            {
                MessageBox.Show("Time should be a positive number");
                return;
            }

            AddInfo = addInfoTextbox.Text;
            DialogResult = DialogResult.OK;
            Hide();
        }
    }
}
