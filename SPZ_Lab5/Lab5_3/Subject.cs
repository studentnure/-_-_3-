using System;

namespace Lab5_3
{
    public class Subject : IComparable
    {
        public string Name { get; set; }

        public int Grade { get; set; }
        
		public Subject() { }
        public Subject(string name)
        {
            Name = name;
            Grade = 0;
        }

        public int CompareTo(object obj)
        {
            Subject subj = obj as Subject;
            return Name.CompareTo(subj.Name);
        }

		public static int CompareByName(Subject subj1, Subject subj2)
		{
			return subj1.Name.CompareTo(subj2.Name);
		}

		public static int CompareByGrade(Subject subj1, Subject subj2)
		{
			return subj1.Grade.CompareTo(subj2.Grade);
		}
	}
}
