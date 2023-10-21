using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShirtCustomizationApp.Entity.Interfaces
{
    public interface IItem: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
