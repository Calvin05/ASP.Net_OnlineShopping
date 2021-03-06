﻿/*	Author:
 *	Viet Cuong Nguyen
 *	300973502
 *	cuongnguyen9505@gmail.com
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VCNNetworkEquipment.Models
{
	public interface IProductRepository
	{
		IQueryable<Product> Products { get; }

		void SaveProduct(Product product);

		Product DeleteProduct(int productID);

		void AddReview(Product product);

        Product DeleteReview(int productID);
    }
}
