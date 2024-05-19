using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrackingApp.Domain.Models;

namespace TimeTrackingApp.Domain.Database
{
    public interface IDatabase<T> where T : BaseEntity
    {
        //CRUD metodi
        List<T> GetAll(); //read
        T GetById (int id); //read
        int Insert(T entity); //create
        void Update(T entity); //update
        void RemoveById(int id); //delete
    }
}
