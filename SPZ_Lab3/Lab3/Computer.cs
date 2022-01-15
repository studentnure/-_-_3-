using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab3
{
    public class Computer
    {
        public string Name { get; set; }
        public List<Task> taskList;
        public Task currentTask;
        public int QuantityOfTasks { set; get; } = 0;
        public bool IsReady { private set; get; } = true;


        public Computer(string name)
        {
            Name = name;
            taskList = new List<Task>();
        }

        public static bool operator ==(Computer obj1, Computer obj2)
        {
            if (obj1 is null && obj2 is null)
            {
                return true;
            }
            else if (obj1 is null && !(obj2 is null) || !(obj1 is null) && obj2 is null)
            {
                return false;
            }
            else if (obj1.taskList.Count == obj2.taskList.Count && obj1.IsReady == obj2.IsReady)
            {
				foreach (var item in obj1.taskList)
				{
					if (obj2.taskList.Find(x => x.Name == item.Name) is null)
					{
						return false;
					}
				}
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Computer obj1, Computer obj2)
        {
            if (obj1 is null && obj2 is null)
            {
                return false;
            }
            else if (obj1 is null && !(obj2 is null) || !(obj1 is null) && obj2 is null)
            {
                return true;
            }
            else if (obj1.taskList != obj2.taskList || obj1.IsReady != obj2.IsReady)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ExecuteTask(Task task, Form1 form)
        {
            currentTask = task;
            IsReady = false;

            TimerCallback tm = new TimerCallback(EndTask);
            Timer timer = new Timer(tm, form, (int)currentTask.ExecutionTimeInSeconds * 1000, -1);
        }

        private void EndTask(object obj)
        {
            currentTask.CompletionTime = new DateTime();
            currentTask = null;
            IsReady = true;
            Form1 mainForm = obj as Form1;
            mainForm.BeginInvoke(new Action(() => mainForm.TaskListBox.Refresh()));
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
