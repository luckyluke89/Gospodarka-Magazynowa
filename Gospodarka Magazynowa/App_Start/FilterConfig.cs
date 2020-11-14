using System.Web;
using System.Web.Mvc;

namespace Gospodarka_Magazynowa
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
