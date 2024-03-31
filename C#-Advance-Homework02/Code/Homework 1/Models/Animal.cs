using Homework_1.Interfaces;

namespace Homework_1.Models
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        public Animal() { }

        public Animal(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }

        public void PrintAnimal()
        {
            Console.WriteLine("This is an Animal.");
        }
    }
}
