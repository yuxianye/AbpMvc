﻿using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Solution.Controllers;

namespace Solution.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : SolutionControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
