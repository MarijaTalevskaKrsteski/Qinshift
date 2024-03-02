//Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done ( +, - , * , / ). Then it returns the result.
//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the Operation: +
//Expected Output:
//The result is: 25

Console.WriteLine("Real Calculator \n");

Console.WriteLine("Enter the First number:");
var firstNumber = Console.ReadLine();
int firstNumberParsed;
bool success = int.TryParse(firstNumber, out firstNumberParsed);

if (success)
{
    Console.WriteLine("Enter the Second number:");
    var secondNumber = Console.ReadLine();
    int secondNumberParsed;
    bool secondSuccess = int.TryParse(secondNumber, out secondNumberParsed);

    if (secondSuccess)
    {
        Console.WriteLine("Enter the Operation +, -, *, /:");
        var operation = Console.ReadLine();
        int result;
        switch (operation)
        {
            case "+":
                result = firstNumberParsed + secondNumberParsed;
                Console.WriteLine("The result is: " + result);
                break;
            case "-":
                result = firstNumberParsed - secondNumberParsed;
                Console.WriteLine("The result is: " + result);
                break;
            case "*":
                result = firstNumberParsed * secondNumberParsed;
                Console.WriteLine("The result is: " + result);
                break;
            case "/":
                if (secondNumberParsed != 0)
                {
                    result = firstNumberParsed / secondNumberParsed;
                    Console.WriteLine("The result is: " + result);
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero!");
                }
                break;
            default:
                Console.WriteLine("Ivalid operator!");
                break;
        }
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