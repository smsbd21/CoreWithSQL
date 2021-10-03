using System.Linq;
using SqlCoreCrud.Models;
using SqlCoreCrud.IServices;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SqlCoreCrud.Services
{
    public class EmployeeService: IEmployeeService
    {
        private readonly APICoreDBContext dbContext;
        public EmployeeService(APICoreDBContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public Employee AddEmployee(Employee emp)
        {
            if(emp != null)
            {
                dbContext.Employee.Add(emp);
                dbContext.SaveChanges();
                return emp;
            }
            return null;
        }

        public Employee EditEmployee(Employee emp)
        {
            dbContext.Entry(emp).State = EntityState.Modified;
            dbContext.SaveChanges();
            return emp;
        }

        public Employee DeleteEmployee(int id)
        {
            var emp = dbContext.Employee.FirstOrDefault(x => x.Id == id);
            dbContext.Entry(emp).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return emp;
        }

        public Employee GetEmployeeById(int id)
        {
            return dbContext.Employee.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return dbContext.Employee.ToList();
        }
    }
}
