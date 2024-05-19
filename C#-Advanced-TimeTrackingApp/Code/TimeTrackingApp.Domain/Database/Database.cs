using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTrackingApp.Domain.Models;

namespace TimeTrackingApp.Domain.Database
{
    public class Database<T> : IDatabase<T> where T : BaseEntity
    {
        public List<T> items { get; set; } //lsita vo koja sto ke se dodavaat useri i aktivnosti
        public int Id { get; set; }
        public Database()
        {
            items = new List<T>();
            Id = 1;
        }

        public List<T> GetAll()
        {
            return items;
        }

        public T GetById(int id)
        {
            T item = items.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                throw new NullReferenceException($"Entity with id {id} was not found");
            }
            return item;
        }

        public int Insert(T entity)
        {
            entity.Id = Id++;
            items.Add(entity);
            return entity.Id;
        }

        public void RemoveById(int id)
        {
            T item = items.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                throw new NullReferenceException($"Entity with id {id} was not found");
            }
            items.Remove(item);
        }

        public void Update(T entity)
        {
            T item = items.FirstOrDefault(x => x.Id == entity.Id);
            if (item == null)
            {
                throw new NullReferenceException($"Entity with id {entity.Id} was not found");
            }

            item = entity;
        }
    }
}
