//Make a method called AgeCalculator
//The method will have one input parameter, your birthday date
//The method should return your age
//Show the age of a user after he inputs a date
//Note: take into consideration if the birthday is today, after or before today

Console.Write("Enter your date of birth in the format of the server you are using. Ex: dd/MM/yyyy or MM/dd/yyyy: ");
if (!DateTime.TryParse(Console.ReadLine(), out DateTime birthDateInput))
{
    Console.WriteLine("Invalid input!");
}
else
{
    Console.WriteLine("You are " + AgeCalculator(birthDateInput) + " years old today");
}

int AgeCalculator(DateTime birthDate)
{
    int age;
    age = DateTime.Now.Year - birthDate.Year;
    if (birthDate.Month > DateTime.Now.Month || (birthDate.Month == DateTime.Now.Month && birthDate.Day > DateTime.Now.Day))
    {
        age = age - 1;
    }
    return age;
}