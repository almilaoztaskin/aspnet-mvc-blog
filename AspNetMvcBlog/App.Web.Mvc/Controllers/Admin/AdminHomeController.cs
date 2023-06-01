using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{
	public class AdminHomeController : BaseAdmincontroller
	{
		public IActionResult Index()
		{
			return View();
		}
	}

}
