using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskManagementApplication.Models;
using TaskManagementApplication.Services.Interfaces;
using TaskManagementApplication.Services.Repo;
using TaskManagementSystem.Model;
using TaskManagementSystem.ViewModel;

namespace TaskManagementApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly TaskRepo _taskRepo;
        public HomeController() {
            _taskRepo = new TaskRepo();
        }
        public HomeController(ITask taskRepo)
        {
           
        }
        public ActionResult Index()
        {
            return View();
        }
        
        public JsonResult CreateTask(MainTaskViewModel taskDetails)
        {
            MainTask taskDetailsResults = new MainTask(taskDetails);
            _taskRepo.Insert(taskDetailsResults);
            var json =_taskRepo.GetAll();
            return Json(json);

        }
    }
}