
namespace lb7
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
            this.dgStudents = new System.Windows.Forms.DataGridView();
            this.dgSubjects = new System.Windows.Forms.DataGridView();
            this.dgMarks = new System.Windows.Forms.DataGridView();
            this.btAddMark = new System.Windows.Forms.Button();
            this.nMark = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMark)).BeginInit();
            this.SuspendLayout();
            // 
            // dgStudents
            // 
            this.dgStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgStudents.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudents.Location = new System.Drawing.Point(12, 12);
            this.dgStudents.Name = "dgStudents";
            this.dgStudents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgStudents.Size = new System.Drawing.Size(283, 455);
            this.dgStudents.TabIndex = 0;
            // 
            // dgSubjects
            // 
            this.dgSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSubjects.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSubjects.Location = new System.Drawing.Point(301, 12);
            this.dgSubjects.Name = "dgSubjects";
            this.dgSubjects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgSubjects.Size = new System.Drawing.Size(283, 455);
            this.dgSubjects.TabIndex = 0;
            // 
            // dgMarks
            // 
            this.dgMarks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMarks.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMarks.Location = new System.Drawing.Point(590, 12);
            this.dgMarks.Name = "dgMarks";
            this.dgMarks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgMarks.Size = new System.Drawing.Size(343, 455);
            this.dgMarks.TabIndex = 0;
            // 
            // btAddMark
            // 
            this.btAddMark.Location = new System.Drawing.Point(677, 473);
            this.btAddMark.Name = "btAddMark";
            this.btAddMark.Size = new System.Drawing.Size(190, 61);
            this.btAddMark.TabIndex = 1;
            this.btAddMark.Text = "Додати оцінку";
            this.btAddMark.UseVisualStyleBackColor = true;
            this.btAddMark.Click += new System.EventHandler(this.btAddMark_Click);
            // 
            // nMark
            // 
            this.nMark.Location = new System.Drawing.Point(590, 495);
            this.nMark.Name = "nMark";
            this.nMark.Size = new System.Drawing.Size(53, 20);
            this.nMark.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 550);
            this.Controls.Add(this.nMark);
            this.Controls.Add(this.btAddMark);
            this.Controls.Add(this.dgMarks);
            this.Controls.Add(this.dgSubjects);
            this.Controls.Add(this.dgStudents);
            this.Name = "Form1";
            this.Text = "Дані";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgStudents;
        private System.Windows.Forms.DataGridView dgSubjects;
        private System.Windows.Forms.DataGridView dgMarks;
        private System.Windows.Forms.Button btAddMark;
        private System.Windows.Forms.NumericUpDown nMark;
    }
}

