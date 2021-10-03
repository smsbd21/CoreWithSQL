using SqlCoreCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlCoreCrud.IServices
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeById(int id);
        Employee DeleteEmployee(int id);
        Employee AddEmployee(Employee emp);
        Employee EditEmployee(Employee emp);
    }
}
