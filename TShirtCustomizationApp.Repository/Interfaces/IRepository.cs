﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TShirtCustomizationApp.Entity.Interfaces;

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
