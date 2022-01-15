
namespace lb7
{
    public class Student
    {
        private string _name;
        private string _surname;

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }

        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
}
