using System.Drawing;
using System.Xml.Linq;

namespace Task1.Models
{
    public class Shape
    {
        private string _Name { get; set; }
        private string _Color { get; set; }
        public int[] Position { get; set; }

        public Shape(string name, string color, int[] position)
        { 
            _Name = name;
            _Color = color;
            Position = position;
        }

        public virtual void GetArea()
        {
            Console.WriteLine("There is no special implementation for area.");
        }

        public virtual void GetPerimeter()
        {
            Console.WriteLine("There is no special implementation for perimeter.");
        }

        public void Move()
        {
            Console.WriteLine(Position[0] += 5);
            Console.WriteLine(Position[1] += 5);
        }

        public string GetName()
        {
            return _Name;
        }

        public void SetName(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                _Name = name;
            }
            else
            {
                Console.WriteLine("Can't be an empty string for name!");
            }
        }

        public string GetColor()
        {
            return _Color;
        }

        public void SetColor(string color)
        {
            if (!string.IsNullOrEmpty(color))
            {
                _Color = color;
            }
            else
            {
                Console.WriteLine("Can't be an empty string for color!");
            }            
        }
    }
}
