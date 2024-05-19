using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTrackingApp.Services.Helpers
{
    public static class MenuHelper
    {
        public static List<string> GetLogInMenu()
        {
            List<string> menuItems = new List<string>();
            menuItems.Add("Log In");
            menuItems.Add("Register");

            return menuItems;
        }

        public static List<string> GetMainMenu()
        {
            List<string> menuItems = new List<string>();
            menuItems.Add("Tracking");
            menuItems.Add("Change Password");
            menuItems.Add("Change First Name");
            menuItems.Add("Change Last Name");
            menuItems.Add("Logout");
            menuItems.Add("Deactivate account");

            return menuItems;
        }

        public static List<string> GetActivitiesMenu() 
        {
            List<string> menuItems = new List<string>();
            menuItems.Add("Main Menu");
            menuItems.Add("Reading");
            menuItems.Add("Exercising");
            menuItems.Add("Working");
            menuItems.Add("Hobby");

            return menuItems;
        }
    }
}
