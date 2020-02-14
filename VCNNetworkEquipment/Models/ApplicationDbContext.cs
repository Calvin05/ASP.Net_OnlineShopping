/*	Author:
 *	Viet Cuong Nguyen
 *	300973502
 *	cuongnguyen9505@gmail.com
*/

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace VCNNetworkEquipment.Models
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options) { }

		public DbSet<Product> Products { get; set; }

		public DbSet<Order> Orders { get; set; }

	}

	
}
