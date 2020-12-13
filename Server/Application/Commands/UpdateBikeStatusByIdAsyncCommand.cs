using Domain.Entities;
using MediatR;

namespace Application.Commands
{
    public class UpdateBikeStatusByIdAsyncCommand : IRequest<Bike>
    {
        public int BikeId { get; private set; }

        public UpdateBikeStatusByIdAsyncCommand(int bikeId)
        {
            BikeId = bikeId;
        }
    }
}