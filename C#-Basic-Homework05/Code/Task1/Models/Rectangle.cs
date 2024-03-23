//Add class Rectangle, that inherits from Shape. It should have properties sideA and sideB.
//Override the getArea and getPerimeter methods correspondingly for a rectangle.

namespace Task1.Models
{
    public class Rectangle : Shape
    {
        public int SideA { get; set; }
        public int SideB { get; set; }

        public Rectangle(string name, string color, int[] position, int sideA, int sideB) : base(name, color, position)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public override void GetArea()
        {
            Console.WriteLine($"The area for Rectangle with name: {GetName()}, color: {GetColor()}, side A: {SideA} and side B: {SideB}, is: {SideA*SideB}");
        }

        public override void GetPerimeter()
        {
            int perimeter = 2 * (SideA + SideB);
            Console.WriteLine($"The perimeter for Rectangle with name: {GetName()}, color: {GetColor()}, side A: {SideA} and side B: {SideB}, is: {perimeter}");
        }
    }
}
