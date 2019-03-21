using System.Web;
using System.Web.Mvc;

namespace Evaluacion_NuevoIngreso
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
