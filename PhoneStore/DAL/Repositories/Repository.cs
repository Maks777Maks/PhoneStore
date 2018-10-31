using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class Repository<T> : IRepos<T> where T : class
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _set;

        public Repository(DbContext db)
        {
            _context = db;
            _set = db.Set<T>();
        }

        public void Create(T entity)
        {
            _set.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _set.Attach(entity);
            _set.Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _set.AsNoTracking<T>().AsEnumerable();
        }

        public T GetById(int id)
        {
            return _set.Find(id);
        }

        public void Update(T entity)
        {
            _context.Entry<T>(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
