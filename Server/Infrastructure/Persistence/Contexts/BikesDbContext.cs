using Persistence.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Domain.Entities;
using Domain.Enums;

namespace Persistence.Contexts
{
    public class BikesDbContext : DbContext
    {
        private readonly BikesDbConfiguration _configuration;

        public DbSet<Bike> Bikes { get; set; }

        public BikesDbContext()
        {
            _configuration = new BikesDbConfiguration() 
            { 
                BikesDbConnection = "Server=(LocalDB)\\MSSQLLocalDB;Database=BikesDb;Trusted_Connection=true;" 
            };
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bike>().HasData(
                new Bike
                {
                    Id = 1,
                    Title = "Giant Contend AR 2 2020",
                    Type = Type.Road,
                    Price = 20.99m,
                    Status = Status.Free
                },
                new Bike
                {
                    Id = 2,
                    Title = "Cyclone MMXX 29 2020",
                    Type = Type.Mountain,
                    Price = 18.99m,
                    Status = Status.Free
                },
                new Bike
                {
                    Id = 3,
                    Title = "Trek Domane AL 3 2019",
                    Type = Type.Road,
                    Price = 15.99m,
                    Status = Status.Free
                }
            );
        }
    }
}