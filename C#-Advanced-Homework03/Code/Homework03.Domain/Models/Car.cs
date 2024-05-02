using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework03.Domain.Models
{
    public class Car : Vehicle
    {
        public int FuelTank;
        public List<string> Countries;

        public Car(int id, string type, int yearOfProduction, int batchNumber, int fuelTank, List<string> countries) 
            : base(id, type, yearOfProduction, batchNumber)
        {
            FuelTank = fuelTank;
            Countries = countries != null ? countries : new List<string>();
        }

        public override void PrintVehicle()
        {
            Console.WriteLine($"The id of the Car vehcile is {Id}, type {Type}, year of production {YearOfProduction}." +
                $"This car has Fuel Tank {FuelTank} and is produced in the following countries: ");
            foreach (string country in Countries)
            {
                Console.WriteLine($"{country}");
            }
        }
    }
}
