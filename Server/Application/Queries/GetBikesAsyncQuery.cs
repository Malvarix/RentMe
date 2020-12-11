using Domain.Entities;
using System.Collections.Generic;
using MediatR;

namespace Application.Queries
{
    public class GetBikesAsyncQuery : IRequest<IEnumerable<Bike>>
    {

    }
}