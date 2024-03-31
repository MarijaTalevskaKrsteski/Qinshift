using Homework_1.Interfaces;

namespace Homework_1.Models
{
    public class Dog : Animal, IDog
    {
        public Dog(string name, int age, string color) : base(name, age, color)
        { }

        public void Bark()
        {
            Console.WriteLine("The dog is barking.");
        }

        public new void PrintAnimal()
        {
            Console.WriteLine("This is a Dog.");
        }
    }
}
