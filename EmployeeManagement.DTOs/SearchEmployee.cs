using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DTOs
{
    public class SearchEmployee
    {
        public int Id { get; set; }
        public string EName { get; set; }
        public decimal Salary { get; set; }
        public string DeptName { get; set; }
    }
}
