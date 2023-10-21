using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShirtCustomizationApp.Entity.Interfaces
{
    public interface IItemColor : IEntity
    {
        public string Name { get; set; }

        public int ItemId { get; set; }
    }
}
