using SPZ_Lab6.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SPZ_Lab6
{
    public partial class Reports : Form
    {
        public List<BuyReport> buyReportsList;
        public List<ManufacturingReport> manufacturingReportsList;
        public List<SellReport> sellReportsList;
        private BindingSource _bs;

        public Reports()
        {
            InitializeComponent();
            buyReportsList = new List<BuyReport>();
            manufacturingReportsList = new List<ManufacturingReport>();
            sellReportsList = new List<SellReport>();
            _bs = new BindingSource();
        }

        private void ReportsOnLoad(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<BuyReport>));
            using (FileStream fs = new FileStream("buy_reports.xml", FileMode.OpenOrCreate))
            {
                if (fs.Length > 0)
                {
                    buyReportsList = (List<BuyReport>)formatter.Deserialize(fs);
                } 
            }

            formatter = new XmlSerializer(typeof(List<ManufacturingReport>));
            using (FileStream fs = new FileStream("manufacturing_reports.xml", FileMode.OpenOrCreate))
            {
                if (fs.Length > 0)
                {
                    manufacturingReportsList = (List<ManufacturingReport>)formatter.Deserialize(fs);
                }
            }

            formatter = new XmlSerializer(typeof(List<SellReport>));
            using (FileStream fs = new FileStream("sell_reports.xml", FileMode.OpenOrCreate))
            {
                if (fs.Length > 0)
                {
                    sellReportsList = (List<SellReport>)formatter.Deserialize(fs);
                }
            }

            dataGridView1.DataSource = buyReportsList;
            dataGridView2.DataSource = manufacturingReportsList;
            dataGridView3.DataSource = sellReportsList;
        }
    }
}
