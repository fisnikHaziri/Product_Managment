using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Managment_Model
{
	public class Category
	{
		public int CategoryId { get; set; }
		public string Name { get; set; }
		public string? Description { get; set; }

        //Relationships
        public ICollection<Product>? Products { get; set; } = new List<Product>();
	}
}
