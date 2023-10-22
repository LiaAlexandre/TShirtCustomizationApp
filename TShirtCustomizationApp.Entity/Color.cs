using TShirtCustomizationApp.Entity.Interfaces;

namespace TShirtCustomizationApp.Entity
{
    public class Color : IColor
    {
        public string Name {get;set;}
        public int Id { get; set; }
    }
}
