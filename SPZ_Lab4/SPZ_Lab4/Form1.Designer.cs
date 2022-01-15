namespace SPZ_Lab4
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
			this.button1 = new System.Windows.Forms.Button();
			this.inputFileTextBox = new System.Windows.Forms.RichTextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.resultTextBox = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 13);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(359, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Load file";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.LoadFileButtonOnClick);
			// 
			// inputFileTextBox
			// 
			this.inputFileTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.inputFileTextBox.Location = new System.Drawing.Point(12, 42);
			this.inputFileTextBox.Name = "inputFileTextBox";
			this.inputFileTextBox.Size = new System.Drawing.Size(359, 95);
			this.inputFileTextBox.TabIndex = 2;
			this.inputFileTextBox.Text = "";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 143);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(359, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Generate sequences file";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.GenerateSequenceFileButtonOnClick);
			// 
			// resultTextBox
			// 
			this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.resultTextBox.Location = new System.Drawing.Point(12, 172);
			this.resultTextBox.Name = "resultTextBox";
			this.resultTextBox.Size = new System.Drawing.Size(359, 95);
			this.resultTextBox.TabIndex = 4;
			this.resultTextBox.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(383, 275);
			this.Controls.Add(this.resultTextBox);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.inputFileTextBox);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox inputFileTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox resultTextBox;
    }
}

