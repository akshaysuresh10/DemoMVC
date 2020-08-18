using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMVC.Models
{

    public class Marks
    {
     [Key]
        public int Id { get; set; }
        public int mark1 { get; set; }

    }
}
