using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Phone_Contact.Business.Abstract;
using Phone_Contact.Entities.Dtos.Person;
using Phone_Contact.Entities.Entities;
using System.Linq.Expressions;

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

        [HttpGet("/getById")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _personService.GetAsync(x => x.Id == id);
            if (result == null)
            {
                return BadRequest(string.Empty);
            }
            return Ok(result);
        }


        [HttpPost("/addNewPerson")]
        public async Task<IActionResult> AddNewPerson(PersonAddDto personAddDto)
        {
            var result = await _personService.AddAsync(personAddDto);
            if (result == null)
            {
                return BadRequest(string.Empty);
            }
            return Ok(result);
        }


        [HttpDelete("/person/{id}/delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _personService.DeleteAsync(id);
            if (result == null)
            {
                return BadRequest(string.Empty);
            }
            return Ok(result.Message);
        }

        [HttpPut("/person/{id}/update")]    
        public async Task<IActionResult> Update(PersonUpdateDto personUpdateDto)
        {
            
            var result = await _personService.UpdateAsync(personUpdateDto);
            
            if (result == null) 
            {
                return BadRequest(string.Empty);
            }
            return Ok(result.Message);
        }
    }
}
