﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShirtCustomizationApp.Entity.Interfaces
{
    public interface IFabric : IEntity
    {
        public string Name { get; set; }
    }
}
