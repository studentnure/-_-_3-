using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Lab5_3
{
    public partial class QueryForm : Form
    {
        private Form1 _parentForm;

        public string SubjectName { get; set; }

        private Dictionary<string, int> result;

        ColumnHeader nameHeader;
        ColumnHeader gradeHeader;

        public QueryForm()
        {
            InitializeComponent();
            resultListView.View = View.Details;
            nameHeader = new ColumnHeader()
            {
                Text = "Name",
                Width = 150
            };
            gradeHeader = new ColumnHeader()
            {
                Text = "Grade",
                Width = 150
            };
            resultListView.Columns.AddRange(new ColumnHeader[] { nameHeader, gradeHeader });
        }

        private void FindButtonOnClick(object sender, EventArgs e)
        {
            _parentForm = Owner as Form1;
            result = GetResultsBySubjectName(subjectNameTextBox.Text);
            resultListView.Clear();
            resultListView.Columns.AddRange(new ColumnHeader[] { nameHeader, gradeHeader });
            foreach (var item in result)
            {
                ListViewItem header = new ListViewItem(new string[] { item.Key, item.Value.ToString() });
                resultListView.Items.Add(header);
            }
        }

        private Dictionary<string, int> GetResultsBySubjectName(string subjName)
        {
            var students = from student in _parentForm.studentsList
                         where student.subjectsList.Exists(x => x.Name == subjName)
                         select student;
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (Student student in students)
            {
                for (int i = 0; i < student.subjectsList.Count; i++)
                {
                    if (student.subjectsList[i].Name == subjName)
                    {
                        result.Add(student.Name, student.subjectsList[i].Grade);
                        break;
                    }
                }
            }
            return result;
        }
    }
}
