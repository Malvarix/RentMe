using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using Persistence.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Enums;

namespace Persistence.Services
{
    public class BikeService : IBikeService
    {
        private readonly BikesDbContext _context;

        public BikeService(BikesDbContext context)
        {
            _context = context;
        }

        public async Task<List<Bike>> GetBikesAsync()
        {
            try
            {
                return await _context.Bikes.ToListAsync();
            }
            catch(ArgumentNullException e)
            {
                throw new ArgumentNullException($"{e.Message}\tDatabase has troubles with Bikes tabel.");
            }
        }

        public async Task<Bike> GetBikeByIdAsync(int bikeId)
        {
            try
            {
                var bike = await _context.Bikes.FindAsync(bikeId);
                if (bike == null) 
                {
                    throw new ArgumentNullException();
                }
                return bike;
            }
            catch(ArgumentNullException)
            {
                throw new ArgumentNullException($"Database hasn't got bike with id = {bikeId}.");
            }
        }

        public async Task<Bike> CreateBikeAsync(Bike bike)
        {
            try
            {
                await _context.AddAsync(bike);
                await _context.SaveChangesAsync();
                return bike;
            }
            catch (Exception e)
            {
                throw new InvalidOperationException($"{e.Message}\tDatabase can't create new bike.");
            }
        }

        public async Task<Bike> UpdateBikeStatusByIdAsync(int bikeId)
        {
            try
            {
                var bike = await GetBikeByIdAsync(bikeId);
                if (bike.Status == Status.Free)
                {
                    bike.Status = Status.Rented;
                }
                else
                {
                    bike.Status = Status.Free;
                }
                _context.Update(bike);
                await _context.SaveChangesAsync();
                return bike;
            }
            catch (Exception e)
            {
                throw new InvalidOperationException($"{e.Message}\tDatabase can't update this bike.");
            }
        }

        public async Task<bool> DeleteBikeByIdAsync(int bikeId)
        {
            try
            {
                var bike = await _context.Bikes.FirstOrDefaultAsync(b => b.Id == bikeId);
                if (bike != default && bike != null)
                {
                    _context.Remove(bike);
                    await _context.SaveChangesAsync();
                    return true;
                } 
                else
                {
                    throw new ArgumentNullException($"Database hasn't got bike with id = {bikeId}.");
                }
            }
            catch (Exception e)
            {
                throw new InvalidOperationException($"{e.Message}\tDatabase can't delete this bike by id.");
            }
        }
    }
}