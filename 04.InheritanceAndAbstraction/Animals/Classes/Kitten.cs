using Animals.Enums;

namespace Animals.Classes
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age) : base(name, age, Gender.Female)
        {
        }
    }
}