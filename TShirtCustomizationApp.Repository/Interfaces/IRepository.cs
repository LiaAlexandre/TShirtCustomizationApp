namespace TShirtCustomizationApp.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T GetById(int id);

        IQueryable<T> ListAll();
        
        void Save(T entity);

        void Delete(int id);

        void Commit();
    }
}
