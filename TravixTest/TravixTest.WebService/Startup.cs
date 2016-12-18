using System.Web.Http;
using Autofac.Integration.WebApi;
using Epam.TravixTest.WebService.ActionFilters;
using Owin;

namespace Epam.TravixTest.WebService
{
    /// <summary>
    /// Startup class for confguring OWIN middleware
    /// </summary>
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            // register validation action filter
            config.Filters.Add(new ValidationActionFilter());

            WebApiConfig.Register(config);

            config.DependencyResolver = new AutofacWebApiDependencyResolver(AutofacConfig.Container);
            app.UseAutofacMiddleware(AutofacConfig.Container);
            app.UseWebApi(config);
        }
    }
}
