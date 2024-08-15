using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Managment_Model
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string? Description { get; set; }

		[Range(0, 999999.99, ErrorMessage = "Please enter a valid price.")]
		public decimal? Price { get; set; }
		public int? Stock { get; set; }
		public bool IsEdible { get; set; }

        //Relationships
        [ForeignKey("CategoryId")]
		public Category Category { get; set; }
		public int CategoryId { get; set; }

		public string? UserId { get; set; }
		public virtual ApplicationUser User { get; set; }
	}
}
