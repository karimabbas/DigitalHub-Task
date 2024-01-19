using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalHub.Models;
using DigitalHub.Services;
using MediatR;

namespace DigitalHub.Dtos
{
    public class GetAllAnswers : IRequest<IEnumerable<Assessment_Answer>>
    {
        public class GetAllAnswersHandler : IRequestHandler<GetAllAnswers, IEnumerable<Assessment_Answer>>
        {
            private readonly IAnswerService _answerService;
            public GetAllAnswersHandler(IAnswerService answerService)
            {
                _answerService = answerService;
            }

            public async Task<IEnumerable<Assessment_Answer>> Handle(GetAllAnswers request, CancellationToken cancellationToken)
            {
                return await _answerService.GetAllAnswer();

            }
        }

    }

}
