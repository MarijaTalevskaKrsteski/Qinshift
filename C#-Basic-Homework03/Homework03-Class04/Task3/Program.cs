//Create a function that takes a number as input. This method should return the sum of the digits in the number.

while (true)
{
    Console.WriteLine("Enter a whole number:");
    if (!int.TryParse(Console.ReadLine(), out int wholeNumber))
    {
        Console.WriteLine("Invalid input!");
    }
    else if (wholeNumber == 0)
    {
        Console.WriteLine("Number is 0. Sum is 0.");
        break;
    }
    else
    {
        Console.WriteLine($"The sum of the digits in the {wholeNumber} is: {SumOfDigits(wholeNumber)}");
        break;
    }
}

int SumOfDigits(int number)
{
    int sum = 0;
    if (number < 0) 
    {
        number = number * (-1);
    }
    while (number != 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}