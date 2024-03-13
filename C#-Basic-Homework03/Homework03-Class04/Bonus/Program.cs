//##Bonus Take a sentence as input and print its largest word.

while (true)
{
    Console.WriteLine("Enter a sentence:");
    string sentenceInput = Console.ReadLine();
    if (sentenceInput == "")
    {
        Console.WriteLine("\nYou need to input a sentence!");
    }
    else
    {
        Console.WriteLine($"\nThe largest word from the sentence: {sentenceInput} is: {LargestWordMethod(sentenceInput)}");
        break;
    }
}

string LargestWordMethod(string sentance)
{
    string largestWord = "";
    string[] words = sentance.Split(" ");
    foreach (string word in words)
    {
        if (word.Length > largestWord.Length) 
        { 
            largestWord = word;
        }
    }
    return largestWord;
}

//Sentence with more than one word

//while (true)
//{
//    Console.WriteLine("Enter a sentence with few words:");
//    string sentenceInput = Console.ReadLine();
//    if (sentenceInput.IndexOf(" ") == -1)
//    //if (!sentanceInput.Contains(" "))
//    {
//        Console.WriteLine("\nYour input needs to have more than one word!");
//    }
//    else
//    {
//        Console.WriteLine($"\nThe largest word from the sentence: {sentenceInput} is: {LargestWordMethod(sentenceInput)}");
//        break;
//    }
//}