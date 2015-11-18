using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Diagnostics;
using System.Web.Routing;

namespace WebApplication11.ActionFilters
{
    public class LogActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Log("OnActionExecuting", filterContext.RouteData);
        }
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Log("OnActionExecuted", filterContext.RouteData);
        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Log("OnResultExecuting", filterContext.RouteData);
        }
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Log("OnResultExecuted", filterContext.RouteData);
        }

        public static void Log(string methodName, RouteData routeData)
        {
            var controllersName = routeData.Values["controller"];
            var actionName      = routeData.Values["action"];
            var message         = string.Format("{0} Controller:{1} Action:{2}", methodName, controllersName,actionName);
            Debug.WriteLine(message,"ActionFilterLogs");
        }
    }
}