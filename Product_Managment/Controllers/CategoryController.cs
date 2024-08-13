using Microsoft.AspNetCore.Mvc;
using Product_Managment_Repository.Interface;

namespace Product_Managment.Controllers
{
	public class CategoryController : Controller
	{
		protected readonly ICategoryRepository _repo;
        public CategoryController(ICategoryRepository repo)
        {
			_repo = repo;
        }
        public IActionResult Index()
		{
			var data = _repo.GetAll();
			return View(data);
		}
	}
}
