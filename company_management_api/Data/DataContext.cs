using company_management_api.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace company_management_api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public virtual DbSet<Sector> Sector { get; set; } 
        public virtual DbSet<EmployeeRole> EmployeeRole { get; set; } 
        public virtual DbSet<Employee> Employee { get; set; } 
    }
}
