using Microsoft.EntityFrameworkCore;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public class ListRepository<T> : IRepository<T> where T : IEntityBase
    {
        protected readonly List<T> _item = new();

       
        public T GetById(int id)
        {
            return _item.Single(_item => _item.ID == id);
            //return null;
        }

        public void Add(T item)
        {
            item.ID =_item.Any() ? _item.Max(item => item.ID) + 1 : 1;
            _item.Add(item);
        }

        public void Save(T item)
        {
            Console.WriteLine(item);
        }
        public void Delete(T item)
        {
             
        } 
        public void Save()
        {
            foreach(var item in _item)
            {
                Console.WriteLine(item);
            }
        }

        public IEnumerable<T> GetAll()
        {
           return _item.ToList(); //it returns a copy, not the actual list
        }
    }

}
