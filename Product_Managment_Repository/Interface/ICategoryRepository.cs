﻿using Product_Managment_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Managment_Repository.Interface
{
	public interface ICategoryRepository
	{
		public ICollection<Category> GetAll();
	}
}
