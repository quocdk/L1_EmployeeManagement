using BUS.Services.Implements;
using BUS.Services.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiplomasController : ControllerBase
    {
        IDiplomaService _diplomaService;

        public DiplomasController()
        {
            _diplomaService = new DiplomaService();
        }

        // GET: api/<DiplomasController>
        [HttpGet]
        public IActionResult Get()
        {
            List<Diploma> diplomas = _diplomaService.GetList();

            return Ok(diplomas);
        }

        // GET api/<DiplomasController>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            Diploma diploma = _diplomaService.GetById(id);

            return Ok(diploma);
        }

        // POST api/<DiplomasController>
        [HttpPost]
        public IActionResult Post([FromBody] Diploma request)
        {
            return Ok(_diplomaService.Add(request));
        }

        // PUT api/<DiplomasController>/5
        [HttpPut]
        public IActionResult Put([FromBody] Diploma request)
        {
            return Ok(_diplomaService.Update(request));
        }

        // DELETE api/<DiplomasController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            return Ok(_diplomaService.Delete(id));
        }
    }
}
