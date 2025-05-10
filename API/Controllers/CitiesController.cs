using BUS.Services.Implements;
using BUS.Services.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        ICityService _cityService;

        public CitiesController()
        {
            _cityService = new CityService();
        }

        // GET: api/<CitiesController>
        [HttpGet]
        public IActionResult Get()
        {
            List<City> cities = _cityService.GetList();

            return Ok(cities);
        }

        // GET api/<CitiesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            City city = _cityService.GetById(id);

            return Ok(city);
        }
        //[HttpGet("{name}")]
        //public IActionResult Get(string name)
        //{
        //    City city = _cityService.GetByName(name);

        //    return Ok(city);
        //}

        // POST api/<CitiesController>
        [HttpPost]
        public IActionResult Post([FromBody] City request)
        {
            return Ok(_cityService.Add(request));
        }

        // PUT api/<CitiesController>/5
        [HttpPut]
        public IActionResult Put([FromBody] City request)
        {
            return Ok(_cityService.Update(request));
        }

        // DELETE api/<CitiesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            return Ok(_cityService.Delete(id));
        }
    }
}
