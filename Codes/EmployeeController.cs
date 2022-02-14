using assignmentcore.EmployeeData;
using assignmentcore.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignmentcore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeData _employeeData;
        public EmployeeController(IEmployeeData employeeData)
        {
            _employeeData = employeeData;

        }
        [HttpGet]
        [Route("api/[controller]")]

        public IActionResult GetEmployees()
        {
            return Ok(_employeeData.GetEmployees());
        }
        [HttpGet]
        [Route("api/[controller]/{id}")]

        public IActionResult GetEmployee(Guid id)
        {
        var employee = _employeeData.GetEmployee(id);

        if(employee !=null)
            
        {
            return Ok(employee);

        }
         return NotFound ($"Employee with Id: {id} was not found");
    }
        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult GetEmployee(Employee employee)
        {
            _employeeData.AddEmployee(employee);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + employee.Id, employee);
                }

    }
}
