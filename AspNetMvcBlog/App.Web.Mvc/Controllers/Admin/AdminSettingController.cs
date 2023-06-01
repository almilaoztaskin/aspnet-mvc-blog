using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{
	public class AdminSettingController : BaseAdmincontroller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
