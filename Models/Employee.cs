using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication25.Models
{
    public class Employee
    {
        [Key]
        public int EmpCode { get; set; }
        public string EmpName { get; set; }
        public string Job { get; set; }
        public int Salary { get; set; }
    }
}