using Microsoft.AspNetCore.Mvc;
using TShirtCustomizationApp.Service.DTOs.Interfaces;
using TShirtCustomizationApp.Service.Interfaces;

namespace TShirtCustomizationApp.API
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly ILogger<ItemController> _logger;
        private readonly IItemService _itemService;

        public ItemController(ILogger<ItemController> logger, IItemService itemService)
        {
            _logger = logger;
            _itemService = itemService;
        }

        [HttpGet]
        public IList<IItemListDTO> ListAllItems()
        {
            return _itemService.ListAllItems();   
        }
    }
}
