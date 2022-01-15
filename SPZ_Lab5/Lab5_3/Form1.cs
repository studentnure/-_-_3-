using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Lab5_3
{
    public partial class Form1 : Form
    {
        public List<Student> studentsList;
        private AddStudentForm addStudentForm;
        private AddSubjectForm addSubjectForm;
        private QueryForm queryForm;

        private BindingSource studentsBS;
        private BindingSource subjectsBS;

		private bool sortedSubjectNames;
		private bool sortedGrades;

		public Form1()
        {
            InitializeComponent();
            studentsList = new List<Student>();

            studentsBS = new BindingSource();
            studentsBS.DataSource = studentsList;
            studentsDataGridView.DataSource = studentsBS;
            studentsDataGridView.Columns["Name"].Width = studentsDataGridView.Width - 40 - 2;
            studentsDataGridView.MultiSelect = false;

            subjectsBS = new BindingSource();
            subjectsGridView.DataSource = subjectsBS;

			sortedGrades = false;
			sortedSubjectNames = false;
		}

        private void AddStudentButtonOnClick(object sender, EventArgs e)
        {
            addStudentForm = new AddStudentForm();
            addStudentForm.ShowDialog();
            if (addStudentForm.DialogResult == DialogResult.OK)
            {
                studentsList.Add(new Student(addStudentForm.StudentName));
                studentsList.Sort();
                if (studentsList.Count == 1)
                {
                    subjectsBS.DataSource = studentsList[0].subjectsList;
                }
                else
                {
                    subjectsBS.DataSource = studentsList[studentsDataGridView.CurrentCell.RowIndex].subjectsList;
                }
            }
            addStudentForm.Close();
            studentsBS.ResetBindings(true);
            subjectsBS.ResetBindings(true);
        }

        private void studentsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            subjectsBS.DataSource = studentsList[studentsDataGridView.CurrentCell.RowIndex].subjectsList;
        }

        private void AddSubjectButtonOnClick(object sender, EventArgs e)
        {
            addSubjectForm = new AddSubjectForm();
            addSubjectForm.ShowDialog();
            if (addSubjectForm.DialogResult == DialogResult.OK && studentsDataGridView.SelectedCells.Count != 0)
            {
                studentsList[studentsDataGridView.CurrentCell.RowIndex].AddNewSubject(addSubjectForm.SubjectName);
                studentsList[studentsDataGridView.CurrentCell.RowIndex].subjectsList.Sort();
            }
            addSubjectForm.Close();
            subjectsBS.ResetBindings(true);
			sortedSubjectNames = true;
        }

        private void RemoveStudentButtonOnClick(object sender, EventArgs e)
        {
            if (studentsDataGridView.SelectedCells.Count == 0)
            {
                return;
            }
            studentsList.RemoveAt(studentsDataGridView.CurrentCell.RowIndex);
            studentsBS.ResetBindings(true);
            if (studentsDataGridView.SelectedCells.Count == 0)
            {
                subjectsBS.DataSource = null;
            }
            else
            {
                subjectsBS.DataSource = studentsList[studentsDataGridView.CurrentCell.RowIndex].subjectsList;
            }
            subjectsBS.ResetBindings(true);
        }

        private void RemoveSubjectButtonOnClick(object sender, EventArgs e)
        {
            if (subjectsGridView.SelectedCells.Count == 0)
            {
                return;
            }
            studentsList[studentsDataGridView.CurrentCell.RowIndex].RemoveSubjectAtIndex(subjectsGridView.CurrentCell.RowIndex);
            subjectsBS.ResetBindings(true);
        }

        private void QueryButtonOnClick(object sender, EventArgs e)
        {
            queryForm = new QueryForm();
            queryForm.Owner = this;

            queryForm.ShowDialog();
        }

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			XmlSerializer formatter = new XmlSerializer(typeof(List<Student>));
			using (FileStream fs = new FileStream("students.xml", FileMode.OpenOrCreate))
			{
				formatter.Serialize(fs, studentsList);
			}
		}

		private void studentsDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			studentsList.Reverse();
			studentsBS.ResetBindings(false);
		}

		private void subjectsGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			switch(e.ColumnIndex)
			{
				case 0:
					sortedGrades = false;
					if (sortedSubjectNames)
					{
						studentsList[studentsDataGridView.CurrentCell.RowIndex].subjectsList.Reverse();
					}
					else
					{
						studentsList[studentsDataGridView.CurrentCell.RowIndex].subjectsList.Sort(Subject.CompareByName);
						sortedSubjectNames = true;
					}
					break;

				case 1:
					sortedSubjectNames = false;
					if (sortedGrades)
					{
						studentsList[studentsDataGridView.CurrentCell.RowIndex].subjectsList.Reverse();
					}
					else
					{
						studentsList[studentsDataGridView.CurrentCell.RowIndex].subjectsList.Sort(Subject.CompareByGrade);
						sortedGrades = true;
					}
					break;

				default:
					break;
			}
			subjectsBS.ResetBindings(true);
		}
	}
}
