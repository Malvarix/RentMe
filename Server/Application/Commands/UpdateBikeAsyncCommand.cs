using Domain.Entities;
using Domain.Enums;
using MediatR;

namespace Application.Commands
{
    public class UpdateBikeAsyncCommand : IRequest<Bike>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Type Type { get; set; }
        public decimal Price { get; set; }
        public Status Status { get; set; }

        public UpdateBikeAsyncCommand(Bike bike)
        {
            Id = bike.Id;
            Title = bike.Title;
            Type = bike.Type;
            Price = bike.Price;
            Status = bike.Status;
        }
    }
}