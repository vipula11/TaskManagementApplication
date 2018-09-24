using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using TaskManagementSystem.Model;

namespace TaskManagementApplication.Area.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]")]
    public class TaskController : Controller
    {
        public JsonResult CreateTask([FromBody] MainTask taskDetails)
        {
            var json = taskDetails;
            return null;
        }
    }
}