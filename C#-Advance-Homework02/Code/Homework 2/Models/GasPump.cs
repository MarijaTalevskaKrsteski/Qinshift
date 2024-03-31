using Homework_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2.Models
{
    public class GasPump : IGasPump
    {
        public void PumpGas()
        {
            Console.WriteLine("We are pumping gas");
        }
    }
}
