//Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.
//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the third number: 20
//Enter the four number: 30
//Expected Output:
//The average of 10, 15, 20 and 30 is: 18

Console.WriteLine("Average Number \n");
Console.WriteLine("Enter the First number:");
var firstNumber = Console.ReadLine();
bool success = float.TryParse(firstNumber, out float firstNumberParsed);

Console.WriteLine("Enter the Second number:");
var secondNumber = Console.ReadLine();
bool secondSuccess = float.TryParse(secondNumber, out float secondNumberParsed);

Console.WriteLine("Enter the Third number:");
var thirdNumber = Console.ReadLine();
bool thirdSuccess = float.TryParse(thirdNumber, out float thirdNumberParsed);

Console.WriteLine("Enter the Fourth number:");
var fourthNumber = Console.ReadLine();
bool fourthSuccess = float.TryParse(fourthNumber, out float fourthNumberParsed);

//if (!success || !secondSuccess || !thirdSuccess || !fourthSuccess)
//{
//    Console.WriteLine("All four inputs must be numbers!");
//} 
//else
//{
//    float result = (firstNumberParsed + secondNumberParsed + thirdNumberParsed + fourthNumberParsed) / 4;
//    Console.WriteLine($"The average of {firstNumberParsed}, {secondNumberParsed}, {thirdNumberParsed} and {fourthNumberParsed} is: {result}");
//}

if (success && secondSuccess && thirdSuccess && fourthSuccess)
{
    float result = (firstNumberParsed + secondNumberParsed + thirdNumberParsed + fourthNumberParsed) / 4;
    Console.WriteLine($"The average of {firstNumberParsed}, {secondNumberParsed}, {thirdNumberParsed} and {fourthNumberParsed} is: {result}");
}
else
{
    Console.WriteLine("All four inputs must be numbers!");
}