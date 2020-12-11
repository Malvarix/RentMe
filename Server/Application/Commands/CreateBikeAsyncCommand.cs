using Domain.Entities;
using Domain.Enums;
using MediatR;

namespace Application.Commands
{
    public class CreateBikeAsyncCommand : IRequest<Bike>
    {
        public string Title { get; set; }
        public Type Type { get; set; }
        public decimal Price { get; set; }
        public Status Status { get; set; }

        public CreateBikeAsyncCommand(Bike bike)
        {
            Title = bike.Title;
            Type = bike.Type;
            Price = bike.Price;
            Status = bike.Status;
        }
    }
}