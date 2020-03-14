using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Solution.Controllers;

namespace Solution.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : SolutionControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
