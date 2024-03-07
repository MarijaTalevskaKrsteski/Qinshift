//Make a console application called SumOfEven. Inside it create an array of 6 integers. Find and print the sum of the even numbers from the array:
//Test Data:
//Enter integer no.1:
//4
//Enter integer no.1:
//3
//Enter integer no.1:
//7
//Enter integer no.1:
//3
//Enter integer no.1:
//2
//Enter integer no.1:
//8
//Expected Output:
//The result is: 14

Console.WriteLine("SumOfEven\n");

int[] arrayOfIntegers = new int[6];
int sum = 0;
bool printSum = false;

for (int i = 0; i < arrayOfIntegers.Length; i++)
{
    Console.WriteLine("Enter integer no." + (i+1));
    if (int.TryParse(Console.ReadLine(), out arrayOfIntegers[i]))
    {
        if (arrayOfIntegers[i] % 2 == 0)
        {
            sum += arrayOfIntegers[i];
        }         
    }
    else
    { 
        Console.WriteLine("Invalid input. Please enter a number.");
        printSum = true;
        break;
    }
}
if (!printSum)
    Console.WriteLine("The result is:" + sum);