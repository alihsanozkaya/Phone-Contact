using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Phone_Contact.Business.Abstract;

namespace Phone_Contact.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        IPersonService _personService; 
        public PeopleController(IPersonService personService)
        {

            _personService = personService;

        }


        [HttpGet("/getAllPeople")]

        public async Task<IActionResult> GetAll()
        {
            var result = await _personService.GetListAsync();
            if (result ==null)
            {
                return BadRequest(string.Empty);    
            }
            return Ok(result);
        }
       
    }
}
