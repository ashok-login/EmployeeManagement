using EmployeeManagement.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL.Contracts
{
    public interface IEmployeeDAL
    {
        bool SaveEmployee(Employee employee);
        List<Employee> GetAll();
        Employee GetEmployeeById(int id);
        List<Employee> SearchEmployees(Employee search);
    }
}
