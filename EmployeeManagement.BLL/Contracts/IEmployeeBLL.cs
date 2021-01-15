using EmployeeManagement.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.BLL.Contracts
{
    public interface IEmployeeBLL
    {
        bool SaveEmployee(Employee employee);
        List<Employee> GetAll();
    }
}
