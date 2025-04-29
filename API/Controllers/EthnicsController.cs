using BUS.Services.Implements;
using BUS.Services.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EthnicsController : ControllerBase
    {
        IEthnicService _ethnicService;

        public EthnicsController()
        {
            _ethnicService = new EthnicService();
        }

        // GET: api/<EthnicsController>
        [HttpGet]
        public IActionResult Get()
        {
            List<Ethnic> ethnics = _ethnicService.GetList();

            return Ok(ethnics);
        }

        // GET api/<EthnicsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            Ethnic ethnic = _ethnicService.GetById(id);

            return Ok(ethnic);
        }

        // POST api/<EthnicsController>
        [HttpPost]
        public IActionResult Post([FromBody] Ethnic request)
        {
            return Ok(_ethnicService.Add(request));
        }

        // PUT api/<EthnicsController>/5
        [HttpPut]
        public IActionResult Put([FromBody] Ethnic request)
        {
            return Ok(_ethnicService.Update(request));
        }

        // DELETE api/<EthnicsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            return Ok(_ethnicService.Delete(id));
        }
    }
}
