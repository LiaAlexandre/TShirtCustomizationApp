using Microsoft.AspNetCore.Mvc;
using TShirtCustomizationApp.API.Models;
using TShirtCustomizationApp.Service.Interfaces;

namespace TShirtCustomizationApp.API.Controllers
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
        [Route("ListAll")]
        public ObjectResult ListAllItems()
        {
            try
            {
                var model = _itemService.ListAllItems();

                return Ok(model);
            }
            catch (Exception) { }

            return BadRequest($"Request failed.");
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public ObjectResult GetById(int id)
        {
            try
            {
                var model = _itemService.GetById(id);

                return Ok(model);
            }
            catch (Exception) { }

            return BadRequest($"Request failed. ID:{id}");
        }

        [HttpDelete]
        [Route("RemoveImage")]
        public ObjectResult RemoveImage(int imageId)
        {
            try
            {
                _itemService.RemoveImage(imageId);

                return Ok("Request processed.");
            }
            catch (Exception) { }

            return BadRequest($"Request failed. Image ID:{imageId}");
        }

        [HttpPost]
        [Route("AddImage")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public ObjectResult AddImage([FromBody] AddImageModel model)
        {
            try
            {
                _itemService.AddImage(model.ItemId, model.ColorId, model.FabricId, model.Image64);

                return Ok("Request processed.");
            }
            catch (Exception) { }

            return BadRequest($"Request failed. Item ID: {model.ItemId}");
        }
    }
}
