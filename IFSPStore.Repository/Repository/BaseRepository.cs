using ConsultorioIFSP.Domain.Base;
using ConsultorioIFSPContext;
using Microsoft.EntityFrameworkCore;

namespace IFSPStore.Repository.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity<int>
    {
        protected readonly MySqlContext _mySqlContext;

        public BaseRepository(MySqlContext mySqlcontext)
        {
            _mySqlContext = mySqlcontext;
        }

        public void AttachObject(object obj)
        {
            _mySqlContext.Attach(obj);
        }

        public void CleanChangeTracker()
        {
            _mySqlContext.ChangeTracker.Clear();
        }

        public void Delete(object id)
        {
            _mySqlContext.Set<TEntity>().Remove(Select(id));
            _mySqlContext.SaveChanges();
        }

        public void Insert(TEntity obj)
        {
            _mySqlContext.Set<TEntity>().Add(obj);
            _mySqlContext.SaveChanges();
        }

        public IList<TEntity> Select(IList<string>? includes = null)
        {
            var dbContext = _mySqlContext.Set<TEntity>().AsQueryable();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    dbContext = dbContext.Include(include);
                }
            }
            return dbContext.ToList();
        }
        public TEntity Select(object id, IList<string>? includes = null)
        {
            var dbContext = _mySqlContext.Set<TEntity>().AsQueryable();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    dbContext = dbContext.Include(include);
                }
            }
            return dbContext.ToList().Find(x => x.Id == (int)id);
        }

        public void Update(TEntity obj)
        {
            // tive que modificar essa parte para funcionar o update
            //antes estava so o saveChanges
            _mySqlContext.ChangeTracker.Clear();
            var local = _mySqlContext.Set<TEntity>()
                .Local
                .FirstOrDefault(entry => entry.Id.Equals(obj.Id));

            if (local != null)
            {
                _mySqlContext.Entry(local).State = EntityState.Detached;
            }

            _mySqlContext.Entry(obj).State = EntityState.Modified;
            _mySqlContext.SaveChanges();
        }
    }
}
