using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistence.RepositoryInterfaces
{
    public interface IBikeRepository
    {
        Task<List<Bike>> GetBikesAsync();
        Task<Bike> GetBikeByIdAsync(int bikeId);
        Task<Bike> CreateBikeAsync(Bike bike);
        Task<Bike> UpdateBikeAsync(Bike bike);
        Task<Bike> DeleteBikeByIdAsync(int bikeId);
    }
}