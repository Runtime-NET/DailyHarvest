using Abp.Web.Mvc.Views;

namespace vino.Web.Views
{
    public abstract class vinoWebViewPageBase : vinoWebViewPageBase<dynamic>
    {

    }

    public abstract class vinoWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected vinoWebViewPageBase()
        {
            LocalizationSourceName = vinoConsts.LocalizationSourceName;
        }
    }
}