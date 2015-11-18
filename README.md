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


