using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Product_Managment_DataSource;
using Product_Managment_DataSource.Migrations;
using Product_Managment_Model;
using Product_Managment_Repository.Interface;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Product_Managment_Repository.Repositories
{
	public class ProductRepository : IProductRepository
	{
		protected readonly ApplicationDbContext _context;
		public ProductRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		public ICollection<Product> GetAll()
		{
			var data = _context.products.Include(x => x.Category).Include(p => p.User).ToList();
			return data;
		}
		public void Create(Product product, string userId)
		{
			if(product.Name == null)
			{
				product.Name = "Set Name";
			}
			product.UserId = userId;
			_context.products.Add(product);
			_context.SaveChanges();
		}
		public void Update(Product product)
		{
			_context.products.Update(product);
			_context.SaveChanges();
		}
		public void Delete(Product product) 
		{
			_context.products.Remove(product);
			_context.SaveChanges();
		}
		public IEnumerable<Category> ReturnCategories()
		{
			return _context.categories.ToList();
		}
		public Product GetById(int id)
		{
			var data = _context.products.FirstOrDefault(x => x.Id == id);
			return data;
		}
	}
}
