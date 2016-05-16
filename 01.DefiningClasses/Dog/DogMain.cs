namespace Dog
{
    public class DogMain
    {
        static void Main()
        {
            Dog unnamed = new Dog();
            Dog sharo = new Dog("Sharo", "Melez");

            unnamed.Breed = "German Shepherd";

            var dogs = new Dog[2]
            {
                unnamed,
                sharo
            };

            foreach (var dog in dogs)
            {
                dog.Bark();
            }
        }
    }
}