/*	Author:
 *	Viet Cuong Nguyen
 *	300973502
 *	cuongnguyen9505@gmail.com
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace VCNNetworkEquipment.Infrastructure
{
	public static class UrlExtensions
	{
		public static string PathAndQuery(this HttpRequest request) =>
			request.QueryString.HasValue
				? $"{request.Path}{request.QueryString}"
			: request.Path.ToString();
	}
}
