using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public class GenericRepository<T> where T : class, IEntityBase
    {
        protected readonly List<T> _item = new();

        public T CreateItem()
        {
            return new T();
        }
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

        internal void Save()
        {
            foreach(var item in _item)
            {
                Console.WriteLine(item);
            }
        }
    }


  
}
