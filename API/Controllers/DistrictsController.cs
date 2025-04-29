using BUS.Services.Implements;
using BUS.Services.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictsController : ControllerBase
    {
        IDistrictService _districtService;

        public DistrictsController()
        {
            _districtService = new DistrictService();
        }

        // GET: api/<DistrictsController>
        [HttpGet]
        public IActionResult Get()
        {
            List<District> districts = _districtService.GetList();

            return Ok(districts);
        }

        // GET api/<DistrictsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            District district = _districtService.GetById(id);

            return Ok(district);
        }

        // POST api/<DistrictsController>
        [HttpPost]
        public IActionResult Post([FromBody] District request)
        {
            return Ok(_districtService.Add(request));
        }

        // PUT api/<DistrictsController>/5
        [HttpPut]
        public IActionResult Put([FromBody] District request)
        {
            return Ok(_districtService.Update(request));
        }

        // DELETE api/<DistrictsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            return Ok(_districtService.Delete(id));
        }
    }
}
