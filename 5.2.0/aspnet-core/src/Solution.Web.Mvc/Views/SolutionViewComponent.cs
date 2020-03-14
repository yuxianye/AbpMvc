using Abp.AspNetCore.Mvc.ViewComponents;

namespace Solution.Web.Views
{
    public abstract class SolutionViewComponent : AbpViewComponent
    {
        protected SolutionViewComponent()
        {
            LocalizationSourceName = SolutionConsts.LocalizationSourceName;
        }
    }
}
