using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
	public class BlogController : Controller
	{
		public IActionResult Search()
		{
			return View();
		}
		public IActionResult Detail()
		{
			return View();
		}
	}
}
