using Application.Queries;
using Domain.Entities;
using MediatR;
using Persistence.RepositoryInterfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Application.QueryHandlers
{
    public class GetBikeByIdAsyncQueryHandler : IRequestHandler<GetBikeByIdAsyncQuery, Bike>
    {
        private readonly IBikeRepository _bikeRepository;

        public GetBikeByIdAsyncQueryHandler(IBikeRepository bikeRepository)
        {
            _bikeRepository = bikeRepository;
        }

        public async Task<Bike> Handle(GetBikeByIdAsyncQuery query, CancellationToken cancellationToken)
        {
            return await _bikeRepository.GetBikeByIdAsync(query.BikeId);
        }
    }
}