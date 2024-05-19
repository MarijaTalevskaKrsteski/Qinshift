using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrackingApp.Domain.Database;
using TimeTrackingApp.Domain.Models;
using TimeTrackingApp.Services.Helpers;
using TimeTrackingApp.Services.Interfaces;

namespace TimeTrackingApp.Services.Implementations
{
    public class UserService<T> : IUserService<T> where T : User
    {
        private IDatabase<T> _database;

        public UserService()
        {         
            _database = new Database<T>();
        }

        public List<T> GetAll()
        {
            List<T> items = _database.GetAll();
            return items;
        }

        public T Login(string username, string password)
        {
            //BONUS: If the user do not guess their username and password 3 times, the application should close with a goodbye message
            // 1. Search through all user for a user with the given username and password

            // 1.1. Get all users
            List<T> allUsers = _database.GetAll();

            // 1.2. Search
            T user = allUsers.FirstOrDefault(x => x.Username == username && x.Password == password);

            if (user == null)
            {
                throw new Exception("Wrong username or password.");
            }

            // 2. Return the user
            return user;
        }

        public T Register(T newUser)
        {
            if (newUser == null)
            {
                throw new Exception("User cannot be null.");
            }

            List<T> items = GetAll();
            bool alreadyExists = items.Any(x => x.Username.ToLower() == newUser.Username.ToLower());
            if (alreadyExists)
            {
                throw new Exception("User already exists.");
            }

            if (!ValidationHelper.ValidateName(newUser.FirstName))
            {
                throw new Exception("Invalid first name value.");
            }

            if (!ValidationHelper.ValidateName(newUser.LastName))
            {
                throw new Exception("Invalid last name value.");
            }

            if (!ValidationHelper.ValidateUsername(newUser.Username))
            {
                throw new Exception("Invalid username value.");
            }

            if (!ValidationHelper.ValidatePassword(newUser.Password))
            {
                throw new Exception("Invalid password value.");
            }

            if (!ValidationHelper.ValidateAge(newUser.Age))
            {
                throw new Exception("Invalid age value.");
            }

            int id = _database.Insert(newUser);

            T user = _database.GetById(id);
            return user;
        }

        public T ChangeFirstName(int userId, string firstName)
        {
            T user = _database.GetById(userId);
            if (user == null)
            {
                throw new Exception($"User with id {userId} was not found in the db");
            }
            if (!ValidationHelper.ValidateName(firstName))
            {
                throw new Exception("Invalid first name or last name");
            }
            user.FirstName = firstName;
            _database.Update(user);
            return user;
        }

        public T ChangeLastName(int userId, string lastName)
        {
            T user = _database.GetById(userId);
            if (user == null)
            {
                throw new Exception($"User with id {userId} was not found in the db");
            }
            if (!ValidationHelper.ValidateName(lastName))
            {
                throw new Exception("Invalid first name or last name");
            }
            user.LastName = lastName;
            _database.Update(user);
            return user;
        }

        public T ChangePassword(int userId, string oldPassword, string newPassword)
        {
            T user = _database.GetById(userId);
            if (user == null)
            {
                throw new Exception($"User with id {userId} was not found in the db");
            }
            if (user.Password != oldPassword)
            {
                throw new Exception("Old passwords do not match");
            }

            if (!ValidationHelper.ValidatePassword(newPassword))
            {
                throw new Exception("Invalid password");
            }

            user.Password = newPassword;
            _database.Update(user);
            return user;
        }
    }
}