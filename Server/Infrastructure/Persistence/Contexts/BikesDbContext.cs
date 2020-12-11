using Persistence.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Domain.Entities;

namespace Persistence.Contexts
{
    public class BikesDbContext : DbContext
    {
        private readonly BikesDbConfiguration _configuration;

        public DbSet<Bike> Bikes { get; set; }

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