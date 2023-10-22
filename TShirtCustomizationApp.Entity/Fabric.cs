using TShirtCustomizationApp.Entity.Interfaces;

namespace TShirtCustomizationApp.Entity
{
    public class Fabric : IFabric
    {
        public string Name {get;set;}
        public int Id { get; set; }
    }
}
