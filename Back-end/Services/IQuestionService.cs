using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalHub.Models;

namespace DigitalHub.Services
{
    public interface IQuestionService
    {
        Assessments_Questions GetQuestion(int id);
    }
}