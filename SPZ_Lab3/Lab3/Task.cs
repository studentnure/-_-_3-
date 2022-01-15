using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab3
{
    public class Task
    {
        private double _executionTimeInSeconds;
        public double ExecutionTimeInSeconds
        {
            get
            {
                return _executionTimeInSeconds;
            }

            set
            {
                if (value >= 0)
                {
                    _executionTimeInSeconds = value;
                }
                else
                {
                    throw new Exception("Time should be positive number");
                }
            }
        }
        public DateTime CompletionTime { set; get; } = default(DateTime);
        public string Name { get; set; }
        public bool IsDone { private set; get; } = false;
        public string AdditionalInfo { get; set; }

        public Task()
        {
            ExecutionTimeInSeconds = 0d;
            Name = "";
            AdditionalInfo = "";
        }

        public Task(double execTime, string name, string additionalInfo)
        {
            ExecutionTimeInSeconds = execTime;
            Name = name;
            AdditionalInfo = additionalInfo;
        }

        public Task(Task obj)
        {
            ExecutionTimeInSeconds = obj.ExecutionTimeInSeconds;
            Name = obj.Name;
            AdditionalInfo = obj.AdditionalInfo;
        }


        public override string ToString()
        {
            return Name;
        }
    }
}
