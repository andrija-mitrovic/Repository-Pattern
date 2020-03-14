using RepositoryPattern.Data;
using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Data.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var employee = GetById(id);
            _context.Employees.Remove(employee);
        }

        public IEnumerable<Employee> GetAll() => _context.Employees.ToList();

        public Employee GetById(int id) => _context.Employees.Find(id);

        public void Update(Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();
        }
    }
}
