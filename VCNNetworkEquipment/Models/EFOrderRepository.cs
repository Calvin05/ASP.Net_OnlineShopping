﻿/*	Author:
 *	Viet Cuong Nguyen
 *	300973502
 *	cuongnguyen9505@gmail.com
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VCNNetworkEquipment.Models
{
	public class EFOrderRepository : IOrderRepository
	{
		private ApplicationDbContext context;
		public EFOrderRepository(ApplicationDbContext ctx)
		{
			context = ctx;
		}
		public IQueryable<Order> Orders => context.Orders
			.Include(o => o.Lines)
			.ThenInclude(l => l.Product);
		public void SaveOrder(Order order)
		{
			context.AttachRange(order.Lines.Select(l => l.Product));
			if (order.OrderID == 0)
			{
				context.Orders.Add(order);
			}
			context.SaveChanges();
		}
	}
}
