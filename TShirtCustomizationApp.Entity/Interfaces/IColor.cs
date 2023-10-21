using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShirtCustomizationApp.Entity.Interfaces
{
    public interface IColor: IEntity
    {
        public string Name { get; set; }
    }
}
