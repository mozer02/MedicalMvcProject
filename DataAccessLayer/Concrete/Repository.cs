using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Repository<T> : RepositoryBase, IRepository<T> where T : class
    {
        DbSet<T> _obj;
        public Repository()
        {
            _obj = db.Set<T>();
        }
        public int Delete(T obj)
        {
            _obj.Remove(obj);
            return Save();
        }

        public T Find(Expression<Func<T, bool>> find)
        {
            return _obj.FirstOrDefault(find);
        }

        public int Insert(T obj)
        {
            _obj.Add(obj);
            return Save();
        }

        public List<T> List()
        {
            return _obj.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> where)
        {
            return _obj.Where(where).ToList();
        }

        public IQueryable<T> QList(Expression<Func<T, bool>> query)
        {
            return _obj.Where(query);
        }

        public int Save()
        {
            return db.SaveChanges();
        }

        public int Update(T obj)
        {
            return Save();
        }
    }
}
