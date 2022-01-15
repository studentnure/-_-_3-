using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace lb7
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        private List<Subject> subjects = new List<Subject>();
        private List<Mark> marks = new List<Mark>();

        DataSet dsStudents = new DataSet();
        DataSet dsSubjects= new DataSet();
        DataSet dsMarks = new DataSet();

        BindingSource bsStudents = new BindingSource();
        BindingSource bsSubjects = new BindingSource();
        BindingSource bsMarks = new BindingSource();

        List<String> itemsOfWorksheet = new List<String>();

        static string filePath = "C:\\Users\\qwert\\source\\repos\\SPZ_Lab7\\lb7\\bin\\Debug\\students.xlsx";

        string connString = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0 Xml;HDR=YES;Persist Security Info=False;""", filePath);
        public Form1()
        {
            InitializeComponent();

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();

                DataTable activityDataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                if (activityDataTable != null)
                {
                    string worksheetName;
                    for (int cnt = 0; cnt < activityDataTable.Rows.Count; cnt++)
                    {
                        worksheetName = activityDataTable.Rows[cnt]["TABLE_NAME"].ToString();

                        if (worksheetName.Contains('\''))
                        {
                            worksheetName = worksheetName.Replace('\'', ' ').Trim();
                        }
                        if (worksheetName.Trim().EndsWith("$"))
                            itemsOfWorksheet.Add(worksheetName);
                    }
                }

                OleDbDataAdapter objDA = new OleDbDataAdapter
                (String.Format("select Name, Surname from [{0}]", itemsOfWorksheet[1]), conn);
                objDA.Fill(dsStudents);
                bsStudents.DataSource = dsStudents.Tables[0];

                objDA = new OleDbDataAdapter
                (String.Format("select Name from [{0}]", itemsOfWorksheet[2]), conn);
                dsSubjects = new DataSet();
                objDA.Fill(dsSubjects);
                bsSubjects.DataSource = dsSubjects.Tables[0];

                objDA = new OleDbDataAdapter
                (String.Format("select MarkData, Student, Subject from [{0}]", itemsOfWorksheet[0]), conn);
                dsMarks = new DataSet();
                objDA.Fill(dsMarks);
                bsMarks.DataSource = dsMarks.Tables[0];
                conn.Close();
            }

            dgStudents.DataSource = bsStudents;
            dgSubjects.DataSource = bsSubjects;
            dgMarks.DataSource = bsMarks;

        }

        private void btAddMark_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = String.Format(@"Insert into [{0}] (MarkData, Student, Subject) 
            VALUES ('{1}', '{2}', '{3}');", itemsOfWorksheet[0], (int)nMark.Value, dgStudents.SelectedCells[0].Value.ToString(), dgSubjects.SelectedCells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                OleDbDataAdapter objDA = new OleDbDataAdapter
                (String.Format("select MarkData, Student, Subject from [{0}]", itemsOfWorksheet[0]), conn);
                dsMarks = new DataSet();
                objDA.Fill(dsMarks);
                bsMarks.DataSource = dsMarks.Tables[0];
                conn.Close();
            }
            bsMarks.ResetBindings(true);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = Missing.Value;

            try { 
                xlApp = new Excel.Application();
                xlApp.Visible = true;
                xlWorkBook = xlApp.Workbooks.Open(filePath, 0, false, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                for (int i = 0; i <= dgStudents.RowCount - 1; i++)
                {
                    for (int j = 0; j <= dgStudents.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dgStudents[j, i];
                        xlWorkSheet.Cells[i + 2, j + 1] = cell.Value;
                    }
                }

                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(2);

                for (int i = 0; i <= dgSubjects.RowCount - 1; i++)
                {
                    for (int j = 0; j <= dgSubjects.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dgSubjects[j, i];
                        xlWorkSheet.Cells[i + 2, j + 1] = cell.Value;
                    }
                }

                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(3);

                for (int i = 0; i < dgMarks.RowCount - 1; i++)
                {
                    for (int j = 0; j <= dgMarks.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dgMarks[j, i];
                        xlWorkSheet.Cells[i + 2, j + 1] = cell.Value.ToString();
                    }
                }
                xlWorkBook.SaveAs(filePath, Excel.XlFileFormat.xlWorkbookDefault, misValue, misValue, false, false, Excel.XlSaveAsAccessMode.xlNoChange, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
