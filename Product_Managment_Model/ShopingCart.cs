using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Managment_Model
{
	public class ShopingCart
	{
		public int Id { get; set; }
		public decimal TotalPrice { get; set; }

		public string UserId {  get; set; }
		public virtual ApplicationUser User { get; set; }
		public List<Product> products {  get; set; }
	}
}
