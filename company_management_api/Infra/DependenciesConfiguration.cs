using company_management_api.Data;
using Microsoft.EntityFrameworkCore;

namespace company_management_api.Infra
{
    public class DependenciesConfiguration
    {
        public static void Configure(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(options => options.UseMySql(configuration["DataBaseConnectionString"], new MySqlServerVersion(new Version(5, 7, 12))));
                //.ConfigureWarnings(warnings => warnings.Ignore(CoreEventId.DetachedLazyLoadingWarning, RelationalEventId.BoolWithDefaultWarning));

            // Services


            // Repositories


            // Background Workers & Processors


            //
        }
    }
}
