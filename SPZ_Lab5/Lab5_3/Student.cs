using System;
using System.Collections.Generic;

namespace Lab5_3
{
	[Serializable]
    public class Student : IComparable
    {
        public string Name { get; set; }

        public List<Subject> subjectsList;

		public Student()
		{ }

		public Student(string name)
        {
            Name = name;
            subjectsList = new List<Subject>();
        }

        public void AddNewSubject(string subject)
        {
            subjectsList.Add(new Subject(subject));
        }

        public void RemoveSubjectAtIndex(int index)
        {
            subjectsList.RemoveAt(index);
        }

        public int CompareTo(object obj)
        {
            Student stud = obj as Student;
            return Name.CompareTo(stud.Name);
        }
    }
}
