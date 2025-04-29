using BUS.Services.Implements;
using BUS.Services.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommunesController : ControllerBase
    {
        ICommuneService _communeService;

        public CommunesController()
        {
            _communeService = new CommuneService();
        }

        // GET: api/<CommunesController>
        [HttpGet]
        public IActionResult Get()
        {
            List<Commune> communes = _communeService.GetList();

            return Ok(communes);
        }

        // GET api/<CommunesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            Commune commune = _communeService.GetById(id);

            return Ok(commune);
        }

        // POST api/<CommunesController>
        [HttpPost]
        public IActionResult Post([FromBody] Commune request)
        {
            return Ok(_communeService.Add(request));
        }

        // PUT api/<CommunesController>/5
        [HttpPut]
        public IActionResult Put([FromBody] Commune request)
        {
            return Ok(_communeService.Update(request));
        }

        // DELETE api/<CommunesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            return Ok(_communeService.Delete(id));
        }
    }
}
