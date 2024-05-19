using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrackingApp.Domain.Models;
using TimeTrackingApp.Services.Helpers;
using TimeTrackingApp.Services.Interfaces;

namespace TimeTrackingApp.Services.Implementations
{
    public class UIService : IUIService
    {
        public User FillRegisterData()
        {
            string firstName = EnterData("first name");
            string lastName = EnterData("last name");
            string username = EnterData("username");
            int age = EnterIntData("age");
            string password = EnterData("password");
            string confirmedPassword = EnterData("confirm password");

            if (password != confirmedPassword)
            {
                throw new Exception("Password do not match");
            }

            User user = new User()
            {
                FirstName = firstName,
                LastName = lastName,
                Username = username,
                Age = age,
                Password = password
            };
            return user;
        }

        public string EnterData(string field)
        {
            while (true)
            {
                Console.WriteLine($"Please enter {field}");
                string data = Console.ReadLine();
                if (string.IsNullOrEmpty(data))
                {
                    Console.WriteLine($"You must enter {field}");
                    continue;
                }
                else
                {
                    return data;
                }
            }
        }

        public int EnterIntData(string field)
        {
            while (true)
            {
                Console.WriteLine($"Please enter {field}");
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine($"You must enter {field}");
                    continue;
                }
                else
                {
                    if (int.TryParse(input, out int data))
                    {
                        return data;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input for {field}. Please enter a valid integer.");
                    }
                }
            }
        }

        public string PrintMenu(List<string> menuItems)
        {
            int numInput = 0;

            while (true)
            {
                Console.WriteLine("Choose an option:");
                for (int i = 0; i < menuItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {menuItems[i]}");
                }

                string input = Console.ReadLine();

                bool isNumber = int.TryParse(input, out numInput);
                if (!isNumber)
                {
                    Console.WriteLine("You must enter a number.");
                    continue;
                }

                if (numInput < 1 || numInput > menuItems.Count)
                {
                    Console.WriteLine("Invalid number.");
                    continue;
                }
                break;
            }
            return menuItems[numInput - 1]; 
        }
    }
}