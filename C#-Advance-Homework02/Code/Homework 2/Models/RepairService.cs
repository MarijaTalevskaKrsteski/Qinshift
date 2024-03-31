using Homework_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2.Models
{
    public class RepairService : IRepairService
    {
        public void CheckVehicle()
        {
            Console.WriteLine("We are checking the vehicle.");
        }

        public void FixVehicle()
        {
            Console.WriteLine("We are fixing the vehicle.");
        }
    }
}
