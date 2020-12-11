using MediatR;
using Domain.Entities;
using Application.Commands;
using Persistence.ServiceInterfaces;
using System.Threading.Tasks;
using System.Threading;

namespace Application.CommandHandlers
{
    public class UpdateBikeAsyncCommandHandler : IRequest<UpdateBikeAsyncCommand>
    {
        private readonly IBikeService _bikeService;

        public UpdateBikeAsyncCommandHandler(IBikeService bikeService)
        {
            _bikeService = bikeService;
        }
        public async Task Handle(UpdateBikeAsyncCommand command, CancellationToken cancellationToken)
        {
            var bike = new Bike()
            {
                Id = command.Id,
                Title = command.Title,
                Type = command.Type,
                Price = command.Price,
                Status = command.Status
            };

            await _bikeService.UpdateBikeAsync(bike);
        }
    }
}