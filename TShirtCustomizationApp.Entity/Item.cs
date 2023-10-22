using TShirtCustomizationApp.Entity.Interfaces;

namespace TShirtCustomizationApp.Entity
{
    public class Item : IItem
    {
        public string Name {get;set;}
        public int Id { get; set; }
    }
}
