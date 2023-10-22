using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TShirtCustomizationApp.Entity.Interfaces;

namespace TShirtCustomizationApp.Entity
{
    public class ItemFabric : IItemFabric
    {
        public int Id { get; set; }

        public int ItemId { get; set; }

        public int FabricId { get; set; }
    }
}
