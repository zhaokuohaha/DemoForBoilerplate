using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoForBoilerplate.Web.Controllers
{
    public class MyTasksController : Controller
    {
        // GET: MyTasks
        public ActionResult Index()
        {
            return View();
        }
    }
}