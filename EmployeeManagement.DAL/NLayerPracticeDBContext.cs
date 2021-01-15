using EmployeeManagement.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DAL
{
    public class NLayerPracticeDBContext : DbContext
    {
        public NLayerPracticeDBContext(DbContextOptions<NLayerPracticeDBContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
