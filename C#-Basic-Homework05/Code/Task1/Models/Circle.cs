//Add class Circle, that inherits from Shape. It should have property radius.
//Override the getArea and getPerimeter methods correspondingly for a circle. Test with few objects.

namespace Task1.Models
{
    internal class Circle : Shape
    {        
        public int Radius { get; set; }
        public double PI = 3.141592;

        public Circle(string name, string color, int[] position, int radius) : base(name, color, position)
        {
            Radius = radius;
        }

        public override void GetArea()
        {
            Console.WriteLine($"The area for Circle with name: {GetName()} and color: {GetColor()}, with radius: {Radius}, is: {(Radius*Radius*PI)}");
        }

        public override void GetPerimeter()
        {
            double perimeter = 2*Radius*PI;
            Console.WriteLine($"The perimeter for Circle with name: {GetName()} and color: {GetColor()}, with radius: {Radius}, is: {perimeter}");
        }
    }
}
