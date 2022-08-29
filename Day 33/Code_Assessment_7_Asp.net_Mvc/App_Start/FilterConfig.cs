using System.Web;
using System.Web.Mvc;

namespace Code_Assessment_7_Asp.net_Mvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
