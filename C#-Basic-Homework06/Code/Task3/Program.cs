//Create a class Animal. Each Animal has name, color, age and Gender. Use enum for Gender.
//Find the names of all the animals aged 5 or more
//Find all the names of the animals that start with 'A'
//Find all male, brown animals
//Find the first animal whose name is longer than 10 characters

using Task3.Models;
using Task3.Enums;
using System.Drawing;

List<Animal> listOfAnimals = new List<Animal>
{
    new Animal("Barky", "Brown", 5, GenderEnum.Male),
    new Animal("Sparky", "White", 10, GenderEnum.Female),
    new Animal("Rex", "White", 13, GenderEnum.Male),
    new Animal("Lucy", "Brown", 3, GenderEnum.Female),
    new Animal("Bernardray", "White", 2, GenderEnum.Male),
    new Animal("Armageddonn", "Brown", 4, GenderEnum.Female)
};

Console.WriteLine("The names of all the animals aged 5 or more:");
List<Animal> animalsAgedFiveOrMore = listOfAnimals.Where(x => x.Age >= 5).ToList();
foreach(Animal animal in animalsAgedFiveOrMore)
{
    Console.WriteLine(animal.Name);
}

Console.WriteLine("All the names of the animals that start with 'A'");
List<Animal> animalsStartingWithA = listOfAnimals.Where(x => x.Name.StartsWith("A") || x.Name.StartsWith("a")).ToList();
foreach (Animal animal in animalsStartingWithA)
{
    Console.WriteLine(animal.Name);
}

Console.WriteLine("All male, brown animals:");
List<Animal> allBrownAndMaleAnimals = listOfAnimals.Where(x => x.Gender == GenderEnum.Male && x.Color == "Brown").ToList();
foreach (Animal animal in allBrownAndMaleAnimals)
{
    Console.WriteLine(animal.Name);
}

//Console.WriteLine("The first animal whose name is longer than 10 characters:");
//Animal firstAnimalWitnNameLongerThanTen = listOfAnimals.First(x => x.Name.Length > 10);
//Console.WriteLine(firstAnimalWitnNameLongerThanTen.Name);

Console.WriteLine("The first animal whose name is longer than 10 characters:");
Animal firstAnimalWitnNameLongerThanTen = listOfAnimals.FirstOrDefault(x => x.Name.Length > 10);
if(firstAnimalWitnNameLongerThanTen != null)
{
    Console.WriteLine(firstAnimalWitnNameLongerThanTen.Name);
}
else
{
    Console.WriteLine("There is no Animal with name longer than 10 chars.");
}