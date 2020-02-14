/*	Author:
 *	Viet Cuong Nguyen
 *	300973502
 *	cuongnguyen9505@gmail.com
*/

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace VCNNetworkEquipment.Models
{
	public class AppIdentityDbContext : IdentityDbContext<AppUser>
	{
		public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options)
		: base(options) {
			Database.EnsureCreated();
		}
	}
}
