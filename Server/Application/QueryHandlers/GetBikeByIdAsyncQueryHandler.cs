using Application.Queries;
using Domain.Entities;
using MediatR;
using Persistence.ServiceInterfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Application.QueryHandlers
{
    public class GetBikeByIdAsyncQueryHandler : IRequestHandler<GetBikeByIdAsyncQuery, Bike>
    {
        private readonly IBikeService _bikeRepository;

        public GetBikeByIdAsyncQueryHandler(IBikeService bikeRepository)
        {
            _bikeRepository = bikeRepository;
        }

        public async Task<Bike> Handle(GetBikeByIdAsyncQuery query, CancellationToken cancellationToken)
        {
            return await _bikeRepository.GetBikeByIdAsync(query.BikeId);
        }
    }
}