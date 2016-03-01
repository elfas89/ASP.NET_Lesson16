using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Less_16.Models
{

    public class EmployeeContextInitializer : DropCreateDatabaseAlways<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            context.Employees.Add(new Employee { Id = 1, Name = "Andrey", Age = 26, Post = "post1" });
            context.Employees.Add(new Employee { Id = 2, Name = "Ilya", Age = 28, Post = "post2" });
            context.Employees.Add(new Employee { Id = 3, Name = "Max", Age = 28, Post = "Tutor" });
            context.SaveChanges();
        }
    }


}