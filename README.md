# Log-Action-Filter-ASP.NET-Mvc
My Custom Log Action Filter

#The different Types of Filters

the asp.net mvc framework supports four different types of filters

1. Authorization filters - implement the IAuthorizationFilter Attribute
2. Action filters        - implement the IActionFilter Attribute
3. Result Filters 		 - implement the IResultFilter Attribute
4. Exception Filters     - implement the IExceptionFilter Attribute

####the base ActionFilterAttribute class has the following methods that you can override

1. OnActionExecuting - this method is called before a controller action is executing
2. OnActionExecuted  - this method is called before a controller action is executed
3. OnResultExecuting - this method is called before a controller action result is executing
4. OnResultExecuted  - this method is called before a controller action result is executed

#LogActionFilter Class
<pre>
using System;
using System.Diagnostics;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication.ActionFilters
{
	public class LogActionFilter : ActionFilterAttribute
	{
		public override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			Log("OnActionExecuting", filterContext.RouteData);
		}

		public override void OnActionExecuted(ActionExecutingContext filterContext)
		{
			Log("OnActionExecuted", filterContext.RouteData);
		}

		public override void OnResultExecuting(ActionExecutingContext filterContext)
		{
			Log("OnResultExecuting", filterContext.RouteData);
		}
		public override void OnResultExecuted(ActionExecutingContext filterContext)
		{
			Log("OnResultExecuted", filterContext.RouteData);
		}

		private void Log(string methodName, RouteData routeData)
		{
			var controllerName =  routeData.Values["controller"];
			var actionName     =  routeData.Values["action"];
			var message 	   =  string.Format("{0} controller: {1} action: {2}", methodName, controllerName, actionName);

			Debug.WriteLine
			(
				message, 
				"Action Filter Log"
			);
		}
	}
}
</pre>
