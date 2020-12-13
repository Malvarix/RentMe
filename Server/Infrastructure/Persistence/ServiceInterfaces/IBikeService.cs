using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistence.ServiceInterfaces
{
    public interface IBikeService
    {
        Task<List<Bike>> GetBikesAsync();
        Task<Bike> GetBikeByIdAsync(int bikeId);
        Task<Bike> CreateBikeAsync(Bike bike);
        Task<Bike> UpdateBikeStatusByIdAsync(int bikeId);
        Task<bool> DeleteBikeByIdAsync(int bikeId);
    }
}