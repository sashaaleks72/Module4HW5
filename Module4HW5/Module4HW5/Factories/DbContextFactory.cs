using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using WorkingWithDB.DBContexts;
using WorkingWithDB.Configs;

namespace WorkingWithDB.Factories
{
    public class DbContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            var connConfigObject = new ConnectionConfig();
            var connConfig = connConfigObject.Build();
            string connString = connConfig.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionsBuilder.UseLazyLoadingProxies().UseSqlServer(connString).Options;

            return new ApplicationContext(options);
        }
    }
}
