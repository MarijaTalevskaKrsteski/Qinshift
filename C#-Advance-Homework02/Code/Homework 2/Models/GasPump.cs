using Homework_2.Interfaces;
namespace Homework_2.Models
{
    public class GasPump : IGasPump
    {
        public GasPump() { }

        public void PumpGas(Vehicle vehicle)
        {
            Console.WriteLine($"You are at the gas station. We are pumping gas for {vehicle.Type}.");
        }
    }
}
