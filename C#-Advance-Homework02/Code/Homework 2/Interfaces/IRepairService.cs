using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//IRepairService that has methods CheckVehicle and FixVehicle that work for all vehicles.
namespace Homework_2.Interfaces
{
    public interface IRepairService
    {
        void CheckVehicle();
        void FixVehicle();
    }
}
