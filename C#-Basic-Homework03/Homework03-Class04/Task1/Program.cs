//Take one string from the input and print its last 5 characters.

while (true)
{
    Console.WriteLine("Enter a string with more than 5 characters:");
    string stringInput = Console.ReadLine();
    if (stringInput.Length < 5)
    {
        Console.WriteLine("\nYour input needs to be more than 5 chars!");
    }
    else
    {
        string fiveCharString = stringInput.Substring(stringInput.Length - 5);
        Console.WriteLine($"\nThe last 5 chars from \"{stringInput}\" are: \"{fiveCharString}\".");
        break;
    }
}