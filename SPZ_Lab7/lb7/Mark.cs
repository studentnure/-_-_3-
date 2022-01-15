
namespace lb7
{
    public class Mark
    {
        private Student _student;
        private Subject _subject;
        private int _markData;

        public Mark()
        {
        }

        public Mark(Student st, Subject sb, int mark)
        {
            Student = st;
            Subject = sb;
            MarkData = mark;
        }

        public int MarkData { get => _markData; set => _markData = value; }
        public Student Student { get => _student; set => _student = value; }
        public Subject Subject { get => _subject; set => _subject = value; }
    }
}
