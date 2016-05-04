using System.Web;
using System.Web.Mvc;
using  Telos.Admin.Web.Filters;

namespace  Telos.Admin.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new GlobalExceptionFilter());
        }
    }
}