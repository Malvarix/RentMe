using Application.Commands;
using MediatR;
using Persistence.ServiceInterfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Application.CommandHandlers
{
    public class DeleteBikeByIdAsyncCommandHandler : IRequestHandler<DeleteBikeByIdAsyncCommand, bool>
    {
        private readonly IBikeService _bikeService;

        public DeleteBikeByIdAsyncCommandHandler(IBikeService bikeService)
        {
            _bikeService = bikeService;
        }
        public async Task<bool> Handle(DeleteBikeByIdAsyncCommand command, CancellationToken cancellationToken)
        {
            return await _bikeService.DeleteBikeByIdAsync(command.Id);
        }
    }
}
