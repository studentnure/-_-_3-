using System;

namespace SPZ_Lab_1
{
	class StudentException : Exception
	{
		public StudentException(string message) : base(message)
		{ }
	}

	class Student
	{
		public delegate void GradesStateHandler(); //тип , который безопасно инкапсулирует метод
        public event GradesStateHandler GradesChanged; // изменение оценок



		public Student(string name, string gradebookNumber, int course)
		{
			try
			{
				Name = name;
				GradebookNumber = gradebookNumber;
				Course = course;
			}
			catch (StudentException exception)
			{
				//Console.WriteLine($"Error: {exception.Message}");
				throw;
			}
		}

		private string _name;
		private string _gradebookNumber;
		private int _course;
		public string Name
		{
			get { return _name; }

			set
			{
				if (String.IsNullOrEmpty(value))
				{
					throw new StudentException("Name couldn't be empty");
				}

				foreach (char c in value)
				{
					if (Char.IsDigit(c))
					{
						throw new StudentException("Name couldn't contain numbers");
					}
				}

				_name = value;
			}
		}

		public string GradebookNumber
		{
			get { return _gradebookNumber; }

			set
			{
				foreach (char c in value)
				{
					if (c == ' ') throw new StudentException("Gradebook number couldn't contain spaces");
				}

				_gradebookNumber = value;
			}
		}


		public int Course
		{
			get { return _course; }

			set
			{
				if (value < 1 || value > 6)
					throw new StudentException("Course should be 1-6");
				_course = value;
			}
		}


		private double _averageGrade = 0;

		public Tuple<string, int>[] grades = //статические методы для создания экземпляров типов кортежей
		{
			Tuple.Create("СУБД", 0),
			Tuple.Create("АК", 0),
			Tuple.Create("ИТЕХ", 0),
			Tuple.Create("ПУ", 0),
			Tuple.Create("Ксх", 0),
			Tuple.Create("МОДС", 0),
			Tuple.Create("СПЗ", 0),
			Tuple.Create("МПМКС", 0),
			Tuple.Create("ФВх", 0)
		};

		public void RefreshAverageGrade()
		{
			double sum = 0;

			foreach (var item in grades) //foreach определяет тип переменной цикла var Это псевдоним любого типа
            {
				sum += item.Item2;
			}

			_averageGrade = sum / 10;
		}

		public void SetGradeAtIndex(int index, int grade)
		{
			if (index < 0 || index >= grades.Length)
			{
				throw new IndexOutOfRangeException();
			}
			else if (grade < 0 || grade > 100)
			{
				throw new ArgumentOutOfRangeException();
			}
			else
			{
				grades[index] = Tuple.Create<string, int>(grades[index].Item1, grade);
				if (GradesChanged != null)
				{
					GradesChanged();
				}
			}
		}

		public void PrintGrades()
		{
			for (int i = 0; i < grades.Length; i++)
			{
				Console.WriteLine($"{grades[i].Item1} - {grades[i].Item2}");
			}
		}

		public override string ToString() // переопределение метода ToString
		{
			return $"Name: {_name}\nGradebook number: {_gradebookNumber}\nCourse: {_course}\nAverage grade: {_averageGrade}";
		}

		public static Tuple<string, int>[] Compare(Student first, Student second)
		{
			Tuple<string, int>[] grades = new Tuple<string, int>[10];
			for (int i = 0; i < grades.Length; i++)
			{
				grades[i] = Tuple.Create(first.grades[i].Item1, Math.Abs(first.grades[i].Item2 - second.grades[i].Item2));
			}
			return grades;
		}

	}
	class Program
	{
		static void Main(string[] args)
		{

			int choosenStudent = 0;

			Student firstStudent = new Student("Kokovych Pavlo Romanovych", "261457896", 3);
			Student secondStudent = new Student("Latyshev Egor Batkovich", "654782561", 3);

			firstStudent.GradesChanged += firstStudent.RefreshAverageGrade;
			secondStudent.GradesChanged += secondStudent.RefreshAverageGrade;

			start:
			while (true)
			{
				Console.Clear();
				Console.WriteLine($"Choose the student:\n\n1. {firstStudent.ToString()}\n\n2. {secondStudent.ToString()}\n\n3. Compare students");

				switch (Console.ReadKey().KeyChar.ToString())
				{
					case "1":
						choosenStudent = 1;
						Console.Clear();
						goto menu;
					case "2":
						choosenStudent = 2;
						Console.Clear();
						goto menu;

					case "3":
						Tuple<string, int>[] grades = Student.Compare(firstStudent, secondStudent);
						Console.Clear();
						for (int i = 0; i < grades.Length; i++)
						{
							Console.WriteLine($"{grades[i].Item1} - {grades[i].Item2}");
						}
						Console.WriteLine("Press Any key to continue");
						Console.ReadKey();
						break;
					default:
						break;
				}
			}

			menu:
			while (true)
			{
				Console.Clear();
				Console.WriteLine("Choose option:\n\n1. Set grade\n\n2. Print grades\n\n0. Back to prev menu");

				switch (Console.ReadKey().KeyChar.ToString())
				{
					case "0":
						Console.Clear();
						goto start;
					case "1":
						Console.Clear();
						for (int i = 0; i < firstStudent.grades.Length; i++)
						{
							Console.WriteLine($"{i}. {firstStudent.grades[i].Item1}");
						}
						char key = Console.ReadKey().KeyChar;
						Console.Clear();
						Console.WriteLine("Enter grade to set: ");
						int grade = Convert.ToInt32(Console.ReadLine());
						if (choosenStudent == 1)
						{
							firstStudent.SetGradeAtIndex(int.Parse(key.ToString()), grade);
							break;
						}
						else if (choosenStudent == 2)
						{
							secondStudent.SetGradeAtIndex(int.Parse(key.ToString()), grade);
							break;
						}
						break;
					case "2":
						Console.Clear();
						if (choosenStudent == 1) firstStudent.PrintGrades();
						else if (choosenStudent == 2) secondStudent.PrintGrades();
						Console.WriteLine("Press Any key to continue");
						Console.ReadKey();
						break;
					default:
						break;
				}
			}
		}
	}
}
