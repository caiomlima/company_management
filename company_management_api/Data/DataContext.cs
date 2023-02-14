using Microsoft.EntityFrameworkCore;

namespace company_management_api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }


    }
}
