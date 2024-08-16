using Microsoft.AspNetCore.Mvc;
using Product_Managment_Model;
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
			ViewData["CategoryPage"] = "active";
			var data = _repo.GetAll();
			return View(data);
		}

		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(Category category)
		{
			_repo.Create(category);
			return RedirectToAction("Index");
		}

		public IActionResult Delete(int id)
		{
			var data = _repo.GetByID(id);
			return View(data);
		}
		[HttpPost]
		public IActionResult Delete(Category category)
		{
			_repo.Delete(category);
			return RedirectToAction("Index");
		}

		public IActionResult Update(int id)
		{
			var data = _repo.GetByID(id);
			return View(data);
		}
		[HttpPost]
		public IActionResult Update(Category category)
		{
			_repo.Update(category);
			return RedirectToAction("Index");
		}

		public IActionResult Products(int id)
		{
			var data = _repo.ReturnListOfProducts(id);
			return View(data);
		}
	}
}
