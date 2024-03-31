//Create interfaces called IAnimal, IDog, ICat
//IAnimal : Contains method PrintAnimal
//IDog - Contains method Bark
//ICat - Contains method Eat that gets parameter food of type string
//Create an abstract class Animal(you choose the properties) that implements IAnimal, with abstract method PrintAnimal
//Create class Dog that implements IDog and inherits from Animal. Implement PrintAnimal but also Bark.
//Create class Cat that implements ICat and inherits from Animal. Implement PrintAnimal but also Eat.
//Create several objects and test the method calls
//The implementation for the methods is on your choice.
using Homework_1.Models;

Dog dog = new Dog("Barky", 10, "Brown");
dog.PrintAnimal();
Console.WriteLine($"The dog name is {dog.Name} and is {dog.Age} years old.");
dog.Bark();

Cat cat = new Cat("Garfield", 5, "Orange");
cat.PrintAnimal();
Console.WriteLine($"The cat name is {cat.Name} and is {cat.Age} years old.");
cat.Eat("fish");