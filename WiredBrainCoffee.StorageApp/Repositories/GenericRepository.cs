using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public class GenericRepository<T>
    { 
        protected readonly List<T> _item = new();
        public void Add(T item)  => _item.Add(item);

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
