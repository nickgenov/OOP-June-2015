using Animals.Enums;

namespace Animals.Classes
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age) : base(name, age, Gender.Male)
        {
        }
    }
}