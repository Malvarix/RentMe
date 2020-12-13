using MediatR;

namespace Application.Commands
{
    public class DeleteBikeByIdAsyncCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public DeleteBikeByIdAsyncCommand(int id)
        {
            Id = id;
        }
    }
}