namespace Lab5_3
{
    partial class QueryForm
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
            this.subjectNameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.resultListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // subjectNameTextBox
            // 
            this.subjectNameTextBox.Location = new System.Drawing.Point(12, 12);
            this.subjectNameTextBox.Name = "subjectNameTextBox";
            this.subjectNameTextBox.Size = new System.Drawing.Size(195, 20);
            this.subjectNameTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.FindButtonOnClick);
            // 
            // listView1
            // 
            this.resultListView.Location = new System.Drawing.Point(12, 38);
            this.resultListView.Name = "listView1";
            this.resultListView.Size = new System.Drawing.Size(337, 341);
            this.resultListView.TabIndex = 3;
            this.resultListView.UseCompatibleStateImageBehavior = false;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 391);
            this.Controls.Add(this.resultListView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.subjectNameTextBox);
            this.Name = "QueryForm";
            this.Text = "QueryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox subjectNameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView resultListView;
    }
}