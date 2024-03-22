//Give the user an option to input numbers
//After inputing each number ask them if they want to input another with a Y/N question
//Store all numbers in a QUEUE
//When the user is done adding numbers print the numbers in the order that the user entered them from the QUEUE

Queue<int> intQueue = new Queue<int>();
while (true)
{
    Console.WriteLine("Enter a number:");
    if (int.TryParse(Console.ReadLine(), out int numberInput))
    {
        intQueue.Enqueue(numberInput);
        bool anotherNum = true;
        while (true)
        {
            Console.WriteLine("Do you want to enter another number, Y (Yes) or N (No)?");
            string yesOrNo = Console.ReadLine().ToLower();
            if (yesOrNo == "y" || yesOrNo == "n")
            {
                if (yesOrNo == "n")
                    anotherNum = false;
                break;                
            }
            else
            {
                Console.WriteLine("Invalid input, must be y/n!");
            }
        }
        if (anotherNum == false)
            break;
    }
    else
    {
        Console.WriteLine("Invalid input, must be a number!");
    }
}

Console.WriteLine("\nThe numbers you have entered are:");
foreach (int i in intQueue)
{
    Console.WriteLine(i);
}