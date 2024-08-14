using Microsoft.EntityFrameworkCore;
using Product_Managment_DataSource;
using Product_Managment_Model;
using Product_Managment_Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Managment_Repository.Repositories
{
	public class CategoryRepository : ICategoryRepository
	{
		private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context) 
        {
            _context = context;   
        }

		public ICollection<Category> GetAll()
		{
			var data = _context.categories.Include(c => c.Products).ToList();
			return data;
		}

		public void Create(Category category)
		{
			_context.categories.Add(category);
			_context.SaveChanges();
		}

		public void Update(Category category)
		{
			_context.categories.Update(category);
			_context.SaveChanges();
		}

		public void Delete(Category category)
		{
			_context.categories.Remove(category);
			_context.SaveChanges();
		}

		public Category GetByID(int id)
		{
			var data = _context.categories.FirstOrDefault(x => x.CategoryId == id);
			return data;
		}

        public Category ReturnListOfProducts(int id)
		{
			var category = _context.categories.
				Include(c => c.Products)
				.ThenInclude(p => p.User)
				.FirstOrDefault(c => c.CategoryId == id);
			return category;
		}

    }
}
