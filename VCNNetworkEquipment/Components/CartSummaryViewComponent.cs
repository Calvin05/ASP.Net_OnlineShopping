/*	Author:
 *	Viet Cuong Nguyen
 *	300973502
 *	cuongnguyen9505@gmail.com
*/

using Microsoft.AspNetCore.Mvc;
using VCNNetworkEquipment.Models;

namespace VCNNetworkEquipment.Components
{
	public class CartSummaryViewComponent : ViewComponent
	{
		private Cart cart;
		public CartSummaryViewComponent(Cart cartService)
		{
			cart = cartService;
		}
		public IViewComponentResult Invoke()
		{
			return View(cart);
		}
	}
}
