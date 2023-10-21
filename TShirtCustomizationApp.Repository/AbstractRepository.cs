using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TShirtCustomizationApp.Entity.Interfaces;
using TShirtCustomizationApp.Repository.Interfaces;

namespace TShirtCustomizationApp.Repository
{
    public abstract class AbstractRepository: IRepository<IEntity>
    {
        protected readonly DbContext _context;
        protected readonly DbSet<IEntity> _set;

        public AbstractRepository(DbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _set = context.Set<IEntity>();
        }

        public IEntity Add(IEntity entity)
        {
            var entityEntry = _set.Add(entity);

            _context.SaveChanges();

            return entityEntry;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<IEntity> ListAll()
        {
            return _set.ToList();
        }

        IEntity IRepository<IEntity>.GetById(int id)
        {
            return _set.Find(id);
        }
    }
}
