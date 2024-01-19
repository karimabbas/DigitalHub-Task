using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalHub.Dtos;
using DigitalHub.Models;

namespace DigitalHub.Services
{
    public interface IAnswerService
    {
        Task<bool> CreateAnswer(ListAnswerRequestDto answerReqeustDto);
        Task<List<Assessment_Answer>> GetAllAnswer();
    }
}