namespace Lab3
{
    partial class EditTaskForm
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
            this.executionTimeTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addInfoTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // executionTimeTextbox
            // 
            this.executionTimeTextbox.Location = new System.Drawing.Point(12, 26);
            this.executionTimeTextbox.Name = "executionTimeTextbox";
            this.executionTimeTextbox.Size = new System.Drawing.Size(102, 20);
            this.executionTimeTextbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Execution time";
            // 
            // addInfoTextbox
            // 
            this.addInfoTextbox.Location = new System.Drawing.Point(12, 75);
            this.addInfoTextbox.Name = "addInfoTextbox";
            this.addInfoTextbox.Size = new System.Drawing.Size(102, 20);
            this.addInfoTextbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Additional info";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // EditTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(127, 146);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addInfoTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.executionTimeTextbox);
            this.Controls.Add(this.label2);
            this.Name = "EditTaskForm";
            this.Text = "EditTaskForm";
            this.Load += new System.EventHandler(this.EditTaskFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox executionTimeTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addInfoTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}