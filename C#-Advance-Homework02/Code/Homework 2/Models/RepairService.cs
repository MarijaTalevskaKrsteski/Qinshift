using Homework_2.Interfaces;
namespace Homework_2.Models
{
    public class RepairService : IRepairService
    {
        public RepairService() { }

        public void CheckVehicle(Vehicle vehicle)
        {
            Console.WriteLine("You are at the repair service. We are checking the vehicle: " + vehicle.Type);
        }

        public void FixVehicle(Vehicle vehicle)
        {
            Console.WriteLine("You are at the repair service. We are fixing the vehicle: " + vehicle.Type);
        }
    }
}
