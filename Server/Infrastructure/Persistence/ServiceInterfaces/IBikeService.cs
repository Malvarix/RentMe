using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistence.ServiceInterfaces
{
    public interface IBikeService
    {
        Task<List<Bike>> GetBikesAsync();
        Task<Bike> GetBikeByIdAsync(int bikeId);
        Task CreateBikeAsync(Bike bike);
        Task UpdateBikeAsync(Bike bike);
        Task DeleteBikeByIdAsync(int bikeId);
    }
}