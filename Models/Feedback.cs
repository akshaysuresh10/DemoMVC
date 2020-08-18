using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMVC.Models
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }
        public String feedback { get; set; }
    }
}
