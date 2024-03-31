using Homework_1.Interfaces;

namespace Homework_1.Models
{
    public class Cat : Animal, ICat
    {
        public Cat(string name, int age, string color) : base(name, age, color)
        { }

        public new void PrintAnimal()
        {
            Console.WriteLine("This is a Cat.");
        }
        public void Eat(string food)
        {
            Console.WriteLine("The cat is eating " + food + ".");
        }        
    }
}
