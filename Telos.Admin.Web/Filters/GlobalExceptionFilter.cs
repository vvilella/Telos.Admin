using System.Web.Mvc;

namespace  Telos.Admin.Web.Filters
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            // Log should go here
            if (filterContext.HttpContext.IsCustomErrorEnabled && !filterContext.ExceptionHandled)
            {
                string controllerName = (string)filterContext.RouteData.Values["controller"];
                string actionName = (string)filterContext.RouteData.Values["action"];
                HandleErrorInfo info = new HandleErrorInfo(filterContext.Exception, controllerName, actionName);

                filterContext.ExceptionHandled = true;
                filterContext.HttpContext.Response.Clear();
                filterContext.HttpContext.Response.StatusCode = 500;
                filterContext.HttpContext.Response.TrySkipIisCustomErrors = true; 

                if (!filterContext.HttpContext.Request.IsAjaxRequest())
                {
                    var errorModel = new ErrorModel(filterContext.Exception.Message, filterContext.Exception, controllerName, actionName);
                    filterContext.Result = new ViewResult { ViewName = "Error" , ViewData = new ViewDataDictionary(errorModel), TempData = filterContext.Controller.TempData };
                }
                else
                {
                    // It should return an JSON response and application should be prepared to display it
                }

            }
        }
    }
}