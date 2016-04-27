using System.Web;
using System.Web.Mvc;

namespace Week14_SuggestionBox_04112016
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
