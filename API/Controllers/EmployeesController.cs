using BUS.Services.Implements;
using BUS.Services.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        IEmployeeService _employeeService;

        public EmployeesController()
        {
            _employeeService = new EmployeeService();
        }

        // GET: api/<EmployeesController>
        [HttpGet]
        public IActionResult Get()
        {
            List<Employee> employees = _employeeService.GetList();

            return Ok(employees);
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            Employee employee = _employeeService.GetById(id);

            return Ok(employee);
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public IActionResult Post([FromBody] Employee request)
        {
            return Ok(_employeeService.Add(request));
        }

        // PUT api/<EmployeesController>/5
        [HttpPut]
        public IActionResult Put([FromBody] Employee request)
        {
            return Ok(_employeeService.Update(request));
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            return Ok(_employeeService.Delete(id));
        }
    }
}
