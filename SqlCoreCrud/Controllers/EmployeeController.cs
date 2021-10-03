using SqlCoreCrud.Models;
using SqlCoreCrud.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SqlCoreCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService employeeService;
        public EmployeeController(IEmployeeService _employeeService)
        {
            employeeService = _employeeService;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Employee/GetEmployee")]
        public IEnumerable<Employee> GetEmployees()
        {
            return employeeService.GetEmployees();
        }
        [HttpPost]
        [Route("[action]")]
        [Route("api/Employee/AddEmployee")]
        public Employee AddEmployee(Employee emp)
        {
            return employeeService.AddEmployee(emp);
        }
        [HttpPut]
        [Route("[action]")]
        [Route("api/Employee/EditEmployee")]
        public Employee EditEmployee(Employee emp)
        {
            return employeeService.EditEmployee(emp);
        }
        [HttpDelete]
        [Route("[action]")]
        [Route("api/Employee/DeleteEmployee")]
        public Employee DeleteEmployee(int id)
        {
            return employeeService.DeleteEmployee(id);
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Employee/GetEmployeeById")]
        public Employee GetEmployeeById(int id)
        {
            return employeeService.GetEmployeeById(id);
        }
    }
}
