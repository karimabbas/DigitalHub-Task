using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalHub.Dtos;
using DigitalHub.Models;
using DigitalHub.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DigitalHub.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AssessmentAnswerController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService(typeof(IMediator)) as IMediator;

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] List<CreatePostAnswer> AnswerRequests)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                ListAnswerRequestDto listAnswerRequestDto = new()
                {
                    createPostAnswers = AnswerRequests
                };

                var result = await Mediator.Send(listAnswerRequestDto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> AllAnswers()
        {
            try
            {
                var result = await Mediator.Send(new GetAllAnswers());
                if (result != null)
                {
                    return Ok(result);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}