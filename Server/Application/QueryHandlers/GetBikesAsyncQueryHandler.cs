using Application.Queries;
using Domain.Entities;
using MediatR;
using Persistence.ServiceInterfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.QueryHandlers
{
    public class GetBikesAsyncQueryHandler : IRequestHandler<GetBikesAsyncQuery, IEnumerable<Bike>>
    {
        private readonly IBikeService _bikeRepository;

        public GetBikesAsyncQueryHandler(IBikeService bikeRepository)
        {
            _bikeRepository = bikeRepository;
        }

        public async Task<IEnumerable<Bike>> Handle(GetBikesAsyncQuery request, CancellationToken cancellationToken)
        {
            return await _bikeRepository.GetBikesAsync();
        }
    }
}