using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTrackingApp.Domain.Models
{
    public class User : BaseEntity 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public override string GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}
