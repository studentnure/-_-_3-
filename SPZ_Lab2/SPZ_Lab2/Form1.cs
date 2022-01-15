using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace SPZ_Lab2
{
	public partial class UniversityForm : Form
	{
		List<University> list = new List<University>();

		public UniversityForm()
		{
			InitializeComponent();
			
			list.Add(new University("ХНУРЭ", 8, 100, 500, 200, 250, 150));
			list.Add(new University("ХНЭУ", 6, 80, 6543, 153, 132, 234));
			list.Add(new University(list[0]));
			list[2] += list[1];

			foreach (var item in list)
			{
				UniversitycomboBox.Items.Add(item.Name);
				comboBox5.Items.Add(item.Name);
				comboBox6.Items.Add(item.Name);
			}

			comboBox2.Items.Add("Add students");
			comboBox2.Items.Add("Add lecture halls");
			comboBox2.Items.Add("Add laboratories");
			comboBox2.Items.Add("Add teachers");
			comboBox2.Items.Add("Add staff");
			comboBox2.Items.Add("Add faculties");

			comboBox2.Items.Add("Remove students");
			comboBox2.Items.Add("Remove lecture halls");
			comboBox2.Items.Add("Remove laboratories");
			comboBox2.Items.Add("Remove teachers");
			comboBox2.Items.Add("Remove staff");
			comboBox2.Items.Add("Remove faculties");
		}


		private void RunButton_Click(object sender, EventArgs e)
		{
			int universityIndex = UniversitycomboBox.SelectedIndex;
			int actionIndex = comboBox2.SelectedIndex;
			int value = (int)numericUpDown1.Value;

			try
			{
				switch (actionIndex)
				{
					case 0: list[universityIndex].AddStudents(value); break;
					case 1: list[universityIndex].AddLectureHalls(value); break;
					case 2: list[universityIndex].AddLaboratories(value); break;
					case 3: list[universityIndex].AddTeachers(value); break;
					case 4: list[universityIndex].AddStaff(value); break;
					case 5: list[universityIndex].AddFaculties(value); break;
					case 6: list[universityIndex].RemoveStudents(value); break;
					case 7: list[universityIndex].RemoveLectureHalls(value); break;
					case 8: list[universityIndex].RemoveLaboratories(value); break;
					case 9: list[universityIndex].RemoveTeachers(value); break;
					case 10: list[universityIndex].RemoveStaff(value); break;
					case 11: list[universityIndex].RemoveFaculties(value); break;
				}
			}
			catch(Exception ex)
			{
                MessageBox.Show(ex.Message, "Error");
			}

			UpdateTextBox(list[UniversitycomboBox.SelectedIndex]);
		}

		private void UniversityComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateTextBox(list[UniversitycomboBox.SelectedIndex]);
			if (comboBox2.SelectedIndex != -1)
				runButton.Enabled = true;
		}

		private void ActionComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (UniversitycomboBox.SelectedIndex != -1)
				runButton.Enabled = true;
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			University temp = new University();
			temp = list[comboBox5.SelectedIndex] + list[comboBox6.SelectedIndex];
			UpdateTextBox(temp);
		}

		public void UpdateTextBox(University obj)
		{
			textBox1.Text = string.Format("University: {0}\r\nFaculties: {1}\r\nLaboratories: {2}\r\nStudents: {3}\r\nLecture halls: {4}\r\nTeachers: {5}\r\nStaff: {6}", 
				obj.Name, obj[0], obj[1], obj[2], obj[3], obj[4], obj[5]);
		}

		private void CompareButton_Click(object sender, EventArgs e)
		{
			string textString = "Expression (" + list[comboBox5.SelectedIndex].Name + " == " + list[comboBox6.SelectedIndex].Name + ") is ";
			bool isEqual = Equals(list[comboBox5.SelectedIndex], list[comboBox6.SelectedIndex]);
			textString += isEqual.ToString();
			MessageBox.Show(textString, "Compare");
		}

		private void СomboBox6_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateTextBox(list[comboBox6.SelectedIndex]);
			if (comboBox5.SelectedIndex != -1)
			{
				addButton.Enabled = true;
				compareButton.Enabled = true;
			}
		}

		private void СomboBox5_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateTextBox(list[comboBox5.SelectedIndex]);
			if (comboBox6.SelectedIndex != -1)
			{
				addButton.Enabled = true;
				compareButton.Enabled = true;
			}
		}
	}
}
