using MediatR;
using Application.Commands;
using Persistence.ServiceInterfaces;
using System.Threading.Tasks;
using System.Threading;
using Domain.Entities;

namespace Application.CommandHandlers
{
    public class UpdateBikeStatusByIdAsyncCommandHandler : IRequestHandler<UpdateBikeStatusByIdAsyncCommand, Bike>
    {
        private readonly IBikeService _bikeService;

        public UpdateBikeStatusByIdAsyncCommandHandler(IBikeService bikeService)
        {
            _bikeService = bikeService;
        }
        public async Task<Bike> Handle(UpdateBikeStatusByIdAsyncCommand command, CancellationToken cancellationToken)
        {
            return await _bikeService.UpdateBikeStatusByIdAsync(command.BikeId);
        }
    }
}