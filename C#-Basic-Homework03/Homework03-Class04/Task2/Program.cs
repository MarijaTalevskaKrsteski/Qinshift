//Take a sentence as input and print its words.

while (true)
{
    Console.WriteLine("Please enter a sentence:");
    string sentenceInput = Console.ReadLine();
    if (sentenceInput == "")
    {
        Console.WriteLine("\nYou need to input a sentence!");
    }
    else
    {
        string[] words = sentenceInput.Split(" ");
        Console.WriteLine("\nThe words from the input sentence are:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
        break;
    }
}

//Sentence with more than one word

//while (true)
//{
//    Console.WriteLine("Enter a sentence with few words:");
//    string sentenceInput = Console.ReadLine();
//    if (sentenceInput.IndexOf(" ") == -1)
//    //if (!sentenceInput.Contains(" "))
//    {
//        Console.WriteLine("\nYour input needs to have more than one word!");
//    }
//    else
//    {
//        string[] words = sentenceInput.Split(" ");
//        Console.WriteLine("\nThe words from the input sentence are:");
//        foreach (string word in words)
//        {
//            Console.WriteLine(word);
//        }
//        break;
//    }
//}