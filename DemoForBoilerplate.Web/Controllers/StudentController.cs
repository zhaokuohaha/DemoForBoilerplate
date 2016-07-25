using DemoForBoilerplate.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoForBoilerplate.Web.Controllers
{
    public class StudentController : Controller
    {
		private IStudentRepository _studentResopitory;
		private IStudentApplicationService _studentApplicationService;
		public StudentController(
			IStudentRepository studentRepository,
			IStudentApplicationService studentApplicationService)
		{
			_studentResopitory = studentRepository;
			_studentApplicationService = studentApplicationService;
		}

		// GET: Student
		public ActionResult Index()
        {
			var model = _studentApplicationService.initClasses(_studentApplicationService.getClassNum(30));
            return View(model);
        }
    }
}