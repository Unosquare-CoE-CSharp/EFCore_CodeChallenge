using EFChallenge.Data.Models.Item;
using EFChallenge.DTOs.ItemDTOs;
using EFChallenge.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EFChallenge.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
        IItemService _itemService;
        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpPost("CreateItem")]
        public IActionResult CreateItem([FromBody] ItemDto itemDto)
        {
            try
            {
                var result = _itemService.AddItem(itemDto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateItem")]
        public IActionResult UpdateItem([FromBody] ItemDto itemDto)
        {
            
            try
            {
                if (ModelState.IsValid) 
                {
                    var result = _itemService.UpdateItem(itemDto);
                    if (result == null)
                    {
                        return NotFound();
                    }
                    return Ok(result);
                }
                else { return BadRequest(); }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }

        [HttpDelete("DeleteItem/{id}")]
        public IActionResult DeleteItem(Guid id)
        {
            try
            {
                var result = _itemService.DeleteItem(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetItemReport")]
        public IActionResult GetReport()
        {
            try
            {
                var result = _itemService.GetItemReport();
                return Ok(result);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        
    }
}
