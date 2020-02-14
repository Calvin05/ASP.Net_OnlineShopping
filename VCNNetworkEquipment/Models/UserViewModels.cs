/*	Author:
 *	Viet Cuong Nguyen
 *	300973502
 *	cuongnguyen9505@gmail.com
*/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VCNNetworkEquipment.Models
{
	public class CreateModel
	{
		[Required (ErrorMessage ="Please Enter Account Name")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Please Enter Account Password")]
		public string Role { get; set; }
		[Required(ErrorMessage = "Please Specify Account Type")]
		public string Password { get; set; }
	}
}
