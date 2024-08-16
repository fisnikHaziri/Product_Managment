using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Product_Managment.Models;
using Produuct_Managment_Services;
using System.Diagnostics;

namespace Product_Managment.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			ViewData["HomePage"] = "active";
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
