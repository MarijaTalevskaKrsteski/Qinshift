namespace Homework_2.Models
{
    public class Truck : Vehicle
    {
        public Truck(string type, string color, int wheels) : base(type, color, wheels)
        {
        }

        public override void Drive()
        {
            Console.WriteLine("This is a truck vehicle.");
        }
    }
}
