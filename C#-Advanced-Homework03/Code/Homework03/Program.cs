using Homework03.Domain.Database;
using Homework03.Domain.Models;
//In the main program call PrintVehicle for each object in the list in the db.
//Call Validate from main Program with a couple of objects.

foreach(Vehicle vehicle in Database.vehicles)
{
    vehicle.PrintVehicle();
}

Console.WriteLine("\n\nValidation:\n");

foreach (Vehicle vehicle in Database.vehicles)
{
    if (Validator.Validate(vehicle))
    {
        vehicle.PrintVehicle();
    }
    else
    {
        Console.WriteLine("---------Invalid vehicle--------");
    }
}