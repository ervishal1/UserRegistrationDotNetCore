using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserRegistrationDotNetCore.Data;
using UserRegistrationDotNetCore.Models;

namespace UserRegistrationDotNetCore.Repo
{
    public class EmployeeRepo : IEmployee
    {
        private readonly DataContext _context;

        public EmployeeRepo(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employee GetById(int Id)
        {
            return _context.Employees.Where(x => x.Id == Id).FirstOrDefault();
        }
    }
}
