using EmployeeManagement.DAL.Contracts;
using EmployeeManagement.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeManagement.DAL.Implementations
{
    public class EmployeeDAL : IEmployeeDAL
    {
        private readonly NLayerPracticeDBContext _context;

        public EmployeeDAL(NLayerPracticeDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public bool SaveEmployee(Employee employee)
        {
            try
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.Find(id);
        }

        public List<Employee> SearchEmployees(Employee search)
        {
            var searchResults = _context.Employees
                                        .Where(x => x.Id == search.Id || search.Id == 0)
                                        .Where(x => x.EName == search.EName || search.EName == null)
                                        .Where(x => x.Salary >= search.Salary || search.Salary == 0)
                                        .Where(x => x.DeptName.ToLower().Contains(search.DeptName.ToLower()) || search.DeptName == null);
            return searchResults.ToList();
        }
    }
}
