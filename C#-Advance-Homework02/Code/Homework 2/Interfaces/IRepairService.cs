using Homework_2.Models;
namespace Homework_2.Interfaces
{
    public interface IRepairService
    {
        void CheckVehicle(Vehicle vehicle);
        void FixVehicle(Vehicle vehicle);
    }
}
