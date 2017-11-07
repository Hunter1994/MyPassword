using Abp.Web.Mvc.Views;

namespace MyPassword.Web.Views
{
    public abstract class MyPasswordWebViewPageBase : MyPasswordWebViewPageBase<dynamic>
    {

    }

    public abstract class MyPasswordWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MyPasswordWebViewPageBase()
        {
            LocalizationSourceName = MyPasswordConsts.LocalizationSourceName;
        }
    }
}