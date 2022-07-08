using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFChallenge.API.Controllers
{
    [Route("api/itemtype"), ApiController]
    public class ItemTypeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll([FromServices]EFChallenge.Data.EFChallengeDbContext dbContext)
        {
            var itemTypes = dbContext.ItemTypes.AsNoTracking().ToList();
            return Ok(itemTypes);
        }
    }
}
