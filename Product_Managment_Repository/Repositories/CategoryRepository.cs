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
			var data = _context.categories.ToList();
			return data;
		}
	}
}
