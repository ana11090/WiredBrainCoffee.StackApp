using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public class GenericRepository<T, Tkey>
    { 
        protected readonly List<T> _item = new();
        public Tkey? Key { get; set; }

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


    public class EmployeeRepositoryWithRemove : GenericRepository<Employee, int>
    { 
        public void Remove(Employee employee)
        {
            _item.Remove(employee);
        }
    }

    //public class GenericRepositoryWithRemove<T, Tkey> : GenericRepository<T, Tkey>
    //{
    //    public void Remove(T item)
    //    {
    //        _item.Remove(item);
    //    }
    //}

    public class GenericRepositoryWithRemove<T> : GenericRepository<T, string>
    {
        public void Remove(T item)
        {
            _item.Remove(item);
        }
    }
}
