using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalHub.DataContext;
using DigitalHub.Repository;
using DigitalHub.Services;
using MediatR;

namespace DigitalHub.Dtos
{
    public class AnswerRequestDto
    {
        public int Question { get; set; }
        public string Type { get; set; }
        public object Answer { get; set; }
    }

    // public class ListAnswerRequestDto : IRequest<bool>
    // {
    //     public List<AnswerRequestDto> AnswerRequests { get; set; }
    // }

    // public class AnswerRequestDtoHandler : IRequestHandler<ListAnswerRequestDto, bool>
    // {
    //     private readonly IAnswerService _answerService;

    //     public AnswerRequestDtoHandler(IAnswerService answerService)
    //     {
    //         _answerService = answerService;
    //     }

    //     public async Task<bool> Handle(ListAnswerRequestDto request, CancellationToken cancellationToken)
    //     {
    //         return await _answerService.CreateAnswer(request);
    //     }
    // }
}

