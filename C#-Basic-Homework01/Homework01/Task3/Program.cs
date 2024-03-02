//Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second value and the second variable the first value. Please find example below:
//Test Data:
//Input the First Number: 5
//Input the Second Number: 8
//Expected Output:
//After Swapping:
//First Number: 8
//Second Number: 5

Console.WriteLine("Swap Numbers\n");

Console.WriteLine("Input the First Number:");
var firstNumber = Console.ReadLine();
float firstNumberParsed;
bool success = float.TryParse(firstNumber, out firstNumberParsed);
if (success)
{
    Console.WriteLine("Input the Second Number:");
    var secondNumber = Console.ReadLine();
    float secondNumberParsed;
    bool secondSuccess = float.TryParse(secondNumber, out secondNumberParsed);

    if (secondSuccess)
    {
        float tempFirstNumberParsed = firstNumberParsed;
        firstNumberParsed = secondNumberParsed;
        secondNumberParsed = tempFirstNumberParsed;
        Console.WriteLine($"After Swapping:\nFirst Number: {firstNumberParsed}\nSecond Number: {secondNumberParsed}");
    }
    else
    {
        Console.WriteLine("Invalid input! Please enter a number!");
    }
}
else
{
    Console.WriteLine("Invalid input! Please enter a number!");
}