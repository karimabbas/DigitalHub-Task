using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalHub.DataContext;
using DigitalHub.Dtos;
using DigitalHub.Models;
using DigitalHub.Services;
using Microsoft.EntityFrameworkCore;

namespace DigitalHub.Repository
{
    public class AnswerRepository : IAnswerService
    {
        private readonly MyDataContext _myDataContext;
        public AnswerRepository(MyDataContext myDataContext)
        {
            _myDataContext = myDataContext;
        }

        public async Task<bool> CreateAnswer(ListAnswerRequestDto answerReqeustDto)
        {
            for (int i = 0; i < answerReqeustDto.createPostAnswers.Count; i++)
            {
                var Q = _myDataContext.Assessments_Questions.Where(x => x.Id == answerReqeustDto.createPostAnswers[i].Question).SingleOrDefault();

                Assessment_Answer newAnswer = new()
                {
                    Answer = answerReqeustDto.createPostAnswers[i]?.Answer.ToString(),
                    Assessments_Questions = Q,
                };

                await _myDataContext.AddAsync(newAnswer);
            }
            return _myDataContext.SaveChanges() > 0;

        }

        public async Task<List<Assessment_Answer>> GetAllAnswer()
        {
            return await _myDataContext.Assessment_Answers.AsNoTracking().Include(x => x.Assessments_Questions).ToListAsync();
        }

    }
}