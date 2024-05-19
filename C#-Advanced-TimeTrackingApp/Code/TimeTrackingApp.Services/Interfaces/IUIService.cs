using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrackingApp.Domain.Models;

namespace TimeTrackingApp.Services.Interfaces
{
    public interface IUIService
    {
        User FillRegisterData();
        string PrintMenu(List<string> menuItems);
    }
}
