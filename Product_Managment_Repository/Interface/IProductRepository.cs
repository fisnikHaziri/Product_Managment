using Product_Managment_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Managment_Repository.Interface
{
	public interface IProductRepository
	{
		public ICollection<Product> GetAll();
		public Product GetById(int id);
		public List<Product> GetByName(string productName);
		public void Create(Product product, string userId);
		public void Update(Product product);
		public void Delete(Product product);
		public IEnumerable<Category> ReturnCategories();

		public Task<List<Product>> MyItems(string UserName);
	}
}
