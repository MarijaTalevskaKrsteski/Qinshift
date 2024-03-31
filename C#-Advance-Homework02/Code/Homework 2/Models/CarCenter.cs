using Homework_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2.Models
{
    public class CarCenter : ICarWash, IGasPump, IRepairService
    {
        public void CheckVehicle()
        {
            Console.WriteLine("In the Car Center, we are checking the vehicle.");
        }

        public void FixVehicle()
        {
            Console.WriteLine("In the Car Center, we are fixing the vehicle.");
        }

        public void PumpGas()
        {
            Console.WriteLine("In the Car Center, we are pumping gas.");
        }

        public void WashCar()
        {
            Console.WriteLine("In the Car Center, we are washing the car.");
        }

        public void WashTrailer()
        {
            Console.WriteLine("In the Car Center, we are washing the trailer.");
        }
    }
}
