using Homework_2.Interfaces;
namespace Homework_2.Models
{
    public class CarWash : ICarWash
    {
        public CarWash() { }

        public void WashCar(Car car)
        {
            Console.WriteLine("You are in the car wash. We are washing the car of type " + car.Type + ".");
        }

        public void WashTrailer(Truck truck)
        {
            Console.WriteLine($"You are in the car wash. We are washing the trailer {truck.Wheels} wheels.");
        }
    }
}
