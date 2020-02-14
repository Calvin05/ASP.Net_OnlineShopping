﻿/*	Author:
 *	Viet Cuong Nguyen
 *	300973502
 *	cuongnguyen9505@gmail.com
*/

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VCNNetworkEquipment.Models;

namespace VCNNetworkEquipment.Controllers
{
    public class ManagerController : Controller
    {
		private UserManager<AppUser> userManager;
		public ManagerController(UserManager<AppUser> usrMgr)
		{
			userManager = usrMgr;
		}
		public ViewResult Index() => View(userManager.Users);
	}
}