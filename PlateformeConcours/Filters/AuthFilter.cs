using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlateformeConcours.Filters
{
	public class AuthFilter : FilterAttribute,IAuthorizationFilter
	{
		public void OnAuthorization(AuthorizationContext filterContext)
		{
			var etu = filterContext.HttpContext.Session["etudiant"];
			if(etu == null)
			{
				filterContext.Result = new RedirectResult("/");
			}
		}
	}
}