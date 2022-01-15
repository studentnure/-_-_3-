
namespace lb7
{
    public class Subject
    {
        private string _name;

        public string Name { get => _name; set => _name = value; }

        public override string ToString()
        {
            return Name;
        }
    }
}
