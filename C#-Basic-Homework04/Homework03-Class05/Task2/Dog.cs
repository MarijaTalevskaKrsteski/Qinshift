namespace Task2
{
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }

        public void Eat()
        {
            Console.WriteLine($"The dog with name {Name}, breed {Breed} and color {Color} is now eating.");
        }
        public void Play()
        {
            Console.WriteLine($"The dog with name {Name}, breed {Breed} and color {Color} is now playing.");
        }
        public void ChaseTail()
        {
            Console.WriteLine($"The dog with name {Name}, breed {Breed} and color {Color} is now chasing its tail.");
        }

        public Dog(string name, string breed, string color)
        {
            Name = name;
            Breed = breed;
            Color = color;
        }
    }
}
