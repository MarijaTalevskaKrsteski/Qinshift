namespace Homework_2.Models
{
    public class Car : Vehicle
    {
        public Car(string type, string color, int wheels) : base(type, color, wheels)
        {
        }

        public override void Drive()
        {
            Console.WriteLine("This is a car vehicle.");
        }
    }
}
