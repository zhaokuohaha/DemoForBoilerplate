using Abp.Web.Mvc.Views;

namespace DemoForBoilerplate.Web.Views
{
    public abstract class DemoForBoilerplateWebViewPageBase : DemoForBoilerplateWebViewPageBase<dynamic>
    {

    }

    public abstract class DemoForBoilerplateWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected DemoForBoilerplateWebViewPageBase()
        {
            LocalizationSourceName = DemoForBoilerplateConsts.LocalizationSourceName;
        }
    }
}