using System;
using Autofac;
using Autofac.Integration.WebApi;

namespace Epam.TravixTest.Infrastructure.IoC.Modules
{
    /// <summary>
    /// Register all api controllers for Autofac IoC container
    /// </summary>
    public class ApiControllersModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
