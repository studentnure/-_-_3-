namespace Lab3
{
    partial class AddTaskForm
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
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.execTimeTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addInfoTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textBox1
            // 
            this.nameTextbox.Location = new System.Drawing.Point(13, 26);
            this.nameTextbox.Name = "textBox1";
            this.nameTextbox.Size = new System.Drawing.Size(100, 20);
            this.nameTextbox.TabIndex = 1;
            // 
            // textBox2
            // 
            this.execTimeTextbox.Location = new System.Drawing.Point(13, 74);
            this.execTimeTextbox.Name = "textBox2";
            this.execTimeTextbox.Size = new System.Drawing.Size(100, 20);
            this.execTimeTextbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Execution time";
            // 
            // textBox3
            // 
            this.addInfoTextbox.Location = new System.Drawing.Point(13, 121);
            this.addInfoTextbox.Name = "textBox3";
            this.addInfoTextbox.Size = new System.Drawing.Size(100, 20);
            this.addInfoTextbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Additional info";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SubmitButtonCLick);
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(128, 199);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addInfoTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.execTimeTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.label1);
            this.Name = "AddTaskForm";
            this.Text = "AddTaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox execTimeTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addInfoTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}