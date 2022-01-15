namespace Lab3
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
            this.components = new System.ComponentModel.Container();
            this.computersListbox = new System.Windows.Forms.ListBox();
            this.computerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskListbox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btSetWifi = new System.Windows.Forms.Button();
            this.btRemoveWifi = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.computerManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.computerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // computersListbox
            // 
            this.computersListbox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.computerBindingSource, "Name", true));
            this.computersListbox.FormattingEnabled = true;
            this.computersListbox.Location = new System.Drawing.Point(12, 33);
            this.computersListbox.Name = "computersListbox";
            this.computersListbox.Size = new System.Drawing.Size(342, 316);
            this.computersListbox.TabIndex = 0;
            this.computersListbox.SelectedIndexChanged += new System.EventHandler(this.ComputerListSelectedIndexChanged);
            this.computersListbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ComputerListMouseDoubleClick);
            // 
            // computerBindingSource
            // 
            this.computerBindingSource.DataSource = typeof(Lab3.Computer);
            // 
            // taskListbox
            // 
            this.taskListbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.taskListbox.FormattingEnabled = true;
            this.taskListbox.Location = new System.Drawing.Point(372, 33);
            this.taskListbox.Name = "taskListbox";
            this.taskListbox.Size = new System.Drawing.Size(339, 316);
            this.taskListbox.TabIndex = 1;
            this.taskListbox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.taskListbox_DrawItem);
            this.taskListbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TaskListboxMouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add PC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddComputerButtonClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Remove PC";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.RemoveComputerButtonClick);
            // 
            // btSetWifi
            // 
            this.btSetWifi.Location = new System.Drawing.Point(15, 398);
            this.btSetWifi.Name = "btSetWifi";
            this.btSetWifi.Size = new System.Drawing.Size(157, 32);
            this.btSetWifi.TabIndex = 4;
            this.btSetWifi.Text = "Set Wi-Fi";
            this.btSetWifi.UseVisualStyleBackColor = true;
            this.btSetWifi.Click += new System.EventHandler(this.SetWifiButtonClick);
            // 
            // btRemoveWifi
            // 
            this.btRemoveWifi.Enabled = false;
            this.btRemoveWifi.Location = new System.Drawing.Point(197, 398);
            this.btRemoveWifi.Name = "btRemoveWifi";
            this.btRemoveWifi.Size = new System.Drawing.Size(157, 32);
            this.btRemoveWifi.TabIndex = 5;
            this.btRemoveWifi.Text = "Remove Wi-Fi";
            this.btRemoveWifi.UseVisualStyleBackColor = true;
            this.btRemoveWifi.Click += new System.EventHandler(this.RemoveWifiButtonClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(372, 360);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 32);
            this.button5.TabIndex = 6;
            this.button5.Text = "Assign task";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.AssignTaskButtonClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(557, 360);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(154, 32);
            this.button6.TabIndex = 7;
            this.button6.Text = "Remove task";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.RemoveTaskButtonClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(467, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 32);
            this.button3.TabIndex = 8;
            this.button3.Text = "Compare computers";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.CompareButtonClick);
            // 
            // computerManagerBindingSource
            // 
            this.computerManagerBindingSource.DataSource = typeof(Lab3.ComputerManager);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btRemoveWifi);
            this.Controls.Add(this.btSetWifi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.taskListbox);
            this.Controls.Add(this.computersListbox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.computerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerManagerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox computersListbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btSetWifi;
        private System.Windows.Forms.Button btRemoveWifi;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource computerBindingSource;
        private System.Windows.Forms.BindingSource computerManagerBindingSource;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.ListBox taskListbox;
    }
}

