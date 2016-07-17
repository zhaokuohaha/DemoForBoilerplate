using System.Web.Mvc;

namespace DemoForBoilerplate.Web.Controllers
{
    public class AboutController : DemoForBoilerplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}