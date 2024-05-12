using Homework04;
using Homework04.Domain.Models;
using System;

//Filter all cars that have origin from Europe and print them in console.
List<string> carsFromEurope = CarsData.Cars.Where(x => x.Origin == "Europe").Select(x => x.Model).ToList();
Console.WriteLine("\nCars that have origin from Europe");
carsFromEurope.PrintSimple();

//Filter all cars that have more that 6 Cylinders not including 6
List<Car> carsWithMoreThan6Cylinders = CarsData.Cars.Where(x => x.Cylinders > 6).ToList();
Console.WriteLine("\nCars that have more that 6 Cylinders not including 6");
carsWithMoreThan6Cylinders.PrintCarEntities();

//Filter all cars that have exactly 4 Cylinders and have HorsePower more then 110.0. Join them in one result and print them in console.
List<string> carsWith4CylAndHPMoreThan110 = CarsData.Cars.Where(x => x.Cylinders == 4 && x.HorsePower > 110).Select(x => x.Model).ToList();
Console.WriteLine("\nCars that have exactly 4 Cylinders and HorsePower more then 110");
carsWith4CylAndHPMoreThan110.PrintSimple();

//Count all cars based on their Origin and print the result in console. Example outpur "US 10 models\n Eu 15 Models";
List<string> carsOrigin = CarsData.Cars.Select(x => x.Origin).Distinct().ToList();
Console.WriteLine("");
foreach (string origin in carsOrigin)
{
    int originNumber = CarsData.Cars.Where(x => x.Origin == origin).Count();
    Console.WriteLine($"{origin} {originNumber} Models");
}

//Filter all cars that have more then 200 HorsePower and Find out how much is the lowest, highes and average Miles per galon and print them in console;
List<Car> carsHPOver200 = CarsData.Cars.Where(x => x.HorsePower > 200).OrderBy(x => x.MilesPerGalon).ToList();
Console.WriteLine("");
Console.WriteLine("From the cars that has more than 200 HorsePower, their lowest Miles per galon is: " + carsHPOver200.First().MilesPerGalon);
Console.WriteLine("From the cars that has more than 200 HorsePower, their highest Miles per galon is: " + carsHPOver200.Last().MilesPerGalon);
double averageGalon = 0;
foreach (Car car in carsHPOver200)
{
    averageGalon += car.MilesPerGalon;
}
Console.WriteLine("From the cars that has more than 200 HorsePower, their average Miles per galon is: " + averageGalon/carsHPOver200.Count);