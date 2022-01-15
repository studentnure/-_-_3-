using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class ComputerManager
    {
        private int _workplacesQuantity;
        public List<Computer> computerList;
        public Dictionary<string, Task> fullTaskList;
        public int ComputersQuantity { private set; get; } = 0;
        public int WorkplacesQuantity
        {
            get
            {
                return _workplacesQuantity;
            }
            set
            {
                if (value >= 0)
                {
                    _workplacesQuantity = value;
                }
                else
                {
                    throw new Exception("Number of workspaces should be positive");
                }
            }
        }
        public bool HasRouter { get; set; } = false;
        private string _wifiPassword;

        public ComputerManager(int workplacesQuantity)
        {
            _workplacesQuantity = workplacesQuantity;
            computerList = new List<Computer>();
            fullTaskList = new Dictionary<string, Task>();
        }

        public void AddTaskOnComputer(Computer computer, string taskName)
        {
            Task task = fullTaskList[taskName];
            if (computer.taskList.IndexOf(task) == -1)
            {
                computer.taskList.Add(task);
                computer.QuantityOfTasks++;
            }
            else
            {
                throw new Exception("Task is already assigned to PC");
            }
        }

        public void RemoveTaskOnComputer(Computer computer, string taskName)
        {
            Task task = fullTaskList[taskName];
            if (computer.taskList.Remove(task))
            {
                computer.QuantityOfTasks--;
            } 
           
        }

        public void AddComputer(Computer computer)
        {
            if (ComputersQuantity < WorkplacesQuantity && !(computer is null))
            {
                computerList.Add(computer);
                ComputersQuantity++;
            }
            else
            {
                throw new Exception("ComputersQuantity cant be > WorkplacesQuantity");
            }
        }

        public void RemoveComputer(Computer computer)
        {
            if (!(computer is null))
            {
                computerList.Remove(computer);
                ComputersQuantity--;
            }
            else
            {
                throw new Exception();
            }
        }

        public void InstallRouter(string password)
        {
            HasRouter = true;
            _wifiPassword = password;
        }

        public void RemoveRouter()
        {
            HasRouter = false;
            _wifiPassword = "";
        }

        public void AddTask(Task task)
        {
            if (!fullTaskList.ContainsKey(task.Name) && !(task is null))
            {
                fullTaskList.Add(task.Name, task);
            }
            else
            {
                throw new Exception("Task already exists");
            }
        }

        public void RemoveTask(Task task)
        {
            if (!(task is null))
            {
                fullTaskList.Remove(task.Name);
            }
            else
            {
                throw new Exception();
            }
        }

        public bool AreComputersEqual(int firstCompNumber, int secondCompNumber)
        {
            return computerList[firstCompNumber] == computerList[secondCompNumber];
        }
    }
}
