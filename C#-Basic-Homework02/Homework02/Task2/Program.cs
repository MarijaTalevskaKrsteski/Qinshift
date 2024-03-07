//Make a new console application called StudentGroup
//Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names (strings).
//Get a number from the console between 1 and 2 and print the students from that group in the console.
//Ex: studentsG1["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]
//Test Data:
//Enter student group: (there are 1 and 2 )
//1
//Expected Output:
//The Students in G1 are:
//Zdravko
//Petko
//Stanko
//Branko
//Trajko

Console.WriteLine("Student Group\n");

string[] studentsG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = new string[] { "Marija", "Ana", "Ema", "Maja", "Viki" };

Console.WriteLine("Enter student group: (there are 1 and 2):");
if(int.TryParse(Console.ReadLine(), out int groupNumberInput))
{
    if(groupNumberInput == 1)
    {
        Console.WriteLine("\nThe students in G1 are:");
        for (int i = 0; i < studentsG1.Length; i++)
        {
            Console.WriteLine(studentsG1[i]);
        }
    } 
    else if (groupNumberInput == 2)
    {
        Console.WriteLine("\nThe students in G2 are:");
        for (int i = 0; i < studentsG2.Length; i++)
        {
            Console.WriteLine(studentsG2[i]);
        }
    }
    else
    {
        Console.WriteLine("Please choose 1 or 2!");
    }
}
else
{
    Console.WriteLine("Invalid input!");
}