using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZ_Lab6.Factory
{
    [Serializable]
    public class ManufacturingReport : ReportBase
    {
        public int MoneyQuantity { get; set; }
        public int ProductQuantity { get; set; }
    }
}
