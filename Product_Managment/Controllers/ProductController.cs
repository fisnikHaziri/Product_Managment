using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Product_Managment_DataSource;
using Product_Managment_Model;
using Product_Managment_Repository.Interface;
using Produuct_Managment_Services;

namespace Product_Managment.Controllers
{
	public class ProductController : Controller
	{
		private readonly IProductRepository _repo;
        public ProductController(IProductRepository repo, ApplicationDbContext context)
        {
			_repo = repo;
        }

        public IActionResult Index()
		{
			return View(_repo.GetAll());
		}


        [Authorize(Roles = SD.Role_Store)]
        public IActionResult Create()
		{
			ViewBag.Categories = new SelectList( _repo.ReturnCategories(),"CategoryId", "Name");
			return View();
		}
		[HttpPost]
        public IActionResult Create(Product product)
        {
			if(product != null)
			{
				_repo.Create(product);
			}
			else
			{
				return View();
			}
            return RedirectToAction("Index");
        }
		public IActionResult Edit(int id)
		{
			var item = _repo.GetById(id);
			ViewBag.Categories = new SelectList(_repo.ReturnCategories(), "CategoryId", "Name");
			return View(item);
		}

		[HttpPost]
		public IActionResult Edit(Product product)
		{
			if (product.Id != 0)
			{
				_repo.Update(product);
			}
			return RedirectToAction("Index");
		}

		public IActionResult Delete(int id)
		{
            var item = _repo.GetById(id);
			return View(item);
		}

		[HttpPost]
		public IActionResult Delete(Product product)
		{
			if (product.Id != 0)
			{
				_repo.Delete(product);
			}
			return RedirectToAction("Index");
		}
	}
}
