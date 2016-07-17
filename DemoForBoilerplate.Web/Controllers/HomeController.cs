using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace DemoForBoilerplate.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : DemoForBoilerplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}