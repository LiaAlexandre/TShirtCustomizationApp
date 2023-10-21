using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TShirtCustomizationApp.Entity.Interfaces;

namespace TShirtCustomizationApp.Repository.Interfaces
{
    public interface IRepository<T> where T : IEntity
    {
        T GetById(int id);

        IList<T> ListAll();
        
        T Add(T entity);

        void Delete(int id);
    }
}
