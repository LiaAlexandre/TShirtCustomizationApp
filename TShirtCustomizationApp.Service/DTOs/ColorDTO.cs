using TShirtCustomizationApp.Service.DTOs.Interfaces;

namespace TShirtCustomizationApp.Service.DTOs
{
    public  class ColorDTO: IColorDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
