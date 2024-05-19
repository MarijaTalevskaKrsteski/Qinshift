using TimeTrackingApp.Domain.Models;
using TimeTrackingApp.Services.Helpers;
using TimeTrackingApp.Services.Implementations;
using TimeTrackingApp.Services.Interfaces;

IUserService<User> userService = new UserService<User>();
IUIService uiService = new UIService();
Seed();
User currentUser = null;
while (true)
{
    //Log In Menu
    string logInMenuOption = uiService.PrintMenu(MenuHelper.GetLogInMenu());
    switch(logInMenuOption)
    {
        case "Log In":
            Console.WriteLine("Enter username:");
            string inputUsername = Console.ReadLine();
            if (string.IsNullOrEmpty(inputUsername))
            {
                Console.WriteLine("You must enter username");
                break;
            }

            Console.WriteLine("Enter password:");
            string inputPassword = Console.ReadLine();
            if (string.IsNullOrEmpty(inputPassword))
            {
                Console.WriteLine("You must enter password");
                break;
            }
            currentUser = userService.Login(inputUsername, inputPassword);
            break;

        case "Register":
            User user = uiService.FillRegisterData();
            userService.Register(user);
            break;
    }

    if(currentUser != null)
    {
        break;
    }    
}

//Show main menu
string mainMenuOption = uiService.PrintMenu(MenuHelper.GetMainMenu());
switch (mainMenuOption)
{
    case "Tracking":
        string activitiesMenuOption = uiService.PrintMenu(MenuHelper.GetActivitiesMenu());
        switch (activitiesMenuOption)
        {
            case "Main Menu":
                activitiesMenuOption = uiService.PrintMenu(MenuHelper.GetMainMenu());
                break;
            case "Reading":
                Console.WriteLine("");
                break;
            case "Exercising":
                Console.WriteLine("");
                break;
            case "Working":
                Console.WriteLine("");
                break;
            case "Hobby":
                Console.WriteLine("");
                break;
        }
        break;

    case "Change Password":
        Console.WriteLine("Enter old password");
        string oldPassword = Console.ReadLine();
        Console.WriteLine("Enter new password");
        string newPassword = Console.ReadLine();
        userService.ChangePassword(currentUser.Id, oldPassword, newPassword);
        break;

    case "Change First Name":
        Console.WriteLine("Enter first name:");
        string firstName = Console.ReadLine();
        userService.ChangeFirstName(currentUser.Id, firstName);
        break;

    case "Change Last Name":
        Console.WriteLine("Enter last name");
        string lastName = Console.ReadLine();
        userService.ChangeLastName(currentUser.Id, lastName);
        break;

    case "Logout":
        mainMenuOption = uiService.PrintMenu(MenuHelper.GetLogInMenu());
        break;

    case "Deactivate account":
        Console.WriteLine("");        
        break;
}
void Seed()
{
    User userPetko = new User();
    userPetko.FirstName = "Petko";
    userPetko.LastName = "Petkovski";
    userPetko.Username = "ppetkovski";
    userPetko.Password = "Test123";
    userPetko.Age = 25;
    userService.Register(userPetko);

    User userAna = new User
    {
        FirstName = "Ana",
        LastName = "Anovska",
        Username = "aanovska",
        Password = "Test321",
        Age = 35
    };
    userService.Register(userAna);
}