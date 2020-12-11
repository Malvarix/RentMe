using Persistence.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Persistence.Contexts
{
    public class BikesDbContext : DbContext
    {
        private readonly BikesDbConfiguration _configuration;

        public BikesDbContext()
        {

        }

        public BikesDbContext(DbContextOptions<BikesDbContext> options,
            IOptions<BikesDbConfiguration> configOptions) : base(options)
        {
            _configuration = configOptions.Value;
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.BikesDbConnection);
        }
    }
}