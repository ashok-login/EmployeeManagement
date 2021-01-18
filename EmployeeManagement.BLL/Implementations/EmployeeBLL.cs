using EmployeeManagement.BLL.Contracts;
using EmployeeManagement.DAL.Contracts;
using EmployeeManagement.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.BLL.Implementations
{
    public class EmployeeBLL : IEmployeeBLL
    {
        private readonly IEmployeeDAL _dal;

        public EmployeeBLL(IEmployeeDAL dal)
        {
            _dal = dal ?? throw new ArgumentNullException(nameof(dal));
        }

        public List<Employee> GetAll()
        {
            // You can add any business logic layer code here.
            return _dal.GetAll();
        }

        public Employee GetEmployeeById(int id)
        {
            return _dal.GetEmployeeById(id);
        }

        public bool SaveEmployee(Employee employee)
        {
            return _dal.SaveEmployee(employee);
        }

        public List<Employee> SearchEmployees(Employee search)
        {
            return _dal.SearchEmployees(search);
        }
    }
}
