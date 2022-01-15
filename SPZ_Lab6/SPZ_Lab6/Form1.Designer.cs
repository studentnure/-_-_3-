namespace SPZ_Lab6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.materialsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.productNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sellNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.buyButton = new System.Windows.Forms.Button();
            this.manufatureButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.fullBuyProgressBar = new System.Windows.Forms.ProgressBar();
            this.fullManufactureProgressBar = new System.Windows.Forms.ProgressBar();
            this.fullSellProgressBar = new System.Windows.Forms.ProgressBar();
            this.materialLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.warehouseLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.materialsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Factory state";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Raw materials:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Money:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Warehouse fill(%):";
            // 
            // materialsNumericUpDown
            // 
            this.materialsNumericUpDown.Location = new System.Drawing.Point(12, 187);
            this.materialsNumericUpDown.Name = "materialsNumericUpDown";
            this.materialsNumericUpDown.Size = new System.Drawing.Size(53, 20);
            this.materialsNumericUpDown.TabIndex = 5;
            // 
            // productNumericUpDown
            // 
            this.productNumericUpDown.Location = new System.Drawing.Point(12, 239);
            this.productNumericUpDown.Name = "productNumericUpDown";
            this.productNumericUpDown.Size = new System.Drawing.Size(53, 20);
            this.productNumericUpDown.TabIndex = 6;
            // 
            // sellNumericUpDown
            // 
            this.sellNumericUpDown.Location = new System.Drawing.Point(12, 291);
            this.sellNumericUpDown.Name = "sellNumericUpDown";
            this.sellNumericUpDown.Size = new System.Drawing.Size(53, 20);
            this.sellNumericUpDown.TabIndex = 7;
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(71, 187);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(216, 20);
            this.buyButton.TabIndex = 8;
            this.buyButton.Text = "Buy materials";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.BuyButtonOnClick);
            // 
            // manufatureButton
            // 
            this.manufatureButton.Location = new System.Drawing.Point(71, 239);
            this.manufatureButton.Name = "manufatureButton";
            this.manufatureButton.Size = new System.Drawing.Size(216, 20);
            this.manufatureButton.TabIndex = 9;
            this.manufatureButton.Text = "Make product";
            this.manufatureButton.UseVisualStyleBackColor = true;
            this.manufatureButton.Click += new System.EventHandler(this.ManufatureButtonOnClick);
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(71, 291);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(216, 20);
            this.sellButton.TabIndex = 10;
            this.sellButton.Text = "Sell product";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.SellButtonOnClick);
            // 
            // fullBuyProgressBar
            // 
            this.fullBuyProgressBar.Location = new System.Drawing.Point(12, 213);
            this.fullBuyProgressBar.Name = "fullBuyProgressBar";
            this.fullBuyProgressBar.Size = new System.Drawing.Size(275, 20);
            this.fullBuyProgressBar.TabIndex = 11;
            // 
            // fullManufactureProgressBar
            // 
            this.fullManufactureProgressBar.Location = new System.Drawing.Point(12, 265);
            this.fullManufactureProgressBar.Name = "fullManufactureProgressBar";
            this.fullManufactureProgressBar.Size = new System.Drawing.Size(275, 20);
            this.fullManufactureProgressBar.TabIndex = 13;
            // 
            // fullSellProgressBar
            // 
            this.fullSellProgressBar.Location = new System.Drawing.Point(12, 317);
            this.fullSellProgressBar.Name = "fullSellProgressBar";
            this.fullSellProgressBar.Size = new System.Drawing.Size(275, 20);
            this.fullSellProgressBar.TabIndex = 15;
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialLabel.Location = new System.Drawing.Point(149, 47);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(20, 24);
            this.materialLabel.TabIndex = 17;
            this.materialLabel.Text = "0";
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productLabel.Location = new System.Drawing.Point(98, 82);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(20, 24);
            this.productLabel.TabIndex = 18;
            this.productLabel.Text = "0";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moneyLabel.Location = new System.Drawing.Point(91, 116);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(20, 24);
            this.moneyLabel.TabIndex = 19;
            this.moneyLabel.Text = "0";
            // 
            // warehouseLabel
            // 
            this.warehouseLabel.AutoSize = true;
            this.warehouseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warehouseLabel.Location = new System.Drawing.Point(179, 150);
            this.warehouseLabel.Name = "warehouseLabel";
            this.warehouseLabel.Size = new System.Drawing.Size(20, 24);
            this.warehouseLabel.TabIndex = 20;
            this.warehouseLabel.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Reports";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ReportsButtonOnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 378);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.warehouseLabel);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.fullSellProgressBar);
            this.Controls.Add(this.fullManufactureProgressBar);
            this.Controls.Add(this.fullBuyProgressBar);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.manufatureButton);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.sellNumericUpDown);
            this.Controls.Add(this.productNumericUpDown);
            this.Controls.Add(this.materialsNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materialsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown materialsNumericUpDown;
        private System.Windows.Forms.NumericUpDown productNumericUpDown;
        private System.Windows.Forms.NumericUpDown sellNumericUpDown;
        public System.Windows.Forms.Button buyButton;
        public System.Windows.Forms.ProgressBar fullBuyProgressBar;
        public System.Windows.Forms.Button manufatureButton;
        public System.Windows.Forms.ProgressBar fullManufactureProgressBar;
        public System.Windows.Forms.Button sellButton;
        public System.Windows.Forms.ProgressBar fullSellProgressBar;
        public System.Windows.Forms.Label materialLabel;
        public System.Windows.Forms.Label productLabel;
        public System.Windows.Forms.Label moneyLabel;
        public System.Windows.Forms.Label warehouseLabel;
        private System.Windows.Forms.Button button1;
    }
}

