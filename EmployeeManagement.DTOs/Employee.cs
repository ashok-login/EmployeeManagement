using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.DTOs
{
    [Table("Employee")]
    public class Employee
    {
        public int Id { get; set; }
        public string EName { get; set; }
        public decimal Salary { get; set; }
        public string DeptName { get; set; }
    }
}
