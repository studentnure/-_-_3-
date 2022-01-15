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
    public partial class Form1 : Form
    {
        private AddComputerForm _addComputerFrom;
        private SetWifiForm _setWifiForm;
        private TasksForm _tasksForm;
        private CompareForm _compareForm;
        private EditComputerForm _editComputerForm;

        public ComputerManager computerManager;
        public Computer selectedComputer;


        private BindingSource _bsComputer;
        private BindingSource _bsComputerTasks;

        public ListBox TaskListBox { get { return taskListbox; } }

        public Form1()
        {
            InitializeComponent();

            _addComputerFrom = new AddComputerForm();
            _setWifiForm = new SetWifiForm();


            computerManager = new ComputerManager(10);
            computerManager.AddTask(new Task(5, "qwe", ""));
            computerManager.AddTask(new Task(53, "zxc", "22"));

            _tasksForm = new TasksForm(this);
            _compareForm = new CompareForm(this);
            _editComputerForm = new EditComputerForm(this);

            _bsComputer = new BindingSource();
            _bsComputerTasks = new BindingSource();

            _bsComputer.DataSource = computerManager.computerList;
            computersListbox.DataSource = _bsComputer;

            taskListbox.DataSource = _bsComputerTasks;
        }


        private void AddComputerButtonClick(object sender, EventArgs e)
        {
            if (_addComputerFrom.ShowDialog() == DialogResult.OK)
            {
                computerManager.AddComputer(new Computer(_addComputerFrom.Name));
                _bsComputer.ResetBindings(true);
                _bsComputerTasks.ResetBindings(true);

            }
        }

        private void RemoveComputerButtonClick(object sender, EventArgs e)
        {
			if (computersListbox.SelectedItem is null)
			{
				MessageBox.Show("Choose PC to delete");
				return;
			}

			computerManager.RemoveComputer(computersListbox.SelectedItem as Computer);
            _bsComputer.ResetBindings(true);
        }

        private void SetWifiButtonClick(object sender, EventArgs e)
        {
            if (_setWifiForm.ShowDialog() == DialogResult.OK)
            {
                computerManager.InstallRouter(_setWifiForm.Password);
                btRemoveWifi.Enabled = true;
                btSetWifi.Enabled = false;
            }
        }

        private void RemoveWifiButtonClick(object sender, EventArgs e)
        {
            computerManager.RemoveRouter();
            btRemoveWifi.Enabled = false;
            btSetWifi.Enabled = true;
        }

        private void AssignTaskButtonClick(object sender, EventArgs e)
        {
            if (_tasksForm.ShowDialog() == DialogResult.OK)
            {
                Computer chosenComputer = computersListbox.SelectedItem as Computer;
                if (chosenComputer == null)
                {
                    MessageBox.Show("Cant assign task. First choose computer");
                    return;
                }
                try
                {
                    computerManager.AddTaskOnComputer(chosenComputer, _tasksForm.ChosenTask);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                selectedComputer = computersListbox.SelectedItem as Computer;
                _bsComputerTasks.DataSource = selectedComputer.taskList;
                _bsComputerTasks.ResetBindings(true);
            }
        }

        private void ComputerListSelectedIndexChanged(object sender, EventArgs e)
        {
            selectedComputer = computersListbox.SelectedItem as Computer;
            if (selectedComputer == null)
            {
                return;
            }
            _bsComputerTasks.DataSource = selectedComputer.taskList;
            _bsComputerTasks.ResetBindings(true);
        }

        private void RemoveTaskButtonClick(object sender, EventArgs e)
        {
            Task selectedTask;
            selectedTask = taskListbox.SelectedItem as Task;
            //if (selectedComputer.currentTaks == selectedTask)
            //{
            //    MessageBox.Show("Current task cant be deleted now (still working)");
            //    return;
            //}

            if (selectedTask is null)
            {
                MessageBox.Show("Choose task to delete");
                return;
            }

            computerManager.RemoveTaskOnComputer(selectedComputer, selectedTask.ToString());
            _bsComputerTasks.ResetBindings(true);
        }

        private void CompareButtonClick(object sender, EventArgs e)
        {
            _compareForm.ShowDialog();
        }

        private void ComputerListMouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = computersListbox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                if (_editComputerForm.ShowDialog() == DialogResult.OK)
                {
                    selectedComputer.Name = _editComputerForm.Name;
                    _bsComputer.ResetBindings(false);
                }
            }
        }

        private void taskListbox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (selectedComputer is null)
            {
                return;
            }
            e.DrawBackground();
            Graphics g = e.Graphics;

            Brush myBrush = Brushes.Black;

            if (taskListbox.Items[e.Index] == selectedComputer.currentTask)
            {
                g.FillRectangle(new SolidBrush(Color.Green), e.Bounds);
            }

            //if (taskListbox.SelectedIndex == e.Index)
            //{
            //    myBrush = Brushes.White;
            //}


            e.Graphics.DrawString(taskListbox.Items[e.Index].ToString(), e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void TaskListboxMouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = taskListbox.IndexFromPoint(e.Location);
            if (selectedComputer is null)
            {
                return;
            }
            if (!selectedComputer.IsReady)
            {
                MessageBox.Show($"Computer is busy ({selectedComputer.currentTask.ToString()} task in process)");
                return;
            }
            if (index != ListBox.NoMatches)
            {
                Task task = taskListbox.SelectedValue as Task;
                computerManager.computerList[computersListbox.SelectedIndex].ExecuteTask(task, this);
                taskListbox.Refresh();
            }
        }
    }
}
