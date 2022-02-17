using Microsoft.AspNetCore.Mvc;
using StudentDb.DataAccseess.Models;
using StudentDb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDb.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IStudentRepository studentRepository;

        //public HomeController(IStudentRepository studentRepository)
        //{
        //    this.studentRepository = studentRepository;
        //}

        public ViewResult Index() 
        {    
            HomeDetalisViewModel homeDetalisView1 = new HomeDetalisViewModel()
            {
                Title = "Studen Index"
            };
            return View(homeDetalisView1);
        }
        public ViewResult Index2() 
        {    
            HomeDetalisViewModel homeDetalisView1 = new HomeDetalisViewModel()
            {
                Title = "Studen Index"
            };
            return View(homeDetalisView1);
        }
        public JsonResult Data() 
        {
            return Json(new {id=1,name="Sherzod",lastname="Uralov" });
        }
        [HttpGet]
        public async Task<IActionResult> GetAllElementAsync()
        {
            return null;
        }
        public ViewResult dsda()
        {
            return View();
        }

        public JsonResult Sherzod()
        { 
            return Json(new {id =1 });
        }
         public JsonResult JsonFile()
        { 
            return Json(new {id =1 });
        }
         public JsonResult Jahon()
        { 
            return Json(new {id =1 });
        }

        public ViewResult HOME() 
        {
            return View();
        }

    }
    
}
