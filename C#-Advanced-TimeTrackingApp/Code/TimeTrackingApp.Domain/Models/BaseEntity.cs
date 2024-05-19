using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrackingApp.Domain.Interfaces;

namespace TimeTrackingApp.Domain.Models
{
    public abstract class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
        public abstract string GetInfo();
    }
}
