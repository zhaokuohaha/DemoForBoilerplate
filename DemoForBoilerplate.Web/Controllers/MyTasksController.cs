using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoForBoilerplate.MyTasks;
using DemoForBoilerplate.MyPeople;
using DemoForBoilerplate.EntityFramework.Repositories;

namespace DemoForBoilerplate.Web.Controllers
{
    public class MyTasksController : DemoForBoilerplateControllerBase
	{
		MyTaskApplicationService _myTaskAppService;
		MyTaskRepository _myTaskRepository;
		MyPersonAppService _myPersonService;
		MyPersonRepository _myPersonRepository;

		public MyTasksController(
			MyPersonRepository myPersonReposity,
			MyPersonAppService myPersonService,
			MyTaskRepository myTaskRepository,
			MyTaskApplicationService myTaskAppService)
		{
			_myPersonRepository = myPersonReposity;
			_myPersonService = myPersonService;
			_myTaskRepository = myTaskRepository;
			_myTaskAppService = myTaskAppService;
		}
        // GET: MyTasks
        public ActionResult Index()
        {
			var myTasks = _myTaskAppService.GetMyTask(new MyTasks.Dtos.GetMyTaskInput());
            return View(myTasks);
        }

		public PartialViewResult CreateMyTask()
		{
			var people = _myPersonRepository.GetAllList();
			return PartialView("MyTask",people);
		}


		public PartialViewResult EditTask(int id)
		{
			var task = _myTaskRepository.Get(id);
			return PartialView(task);
		}
	}
}