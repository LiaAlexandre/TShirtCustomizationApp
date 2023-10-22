using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TShirtCustomizationApp.Entity;
using TShirtCustomizationApp.Repository.Interfaces;

namespace TShirtCustomizationApp.Repository
{
    public class FabricRepository : AbstractRepository<Fabric>, IFabricRepository
    {
        public FabricRepository(AppDbContext context) : base(context)
        {
        }
    }
}
