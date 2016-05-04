using System;
using System.Web.Mvc;

namespace Telos.Admin.Web.Filters
{
    public class ErrorModel : HandleErrorInfo
    {
        public string ErrorMessage { get; set; }

        public ErrorModel(string errorMessage, Exception exception, string controllerName, string actionName)
            : base(exception, controllerName, actionName)
        {
            this.ErrorMessage = errorMessage;
        }
    }
}
