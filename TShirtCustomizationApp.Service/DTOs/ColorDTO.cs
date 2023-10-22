using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TShirtCustomizationApp.Service.DTOs.Interfaces;

namespace TShirtCustomizationApp.Service.DTOs
{
    public  class ColorDTO: IColorDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
