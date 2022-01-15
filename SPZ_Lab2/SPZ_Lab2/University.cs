using System;
using System.Collections.Generic;

namespace SPZ_Lab2
{

	public class University : IEqualityComparer<University>
	{
		private string _name;
		private int _faculties;
		private int _laboratories;
		private int _students;
		private int _lectureHalls;
		private int _teachers;
		private int _staff;

		public string Name
		{
			get { return _name; }

			set
			{
				if (string.IsNullOrEmpty(value))
					throw new Exception("Name couldn't be empty");

				_name = value;
			}
		}
		public int Faculties
		{
			get { return _faculties; }

			set
			{
				if (value < 0)
					throw new Exception("Number should be positive");
				_faculties = value;
			}
		}
		public int Laboratories
		{
			get { return _laboratories; }

			set
			{
				if (value < 0)
					throw new Exception("Number should be positive");
				_laboratories = value;
			}
		}
		public int Students
		{
			get { return _students; }

			set
			{
				if (value < 0)
					throw new Exception("Number should be positive");
				_students = value;
			}
		}
		public int LectureHalls
		{
			get { return _lectureHalls; }

			set
			{
				if (value < 0)
					throw new Exception("Number should be positive");
				_lectureHalls = value;
			}
		}
		public int Teachers
		{
			get { return _teachers; }

			set
			{
				if (value < 0)
					throw new Exception("Number should be positive");
				_teachers = value;
			}
		}
		public int Staff
		{
			get { return _staff; }

			set
			{
				if (value < 0)
					throw new Exception("Number should be positive");
				_staff = value;
			}
		}


		public University()
		{
			Name = "University";
			Faculties = 0;
			Laboratories = 0;
			Students = 0;
			LectureHalls = 0;
			Teachers = 0;
			Staff = 0;
		}
		public University(string name, int faculties, int laboratories, int students, int lectureHalls, int teachers, int staff)
		{
			Name = name;
			Faculties = faculties;
			Laboratories = laboratories;
			Students = students;
			LectureHalls = lectureHalls;
			Teachers = teachers;
			Staff = staff;
		}
		public University(University obj)
		{
			Name = obj.Name;
			Faculties = obj.Faculties;
			Laboratories = obj.Laboratories;
			Students = obj.Students;
			LectureHalls = obj.LectureHalls;
			Teachers = obj.Teachers;
			Staff = obj.Staff;
		}


		public void AddFaculties(int value)
		{
			if ((_faculties + value) < 0)
				throw new Exception("Negative number");

			_faculties += value;
		}
		public void RemoveFaculties(int value)
		{
			if ((_faculties - value) < 0)
				throw new Exception("Negative number");

			_faculties -= value;
		}

		public void AddLaboratories(int value)
		{
			if ((_laboratories + value) < 0)
				throw new Exception("Negative number");

			_laboratories += value;
		}
		public void RemoveLaboratories(int value)
		{
			if ((_laboratories - value) < 0)
				throw new Exception("Negative number");

			_laboratories -= value;
		}

		public void AddStudents(int value)
		{
			if ((_students + value) < 0)
				throw new Exception("Negative number");

			if ((double)(_students + value) / 10 > _teachers)
				throw new Exception("Too much students per teacher (max 10 students per teacher)");

			_students += value;
		}
		public void RemoveStudents(int value)
		{
			if ((_students - value) < 0)
				throw new Exception("Negative number");

			_students -= value;
		}

		public void AddLectureHalls(int value)
		{
			if ((_lectureHalls + value) < 0)
				throw new Exception("Negative number");

			_lectureHalls += value;
		}
		public void RemoveLectureHalls(int value)
		{
			if ((_lectureHalls - value) < 0)
				throw new Exception("Negative number");

			_lectureHalls -= value;
		}

		public void AddTeachers(int value)
		{
			if (_teachers + value < 0)
				throw new Exception("Negative number");

			else if ((double)(_students / (_teachers + value)) > 10)
				throw new Exception("Too few teachers");


			_teachers += value;
		}
		public void RemoveTeachers(int value)
		{
			if (_teachers - value < 0)
				throw new Exception("Negative number");

			if (_teachers == value && _students != 0)
				throw new Exception("Teachers count couldn't be zero");

			else if ((double)(_students / (_teachers - value)) >= 10)
				throw new Exception("Too few teachers");

			_teachers -= value;
		}

		public void AddStaff(int value)
		{
			if ((_staff + value) < 0)
				throw new Exception("Negative number");

			_staff += value;
		}
		public void RemoveStaff(int value)
		{
			if ((_staff - value) < 0)
				throw new Exception("Negative number");

			_staff -= value;
		}


		public int this[int index]
		{
			get
			{
				switch (index)
				{
					case 0: return Faculties;
					case 1: return Laboratories;
					case 2: return Students;
					case 3: return LectureHalls;
					case 4: return Teachers;
					case 5: return Staff;
					default: return 0;
				}
			}					   
			set
			{
				switch (index)
				{
					case 0: Faculties = value; break;
					case 1: Laboratories = value; break;
					case 2: Students = value; break;
					case 3: LectureHalls = value; break;
					case 4: Teachers = value; break;
					case 5: Staff = value; break;
					default: break;
				}
			}				   
		}						   


		public static University operator + (University obj1, University obj2)
		{
			University temp = new University
			{
				Name = string.Format("{0} + {1}", obj1.Name, obj2.Name),
				Faculties = obj1.Faculties + obj2.Faculties,
				Laboratories = obj1.Laboratories + obj2.Laboratories,
				Students = obj1.Students + obj2.Students,
				LectureHalls = obj1.LectureHalls + obj2.LectureHalls,
				Teachers = obj1.Teachers + obj2.Teachers,
				Staff = obj1.Staff + obj2.Staff
			};

			return temp;
		}


		public bool Equals(University obj1, University obj2)
		{
			if (obj1 == null && obj2 == null)
				return true;

			if (obj1 == null || obj2 == null)
				return false;

			if (obj1.Faculties == obj2.Faculties &&
				obj1.Laboratories == obj2.Laboratories &&
				obj1.Students == obj2.Students &&
				obj1.LectureHalls == obj2.LectureHalls &&
				obj1.Teachers == obj2.Teachers &&
				obj1.Staff == obj2.Staff)
				return true;
			else
				return false;
		}

		public int GetHashCode(University obj)
		{
			return obj.Name.GetHashCode() ^ obj.Laboratories.GetHashCode() ^ obj.LectureHalls.GetHashCode() ^ obj.Faculties.GetHashCode() ^ obj.Staff.GetHashCode() ^ obj.Students.GetHashCode() ^ obj.Teachers.GetHashCode();
		}
	}
}
