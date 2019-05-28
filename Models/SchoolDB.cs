using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication25.Models
{
    public class SchoolDB:DbContext
    {
       public SchoolDB():base()
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}