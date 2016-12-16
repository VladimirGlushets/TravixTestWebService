using System.Web.Mvc;
using Epam.TravixTest.WebService.ActionFilters;

namespace Epam.TravixTest.WebService
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
