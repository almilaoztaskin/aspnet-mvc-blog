﻿using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{
	public class AdminCategoryController : BaseAdmincontroller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
