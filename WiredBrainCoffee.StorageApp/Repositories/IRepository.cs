using WiredBrainCoffee.StorageApp.Entities;
using System.Collections.Generic;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public interface IReadRepository<out T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
    public interface IRepository<T>: IReadRepository<T> where T :  IEntityBase
    {
        void Add(T item);
        void Delete(T item);
       
        void Save();
    }
}