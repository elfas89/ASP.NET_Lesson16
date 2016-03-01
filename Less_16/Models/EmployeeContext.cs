using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Less_16.Models
{
    public class EmployeeContext : DbContext
    {
        static EmployeeContext()
        {
            Database.SetInitializer<EmployeeContext>(new EmployeeContextInitializer());
        }


        public DbSet<Employee> Employees { get; set; }

    }
}