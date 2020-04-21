using Abp.Web.Mvc.Views;

namespace GoodHost.Web.Views
{
    public abstract class GoodHostWebViewPageBase : GoodHostWebViewPageBase<dynamic>
    {

    }

    public abstract class GoodHostWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected GoodHostWebViewPageBase()
        {
            LocalizationSourceName = GoodHostConsts.LocalizationSourceName;
        }
    }
}