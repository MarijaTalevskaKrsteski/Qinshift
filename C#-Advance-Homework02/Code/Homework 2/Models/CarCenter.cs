using Homework_2.Interfaces;
namespace Homework_2.Models
{
    public class CarCenter : ICarWash, IGasPump, IRepairService
    {
        public CarCenter() { }

        public void CheckVehicle(Vehicle vehicle)
        {
            Console.WriteLine($"In the Car Center, we are checking the {vehicle.Type} vehicle with {vehicle.Color} color that has {vehicle.Wheels} wheels.");
        }
                
        public void FixVehicle(Vehicle vehicle)
        {
            Console.WriteLine($"In the Car Center, we are fixing the {vehicle.Type} vehicle with {vehicle.Color} color that has {vehicle.Wheels} wheels.");
        }

        public void PumpGas(Vehicle vehicle)
        {
            Console.WriteLine("In the Car Center, we are pumping gas for " + vehicle.Type + ".");
        }

        public void WashCar(Car car)
        {
            Console.WriteLine("In the Car Center, we are washing the car " + car.Type + ".");
        }

        public void WashTrailer(Truck truck)
        {
            Console.WriteLine("In the Car Center, we are washing the trailer " + truck.Type + ".");
        }
    }
}
