using Microsoft.AspNetCore.Mvc;

namespace webyamaha1.Controllers
{
	public class BlogController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
