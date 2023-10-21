﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TShirtCustomizationApp.Entity.Interfaces;

namespace TShirtCustomizationApp.Repository.Interfaces
{
    public interface IImageRepository<IImage> : IRepository<IEntity>
    {
        public IList<IImage> GetByItemId(int itemId);
    }
}