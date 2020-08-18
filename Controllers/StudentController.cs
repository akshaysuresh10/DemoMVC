using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;
        public StudentController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Student Student)
        {
            //ToDb
            //Creating an object of AppDbcontext
            //AppDbContext Context=New AppDbContext() 
            _context.Students.Add(Student);
            _context.SaveChanges();
            return View();
        }



    }
}
