﻿using MediatR;
using Application.Commands;
using Persistence.ServiceInterfaces;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.CommandHandlers
{
    public class CreateBikeAsyncCommandHandler : IRequest<CreateBikeAsyncCommand>
    {
        private readonly IBikeService _bikeService;

        public CreateBikeAsyncCommandHandler(IBikeService bikeService)
        {
            _bikeService = bikeService;
        }

        public async Task Handle(CreateBikeAsyncCommand command, CancellationToken cancellationToken)
        {
            var bike = new Bike()
            {
                Title = command.Title,
                Type = command.Type,
                Price = command.Price,
                Status = command.Status
            };

            await _bikeService.CreateBikeAsync(bike);
        }
    }
}