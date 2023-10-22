using TShirtCustomizationApp.Repository.Interfaces;

namespace TShirtCustomizationApp.Repository
{
    public class AbstractRepository<T> : IRepository<T> where T : class
    {
        protected AppDbContext _context;

        public AbstractRepository(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IQueryable<T> ListAll()
        {
            return _context.Set<T>();
        }

        void IRepository<T>.Save(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(int id)
        {
            var entity = _context.Set<T>().Find(id);

            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
            }
            else
                throw new EntryPointNotFoundException();
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
