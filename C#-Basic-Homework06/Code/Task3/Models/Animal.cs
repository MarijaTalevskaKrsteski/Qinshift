//Create a class Animal. Each Animal has name, color, age and Gender. Use enum for Gender.

using Task3.Enums;

namespace Task3.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public GenderEnum Gender { get; set; }

        public Animal(string name, string color, int age, GenderEnum gender)
        {
            Name = name;
            Color = color;
            Age = age;
            Gender = gender;
        }
    }
}
