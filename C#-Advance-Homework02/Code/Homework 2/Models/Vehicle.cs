namespace Homework_2.Models
{
    public abstract class Vehicle
    {
        public string Type { get; set; }
        public string Color { get; set; }
        public int Wheels { get; set; }

        public Vehicle(string type, string color, int wheels) 
        {
            Type = type;
            Color = color;
            Wheels = wheels;
        }

        public abstract void Drive();
    }
}
