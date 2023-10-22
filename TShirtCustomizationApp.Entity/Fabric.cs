using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TShirtCustomizationApp.Entity.Interfaces;

namespace TShirtCustomizationApp.Entity
{
    public class Fabric : IFabric
    {
        public string Name {get;set;}
        public int Id { get; set; }
    }
}
