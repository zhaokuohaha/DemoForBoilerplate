using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using DemoForBoilerplate.Authorization;
using DemoForBoilerplate.MultiTenancy;

namespace DemoForBoilerplate.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : DemoForBoilerplateControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}