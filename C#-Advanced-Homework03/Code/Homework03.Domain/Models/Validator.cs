using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create a static class called Validator, that contains a method Validate, that receives a Vehicle and validates is Id is not 0,
//that Type is not empty and YearOfProduction is not 0.
namespace Homework03.Domain.Models
{
    public static class Validator
    {
        public static bool Validate(Vehicle vehicle)
        {
            if (vehicle.Id <= 0 || string.IsNullOrEmpty(vehicle.Type) || vehicle.YearOfProduction <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
