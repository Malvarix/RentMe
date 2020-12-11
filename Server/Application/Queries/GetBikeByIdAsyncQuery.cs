using Domain.Entities;
using MediatR;

namespace Application.Queries
{
    public class GetBikeByIdAsyncQuery : IRequest<Bike>
    {
        public int BikeId { get; private set; }

        public GetBikeByIdAsyncQuery(int bikeId)
        {
            BikeId = bikeId;
        }
    }
}