using Application.Commands;
using Application.Queries;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BikesAPI.Controllers
{
    [ApiController, Route("api/[controller]")]
    public class BikesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BikesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetBikesAsync()
        {
            try
            {
                return Ok(await _mediator.Send(new GetBikesAsyncQuery()));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("{bikeId}")]
        public async Task<IActionResult> GetBikeByIdAsync(int bikeId = 0)
        {
            try
            {
                if (bikeId != 0)
                    return Ok(await _mediator.Send(new GetBikeByIdAsyncQuery(bikeId)));
                else
                    throw new InvalidOperationException($"Bike with id = {bikeId} can't exist");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateBikeAsync(Bike bike)
        {
            try
            {
                if (ModelState.IsValid)
                    return Ok(await _mediator.Send(new CreateBikeAsyncCommand(bike)));
                else
                    throw new InvalidOperationException($"Bike model from client side is invalid");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBikeAsync(Bike bike)
        {
            try
            {
                if (ModelState.IsValid)
                    return Ok(await _mediator.Send(new UpdateBikeAsyncCommand(bike)));
                else
                    throw new InvalidOperationException($"Bike model from client side is invalid");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete("{bikeId}")]
        public async Task<IActionResult> DeleteBikeByIdAsync(int bikeId = 0)
        {
            try
            {
                if (bikeId != 0)
                    return Ok(await _mediator.Send(new DeleteBikeByIdAsyncCommand(bikeId)));
                else
                    throw new InvalidOperationException($"Bike with id = {bikeId} can't exist");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}