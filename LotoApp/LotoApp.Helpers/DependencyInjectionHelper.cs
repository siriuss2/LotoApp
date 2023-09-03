namespace LotoApp.Helpers
{
    using LotoApp.DataAccess;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public static class DependencyInjectionHelper
    {
        public static void InjectDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<LotoAppDbContext>(options => options.UseSqlServer(connectionString));
        }
    }
}
