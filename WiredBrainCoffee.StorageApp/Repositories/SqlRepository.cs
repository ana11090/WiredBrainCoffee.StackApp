using Microsoft.EntityFrameworkCore;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    public class SqlRepository<T> : IRepository<T> where T : class, IEntityBase
    {
        //protected readonly List<T> _item = new();
        private readonly DbContext _DbContext;
        private readonly DbSet<T> _DbSet;

        public SqlRepository(DbContext dbContext)
        {
            _DbContext = dbContext;
            _DbSet = dbContext.Set<T>();
        }
        public T GetById(int id)
        {
            return _DbSet.Find(id);
        }

        public void Add(T item)
        {
            _DbSet.Add(item);
        }

        public void Save()
        {
            _DbContext.SaveChanges();
        }

        public void Delete(T item)
        {
            _DbSet.Remove(item);
        }

        public IEnumerable<T> GetAll()
        {
            return _DbSet.ToList();
        }
    }

}
