using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebApplication25.Models
{
    public class Student
    {
        [Key]
        public int Rno { get; set; }
        public String Sname { get; set; }
        public String Branch { get; set; }
        public int Fees { get; set; }
    }
}