using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPZ_Lab4
{
    public partial class Form1 : Form
    {
        private enum SequenceStatus
        {
            increasing,
            decreasing,
            unknown
        }

        private OpenFileDialog openFileDialog;
        private string dataString;
        private List<string> numbers;
        private List<double> doubleNumbers;
        private List<int> sequencesLength;
        private string resultFileName;

        public Form1()
        {
            InitializeComponent();

            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt file (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = ".";

            numbers = new List<string>();
            doubleNumbers = new List<double>();
            sequencesLength = new List<int>();
        }



        private void LoadFileButtonOnClick(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            using (StreamReader sr = new StreamReader(openFileDialog.FileName))
            {
                dataString = sr.ReadToEnd();
            }
            inputFileTextBox.Text = dataString;
        }

        private void GenerateSequenceFileButtonOnClick(object sender, EventArgs e)
        {
            GenerateSequenceFile();
            SetResultTextBoxData();
        }

        private void SetResultTextBoxData()
        {
            using (StreamReader sr = new StreamReader(resultFileName))
            {
                resultTextBox.Text = sr.ReadToEnd();
            }
        }

        private void GenerateSequenceFile()
        {
            numbers.AddRange(dataString.Split());

            foreach (string number in numbers)
            {
                doubleNumbers.Add(double.Parse(number));
            }

            SequenceStatus sequenceStatus = SequenceStatus.unknown;
            int length = 1;
            for (int j = 1; j < doubleNumbers.Count; j++)
            {
                switch (sequenceStatus)
                {
                    case SequenceStatus.increasing:
                        if (doubleNumbers[j] >= doubleNumbers[j - 1])
                        {
                            length++;
                        }
                        else
                        {
                            sequencesLength.Add(length);
                            j--;
                            sequenceStatus = SequenceStatus.unknown;
                            length = 1;
                        }
                        break;
                    case SequenceStatus.decreasing:
                        if (doubleNumbers[j] <= doubleNumbers[j - 1])
                        {
                            length++;
                        }
                        else
                        {
                            sequencesLength.Add(length);
                            j--;
                            sequenceStatus = SequenceStatus.unknown;
                            length = 1;
                        }
                        break;
                    case SequenceStatus.unknown:
                        if (doubleNumbers[j] > doubleNumbers[j - 1])
                        {
                            sequenceStatus = SequenceStatus.increasing;
                            length++;
                        }
                        else if (doubleNumbers[j] < doubleNumbers[j - 1])
                        {
                            sequenceStatus = SequenceStatus.decreasing;
                            length++;
                        }
                        else
                        {
                            length++;
                        }
                        break;
                    default:
                        break;
                }
                if (j == doubleNumbers.Count - 1)
                {
                    sequencesLength.Add(length);
                }
            }

            resultFileName = Path.GetDirectoryName(openFileDialog.FileName) + "\\" + openFileDialog.SafeFileName.Split('.')[0] + ".out";
            using (StreamWriter sw = new StreamWriter(resultFileName, false))
            {
                foreach (int item in sequencesLength)
                {
                    sw.Write(item + " ");
                }
                numbers.Clear();
                doubleNumbers.Clear();
                sequencesLength.Clear();
            }
        }
    }
}
