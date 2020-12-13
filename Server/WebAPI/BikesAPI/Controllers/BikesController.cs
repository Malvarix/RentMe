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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBikeByIdAsync(int id = 0)
        {
            try
            {
                if (id != 0)
                    return Ok(await _mediator.Send(new GetBikeByIdAsyncQuery(id)));
                else
                    throw new InvalidOperationException($"Bike with id = {id} can't exist");
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
        public async Task<IActionResult> UpdateBikeStatusByIdAsync([FromBody]int id = 0)
        {
            try
            {
                if (id != 0)
                    return Ok(await _mediator.Send(new UpdateBikeStatusByIdAsyncCommand(id)));
                else
                    throw new InvalidOperationException($"Bike with id = {id} can't exist");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBikeByIdAsync(int id = 0)
        {
            try
            {
                if (id != 0)
                    return Ok(await _mediator.Send(new DeleteBikeByIdAsyncCommand(id)));
                else
                    throw new InvalidOperationException($"Bike with id = {id} can't exist");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}