using Homework_2.Models;
namespace Homework_2.Interfaces
{
    public interface ICarWash
    {
        void WashCar(Car car);
        void WashTrailer(Truck truck);
    }
}
