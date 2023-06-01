using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{
	public class AdminUserController : BaseAdmincontroller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
