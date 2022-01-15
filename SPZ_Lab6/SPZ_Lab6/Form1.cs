using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPZ_Lab6.Factory;

namespace SPZ_Lab6
{
    public partial class Form1 : Form
    {
        Factory.Factory factory;
        public Form1()
        {
            InitializeComponent();
            factory = new Factory.Factory(this, 0, 0, 1000000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            materialLabel.Text = factory.MaterialQuantity.ToString();
            productLabel.Text = factory.ProductQuantity.ToString();
            moneyLabel.Text = factory.MoneyQuantity.ToString();
            warehouseLabel.Text = factory.Warehouse.ToString();
        }

        private void BuyButtonOnClick(object sender, EventArgs e)
        {
            factory.StartBuyMaterialsThread((int)materialsNumericUpDown.Value);
        }

        private void ManufatureButtonOnClick(object sender, EventArgs e)
        {
            factory.StartManufacturingThread((int)productNumericUpDown.Value);
        }

        private void SellButtonOnClick(object sender, EventArgs e)
        {
            factory.StartSellingThread((int)sellNumericUpDown.Value);
        }

        private void ReportsButtonOnClick(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.ShowDialog();
            reports.Close();
        }
    }
}
