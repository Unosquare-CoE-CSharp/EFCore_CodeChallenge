using EFChallenge.Data.Models.Company;
using EFChallenge.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EFChallenge.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController : Controller
    {
        ICompanyService _companyService;
        public CompanyController(ICompanyService companyService) => _companyService = companyService;

        [HttpPost("CreateCountry")]
        public IActionResult CreateCountry([FromBody] Country country)
        {
            try
            {
                var result = _companyService.AddCountry(country);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("UpdateCountry")]
        public IActionResult UpdateCountry([FromBody] Country country)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = _companyService.UpdateCountry(country);
                    if (result == null)
                    {
                        return NotFound();
                    }
                    return Ok(result);
                } else { return BadRequest(); }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }

        [HttpDelete("DeleteCountry/{id}")]
        public IActionResult DeleteCountry(int id)
        {
            try
            {
                var result = _companyService.DeleteCountry(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("GetCountry")]
        public IActionResult GetCountry()
        {
            try
            {
                var result = _companyService.GetCountry();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }



        //[HttpDelete("DeleteCountry")]
        //public IActionResult DeleteCountry(Country country)
        //{
        //    try
        //    {
        //        var c = _companyService.DeleteCountry(country.Id);
        //        return Ok(c);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex);
        //    }
        //}
    }
}
