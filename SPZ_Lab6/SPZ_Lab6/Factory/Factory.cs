using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SPZ_Lab6.Factory
{
    class Factory
    {
        public int MaterialQuantity { get; set; }
        public int ProductQuantity { get; set; }
        public int MoneyQuantity { get; set; }
        public int Warehouse { get; set; } = 0;

        public int MaterialCost { get; set; } = 500;
        public int ProductCost { get; set; } = 1500;
        public int TaxCost { get; set; } = 200;

        public int BuyingTime { get; set; } = 1;
        public int ManufacturingTime { get; set; } = 3;
        public int SellingTime { get; set; } = 1;

        public List<BuyReport> buyReportList;
        public List<ManufacturingReport> manufacturingReportList;
        public List<SellReport> sellReportList;

        private object _materialLocker, _productLocker, _moneyLocker, _warehouseLocker;

        private Form1 _form;

        public Factory(Form1 form, int material, int product, int money)
        {
            MaterialQuantity = material;
            ProductQuantity = product;
            MoneyQuantity = money;
            _form = form;

            _materialLocker = new object();
            _productLocker = new object();
            _moneyLocker = new object();
            _warehouseLocker = new object();

            buyReportList = new List<BuyReport>();
            manufacturingReportList = new List<ManufacturingReport>();
            sellReportList = new List<SellReport>();
        }

        public void StartBuyMaterialsThread(int quantity)
        {
            if (quantity <= 0)
            {
                return;
            }
            //if ((Warehouse + quantity * 5) > 100)
            //{
            //    MessageBox.Show($"There is not so much place to buy {quantity} items of material");
            //    return;
            //}
            else if (MoneyQuantity < quantity * MaterialCost)
            {
                MessageBox.Show($"You have not enough money to buy {quantity} items of material");
                return;
            }
            Thread buyingThread = new Thread(new ParameterizedThreadStart(BuyMaterial));

            _form.buyButton.Enabled = false;

            buyingThread.Start(quantity);
        }

        public void BuyMaterial(object quantity)
        {
			_form.BeginInvoke(new Action(() => _form.fullBuyProgressBar.Minimum = 0));
			_form.BeginInvoke(new Action(() => _form.fullBuyProgressBar.Maximum = (int)quantity * 10));
			_form.BeginInvoke(new Action(() => _form.fullBuyProgressBar.Step = 1));

			for (int i = 0; i < (int)quantity; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Thread.Sleep(BuyingTime * 100);
                    _form.BeginInvoke(new Action(() => _form.fullBuyProgressBar.PerformStep()));
                }

                lock (_moneyLocker)
                {
                    MoneyQuantity -= MaterialCost;
                    _form.BeginInvoke(new Action(() => _form.moneyLabel.Text = MoneyQuantity.ToString()));
                }

                lock (_materialLocker)
                {
                    MaterialQuantity++;
                    _form.BeginInvoke(new Action(() => _form.materialLabel.Text = MaterialQuantity.ToString()));
                }

                lock (_warehouseLocker)
                {
                    Warehouse += 5;
                    _form.BeginInvoke(new Action(() => _form.warehouseLabel.Text = Warehouse.ToString()));
                }
            }
            _form.BeginInvoke(new Action(() => _form.fullBuyProgressBar.Value = 0));
            _form.BeginInvoke(new Action(() => _form.buyButton.Enabled = true));
            buyReportList.Add(new BuyReport()
            {
                MaterialQuantity = (int)quantity,
                MoneyQuantity = (int)quantity * MaterialCost
            });
            XmlSerializer formatter = new XmlSerializer(typeof(List<BuyReport>));
            using (FileStream fs = new FileStream("buy_reports.xml", FileMode.Create))
            {
                formatter.Serialize(fs, buyReportList);
            }
        }

        public void StartManufacturingThread(int quantity)
        {
            if (quantity <= 0)
            {
                return;
            }
            if (quantity > MaterialQuantity)
            {
                MessageBox.Show($"There is not so much material to manufature {quantity} items of product");
                return;
            }
            else if (MoneyQuantity < quantity * TaxCost)
            {
                MessageBox.Show($"You have not enough money to manufacture {quantity} items of product");
                return;
            }
            Thread manufactueThread = new Thread(new ParameterizedThreadStart(ManufactureProduct));

            _form.manufatureButton.Enabled = false;

            manufactueThread.Start(quantity);
        }

        public void ManufactureProduct(object quantity)
        {
            _form.BeginInvoke(new Action(() => _form.fullManufactureProgressBar.Minimum = 0));
            _form.BeginInvoke(new Action(() => _form.fullManufactureProgressBar.Maximum = (int)quantity * 10));
            _form.BeginInvoke(new Action(() => _form.fullManufactureProgressBar.Step = 1));
            for (int i = 0; i < (int)quantity; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Thread.Sleep(ManufacturingTime * 100);
                    _form.BeginInvoke(new Action(() => _form.fullManufactureProgressBar.PerformStep()));
                }

                lock (_moneyLocker)
                {
                    MoneyQuantity -= TaxCost;
                    _form.BeginInvoke(new Action(() => _form.moneyLabel.Text = MoneyQuantity.ToString()));
                }

                lock (_materialLocker)
                {
                    MaterialQuantity--;
                    _form.BeginInvoke(new Action(() => _form.materialLabel.Text = MaterialQuantity.ToString()));
                }

                lock (_productLocker)
                {
                    ProductQuantity++;
                    _form.BeginInvoke(new Action(() => _form.productLabel.Text = ProductQuantity.ToString()));
                }
            }
            _form.BeginInvoke(new Action(() => _form.fullManufactureProgressBar.Value = 0));
            _form.BeginInvoke(new Action(() => _form.manufatureButton.Enabled = true));
            manufacturingReportList.Add(new ManufacturingReport()
            {
                ProductQuantity = (int)quantity,
                MoneyQuantity = TaxCost * (int)quantity
            });
            XmlSerializer formatter = new XmlSerializer(typeof(List<ManufacturingReport>));
            using (FileStream fs = new FileStream("manufacturing_reports.xml", FileMode.Create))
            {
                formatter.Serialize(fs, manufacturingReportList);
            }
        }

        public void StartSellingThread(int quantity)
        {
            if (quantity <= 0)
            {
                return;
            }
            if (quantity > ProductQuantity)
            {
                MessageBox.Show($"There is no {quantity} product to sell");
                return;
            }
            Thread sellingThread = new Thread(new ParameterizedThreadStart(SellProduct));

            _form.sellButton.Enabled = false;

            sellingThread.Start(quantity);
        }

        public void SellProduct(object quantity)
        {
            _form.BeginInvoke(new Action(() => _form.fullSellProgressBar.Minimum = 0));
            _form.BeginInvoke(new Action(() => _form.fullSellProgressBar.Maximum = (int)quantity * 10));
            _form.BeginInvoke(new Action(() => _form.fullSellProgressBar.Step = 1));
            for (int i = 0; i < (int)quantity; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Thread.Sleep(SellingTime * 100);
                    _form.BeginInvoke(new Action(() => _form.fullSellProgressBar.PerformStep()));
                }

                lock (_moneyLocker)
                {
                    MoneyQuantity += ProductCost;
                    _form.BeginInvoke(new Action(() => _form.moneyLabel.Text = MoneyQuantity.ToString()));
                }

                lock (_productLocker)
                {
                    ProductQuantity--;
                    _form.BeginInvoke(new Action(() => _form.productLabel.Text = ProductQuantity.ToString()));
                }

                lock (_warehouseLocker)
                {
                    Warehouse -= 5;
                    _form.BeginInvoke(new Action(() => _form.warehouseLabel.Text = Warehouse.ToString()));
                }
            }
            _form.BeginInvoke(new Action(() => _form.fullSellProgressBar.Value = 0));
            _form.BeginInvoke(new Action(() => _form.sellButton.Enabled = true));
            sellReportList.Add(new SellReport()
            {
                ProductQuantity = (int)quantity,
                MoneyQuantity = (int)quantity * ProductCost
            });
            XmlSerializer formatter = new XmlSerializer(typeof(List<SellReport>));
            using (FileStream fs = new FileStream("sell_reports.xml", FileMode.Create))
            {
                formatter.Serialize(fs, sellReportList);
            }
        }
    }
}
