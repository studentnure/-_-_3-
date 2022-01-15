using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZ_Lab6.Factory
{
    [Serializable]
    public class ReportBase
    {
        public DateTime TimeOfExecution { get; set; }
        public ReportBase()
        {
            TimeOfExecution = DateTime.Now;
        }
    }
}
