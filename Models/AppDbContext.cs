using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMVC.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Marks> Marks { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }

        public virtual DbSet<Employee> Employees{ get; set; }
    }
}
