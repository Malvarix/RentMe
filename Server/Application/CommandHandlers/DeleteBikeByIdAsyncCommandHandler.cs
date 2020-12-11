using Application.Commands;
using Persistence.ServiceInterfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Application.CommandHandlers
{
    public class DeleteBikeByIdAsyncCommandHandler
    {
        private readonly IBikeService _bikeService;

        public DeleteBikeByIdAsyncCommandHandler(IBikeService bikeService)
        {
            _bikeService = bikeService;
        }
        public async Task Handle(DeleteBikeByIdAsyncCommand command, CancellationToken cancellationToken)
        {
            await _bikeService.DeleteBikeByIdAsync(command.Id);
        }
    }
}
