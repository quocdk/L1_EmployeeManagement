using BUS.Services.Implements;
using BUS.Services.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OccupationsController : ControllerBase
    {
        IOccupationService _occupationService;

        public OccupationsController()
        {
            _occupationService = new OccupationService();
        }

        // GET: api/<OccupationsController>
        [HttpGet]
        public IActionResult Get()
        {
            List<Occupation> occupations = _occupationService.GetList();

            return Ok(occupations);
        }

        // GET api/<OccupationsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            Occupation occupation = _occupationService.GetById(id);

            return Ok(occupation);
        }

        // POST api/<OccupationsController>
        [HttpPost]
        public IActionResult Post([FromBody] Occupation request)
        {
            return Ok(_occupationService.Add(request));
        }

        // PUT api/<OccupationsController>/5
        [HttpPut]
        public IActionResult Put([FromBody] Occupation request)
        {
            return Ok(_occupationService.Update(request));
        }

        // DELETE api/<OccupationsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            return Ok(_occupationService.Delete(id));
        }
    }
}
