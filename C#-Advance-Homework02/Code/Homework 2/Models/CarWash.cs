using Homework_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2.Models
{
    public class CarWash : ICarWash
    {
        public void WashCar()
        {
            Console.WriteLine("We are washing the car.");
        }

        public void WashTrailer()
        {
            Console.WriteLine("We are washing the trailer.");
        }
    }
}
