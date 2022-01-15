using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZ_Lab6.Factory
{
    [Serializable]
    public class BuyReport : ReportBase
    {
        public int MaterialQuantity { get; set; }
        public int MoneyQuantity { get; set; }
    }
}
