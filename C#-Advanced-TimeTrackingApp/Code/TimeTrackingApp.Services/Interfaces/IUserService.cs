using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrackingApp.Domain.Models;

namespace TimeTrackingApp.Services.Interfaces
{
    public interface IUserService<T> where T : User
    {
        T Register(T newUser); 
        T Login(string username, string password); 
        List<T> GetAll(); 
        T ChangeFirstName(int userId, string firstName);
        T ChangeLastName(int userId, string lastName);
        T ChangePassword(int userId, string oldPassword, string newPassword);
    }
}