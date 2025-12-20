using Microsoft.Extensions.DependencyInjection;

namespace AITech.Business.Extensions
{
    public static class ServiceRegistrations
    {
        public static void AddBusinessServices(this IServiceCollection services)
        {
            services.Scan(opt => //scrutor ile otomatik tarayıp ekliyor sınıfları ve interfaceleri
                          opt.FromAssemblyOf<BusinessAssembly>()
                          .AddClasses(x => x.Where(t => t.Name.EndsWith("Service")))
                          .AsImplementedInterfaces()
                          .WithScopedLifetime());
        }
    }
}
