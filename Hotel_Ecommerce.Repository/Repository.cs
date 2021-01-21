using Hotel_Ecoomerce.DAL.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
namespace Hotel_Ecommerce.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DatabaseContext _context;
        private DbSet<T> _dbset;

        public Repository(DatabaseContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }

        public void Delete(object EntityID)
        {
            T Entity = _dbset.Find(EntityID);
            Delete(Entity);

        }

        public void Delete(T Entity)
        {
            if (_context.Entry(Entity).State == EntityState.Detached)//Eş zamanlı işlem kontrolü
            {
                _dbset.Attach(Entity);
            }
            _dbset.Remove(Entity);

        }
        public T GetByID(string Id)
        {
            return _dbset.Find(Id);
        }


        public void Insert(T Entity)
        {
            _dbset.Add(Entity);

        }

        public IEnumerable<T> Select(Expression<Func<T, bool>> Filter = null)
        {
            if (Filter != null)
            {
                return _dbset.Where(Filter);
            }
            return _dbset;
        }

        public void Update(T Entity)
        {
            _dbset.Attach(Entity);
            _context.Entry(Entity).State = EntityState.Modified;

        }
        public ICollection<T> GetAll()
        {
            return _dbset.AsEnumerable<T>().ToList();
        }
        public List<T> ToList()
        {

            try
            {
                var tesasd = _dbset.ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
            return _dbset.ToList();
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return _dbset.FirstOrDefault(where);
        }

        public bool Any(Expression<Func<T, bool>> where)
        {
            return _dbset.Any(where);
        }

        public List<T> Where(Expression<Func<T, bool>> where)
        {

            return _dbset.Where(where).ToList();

        }

        public void DeleteListEntity(List<T> Entity)
        {
            _dbset.RemoveRange(Entity);

        }

        public void InsertListEntity(List<T> Entity)
        {
            _dbset.AddRange(Entity);

        }
        public void UpdateRange(List<T> Entities)
        {
            for (int i = 0; i < Entities.Count; i++)
            {
                _dbset.Attach(Entities[i]);
                _context.Entry(Entities[i]).State = EntityState.Modified;
            }
        }


        public virtual void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);

        }

        public virtual void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);

        }

        public IQueryable<T> OrderBy<TKey>(Expression<Func<T, TKey>> orderBy, bool isDesc)
        {
            if (isDesc)
                return _dbset.OrderByDescending(orderBy);
            return _dbset.OrderBy(orderBy);
        }

        public T SingleOrDefault(Expression<Func<T, bool>> where)
        {
            return _dbset.SingleOrDefault(where);
        }

        public T First()
        {
            return _dbset.First();
        }


        public T LastOrDefault(Expression<Func<T, bool>> where)
        {
            return _dbset.LastOrDefault(where);
        }

        public T Single()
        {
            return _dbset.Single();

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public T FirstOrDefault(Expression<Func<T, bool>> where)
        {
            return _dbset.FirstOrDefault(where);
        }

        public IEnumerable<T> WhereDynamicLinq(string query)
        {
            return _dbset.Where(query).ToList();
        }

        public IEnumerable<T> WhereDynamicLinqString(string query, string columnName, List<string> filterList, Func<T, bool> where)
        {
            return _dbset.Where(query).ToList();
        }
        public IEnumerable<T> WhereAndDynamicLinqString(Expression<Func<T, bool>> where, string query)
        {
            return _dbset.Where(where).Where(query).ToList();
        }

      

        public int Count(Expression<Func<T, bool>> where)
        {
            return _dbset.Where(where).Count();
        }

        public List<T> AsQueryable(Expression<Func<T, bool>> predicate)
        {
            return _dbset.AsQueryable().ToList();
        }

        public List<T> Contains(string MongoColumnName, string MongoValue, Expression<Func<T, bool>> Sqlpredicate)
        {
            return _dbset.Where(Sqlpredicate).ToList();
        }
         
    }
}
