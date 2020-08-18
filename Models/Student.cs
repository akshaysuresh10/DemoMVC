using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMVC.Models
{
    public class Student
    {
        [Key]
        public int Id{ get; set; }
        public String Name { get; set; }
        public int M1 { get; set; }
    }
}
