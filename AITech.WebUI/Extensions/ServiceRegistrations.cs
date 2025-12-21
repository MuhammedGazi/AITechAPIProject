using FluentValidation;
using FluentValidation.AspNetCore;
using System.Reflection;

namespace AITech.WebUI.Extensions
{
    public static class ServiceRegistrations
    {
        public static void AddUIServices(this IServiceCollection services)
        {
            services.Scan(opt =>
                          opt.FromAssemblyOf<WebUIAssembly>()
                          .AddClasses(x => x.Where(t => t.Name.EndsWith("Service")))
                          .AsImplementedInterfaces()
                          .WithScopedLifetime());

            services.AddFluentValidationAutoValidation()
                    .AddFluentValidationClientsideAdapters()
                    .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
