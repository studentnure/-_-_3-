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
    public partial class TasksForm : Form
    {
        private AddTaskForm _addTaskForm;
        private EditTaskForm _editTaskForm;

        private BindingSource _bs;
        public Form1 _main;

        public string ChosenTask { get; set; }
        public int ChosenTaskIndex { get; set; }

        public TasksForm(Form1 main)
        {
            InitializeComponent();
            _main = main;
            _addTaskForm = new AddTaskForm();

            _bs = new BindingSource();
            _bs.DataSource = _main.computerManager.fullTaskList.Values;
            taskListBx.DataSource = _bs;

            _editTaskForm = new EditTaskForm(this);
            //foreach (var item in _main.computerManager.fullTaskList.Keys)
            //{
            //    taskListBx.Items.Add(item);
            //}
        }

        private void AddTaskButtonClick(object sender, EventArgs e)
        {
            if (_addTaskForm.ShowDialog() == DialogResult.OK)
            {
                Task temp = new Task(_addTaskForm.ExecutionTime, _addTaskForm.TaskName, _addTaskForm.AdditionalInfo);
                _main.computerManager.AddTask(temp);

                _bs = new BindingSource(_main.computerManager.fullTaskList.Values, null);
                taskListBx.DataSource = _bs;
                _bs.ResetBindings(true);

            }
        }

        private void SelectButtonClick(object sender, EventArgs e)
        {
            ChosenTask = (taskListBx.SelectedItem as Task).Name;
            DialogResult = DialogResult.OK;
            Hide();
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            if (taskListBx.SelectedItem is null)
            {
                MessageBox.Show("Choose task to delete");
                return;
            }

            _main.computerManager.fullTaskList.Remove(taskListBx.SelectedItem.ToString());

            _bs = new BindingSource(_main.computerManager.fullTaskList.Values, null);
            taskListBx.DataSource = _bs;
            _bs.ResetBindings(true);
        }

        private void TaskListBxMouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = taskListBx.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                ChosenTaskIndex = taskListBx.SelectedIndex;
                if (_editTaskForm.ShowDialog() == DialogResult.OK)
                {
                    _main.computerManager.fullTaskList.ElementAt(ChosenTaskIndex).Value.ExecutionTimeInSeconds = _editTaskForm.ExecTime;
                    _main.computerManager.fullTaskList.ElementAt(ChosenTaskIndex).Value.AdditionalInfo = _editTaskForm.AddInfo;

                    _bs = new BindingSource(_main.computerManager.fullTaskList.Values, null);
                    taskListBx.DataSource = _bs;
                    _bs.ResetBindings(true);
                }
            }
        }
    }
}
