using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using Persistence.RepositoryInterfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class BikeRepository : IBikeRepository
    {
        private readonly BikesDbContext _context;

        public BikeRepository(BikesDbContext context)
        {
            _context = context;
        }

        public async Task<List<Bike>> GetBikesAsync()
        {
            return await _context.Bikes.ToListAsync();
        }

        public async Task<Bike> GetBikeByIdAsync(int bikeId)
        {
            return await _context.Bikes.FindAsync(bikeId);
        }

        public async Task<Bike> CreateBikeAsync(Bike bike)
        {
            await _context.AddAsync(bike);
            await _context.SaveChangesAsync();
            return bike;
        }

        public async Task<Bike> UpdateBikeAsync(Bike bike)
        {
            _context.Update(bike);
            await _context.SaveChangesAsync();
            return bike;
        }

        public async Task<Bike> DeleteBikeByIdAsync(int bikeId)
        {
            var entity = await _context.Bikes.FirstOrDefaultAsync(b => b.Id == bikeId);

            if(entity != default && entity != null)
            {
                _context.Remove(bikeId);
                await _context.SaveChangesAsync();
            }

            return entity;
        }
    }
}