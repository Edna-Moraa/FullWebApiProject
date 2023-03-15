using ApiOne.Services.ItemService;
using Microsoft.AspNetCore.Mvc;

namespace ApiOne.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }
        
    [HttpGet]
    public async Task<ActionResult<List<Item>>> GetAllItems(){
        return _itemService.GetAllItems();
       
    }

    [HttpGet("{id}")]

     public async Task<ActionResult<Item>> GetSingleItem(int id){
       
        var result = _itemService.GetSingleItem(id);
        if (result is null)
        
            return NotFound("Sorry item does not exist");
        
        return Ok(result);
  
    }
    
     [HttpPost]
    public async Task<ActionResult<List<Item>>> AddItems(Item item1){
        var result = _itemService.AddItems(item1);
        return Ok(result);
    }
    [HttpPut("{id}")]

     public async Task<ActionResult<List<Item>>> UpdateItem(int id, Item request)
     {
       
        var result = _itemService.UpdateItem(id, request);
        if (result is null)
            return NotFound("item not found");
        return Ok(result);
  
    }
    [HttpDelete("{id}")]

     public async Task<ActionResult<List<Item>>> DeleteItem(int id){
       
        var result = _itemService.DeleteItem(id);
        if (result is null)
            return NotFound("item not found");
        return Ok(result);
  
    }
    
    }


} 
