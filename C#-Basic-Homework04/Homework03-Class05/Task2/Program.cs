//Create a class Dog
//Add properties: Name, breed, color
//The dog needs to have an Eat method that returns message: The dog is now eating.
//A Play method returning a message : The dog is now playing. and a
//ChaseTail method that returns a message: Dog is now chasing its tail.

//The user needs to create a dog object by using inputs and then choose an option to choose one of the methods mentioned above.
//For example, if he enters 1 to call Eat method, if he enters 2 to call Play, if user enters 3 to call Play

using Task2;

Console.WriteLine("Enter dog's name:");
string dogNameInput = Console.ReadLine();
Console.WriteLine("Enter dog's breed:");
string dogBreedInput = Console.ReadLine();
Console.WriteLine("Enter dog's color:");
string dogColorInput = Console.ReadLine();

Dog dogObject = new Dog(dogNameInput, dogBreedInput, dogColorInput);

Console.WriteLine("Enter:\n1 - to call Eat method,\n2 - to call method Play,\n3 - to call method Play.");
if (int.TryParse(Console.ReadLine(), out int methodInput))
{
    switch(methodInput)
    {
        case 1:
            dogObject.Eat();
            break;
        case 2:
            dogObject.Play();
            break;
        case 3:
            dogObject.ChaseTail();
            break;
        default:
            Console.WriteLine("Wrong input, must be 1, 2 or 3!");
            break;
    }
} 
else
{
    Console.WriteLine("Wrong input, must be a number, 1, 2 or 3!");
}