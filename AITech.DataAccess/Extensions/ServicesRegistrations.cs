using AITech.DataAccess.UnitOfWorks;
using Microsoft.Extensions.DependencyInjection;

namespace AITech.DataAccess.Extensions
{
    public static class ServicesRegistrations
    {
        public static void AddDataAccessServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.Scan(opt => //scrutor otomatik oalrak classları ve ınterfaceleri ekleyecek
                          opt.FromAssemblyOf<DataAccessAssembly>()
                          .AddClasses(x => x.Where(t => t.Name.EndsWith("Repository")))
                          .AsImplementedInterfaces()
                          .WithScopedLifetime());
        }
    }
}
