using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalHub.Services;
using MediatR;

namespace DigitalHub.Dtos
{
    public class CreatePostAnswer
    {
        public int Question { get; set; }
        public string Type { get; set; }
        public object Answer { get; set; }
    }

    public class ListAnswerRequestDto : IRequest<bool>
    {
        public List<CreatePostAnswer> createPostAnswers { get; set; }
    }
    public class CreatePostAnswerHandler : IRequestHandler<ListAnswerRequestDto, bool>
    {
        private readonly IAnswerService _answerService;

        public CreatePostAnswerHandler(IAnswerService answerService)
        {
            _answerService = answerService;
        }
        public async Task<bool> Handle(ListAnswerRequestDto request, CancellationToken cancellationToken)
        {
            return await _answerService.CreateAnswer(request);

        }
    }
}