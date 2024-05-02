using Homework03.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create a static class that serves as a DB, that has list of Vehicles. In this list put objects of type Car, Bike and Vehicle.
namespace Homework03.Domain.Database
{
    public static class Database
    {
        public static List<Vehicle> vehicles = new List<Vehicle> 
        { 
            new Vehicle(123, "Car", 2000, 900012), 
            new Vehicle(0, "", 0, 002001),
            new Car(001, "Renault", 2010, 900059, 60, new List<string> { "France", "Turkey" }), 
            new Bike(010, "Alpina", 2020, 910001, "Black")
        };
    }
}
