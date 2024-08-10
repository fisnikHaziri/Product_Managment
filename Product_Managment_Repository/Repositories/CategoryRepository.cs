using Product_Managment_DataSource;
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
		private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext context) 
        {
            _db = context;   
        }
    }
}
