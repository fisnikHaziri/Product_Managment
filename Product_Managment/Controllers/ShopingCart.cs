using Microsoft.AspNetCore.Mvc;

namespace Product_Managment.Controllers
{
	public class ShopingCart : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
