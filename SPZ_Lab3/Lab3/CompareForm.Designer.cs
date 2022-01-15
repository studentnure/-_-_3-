namespace Lab3
{
    partial class CompareForm
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
            this.firstCompListbox = new System.Windows.Forms.ListBox();
            this.secondCompListbox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstCompListbox
            // 
            this.firstCompListbox.FormattingEnabled = true;
            this.firstCompListbox.Location = new System.Drawing.Point(12, 13);
            this.firstCompListbox.Name = "firstCompListbox";
            this.firstCompListbox.Size = new System.Drawing.Size(211, 147);
            this.firstCompListbox.TabIndex = 0;
            // 
            // secondCompListbox
            // 
            this.secondCompListbox.FormattingEnabled = true;
            this.secondCompListbox.Location = new System.Drawing.Point(242, 13);
            this.secondCompListbox.Name = "secondCompListbox";
            this.secondCompListbox.Size = new System.Drawing.Size(211, 147);
            this.secondCompListbox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(441, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Compare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CompareButtonClick);
            // 
            // CompareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 223);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.secondCompListbox);
            this.Controls.Add(this.firstCompListbox);
            this.Name = "CompareForm";
            this.Text = "CompareForm";
            this.Load += new System.EventHandler(this.CompareFormLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox firstCompListbox;
        private System.Windows.Forms.ListBox secondCompListbox;
        private System.Windows.Forms.Button button1;
    }
}