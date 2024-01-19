using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalHub.DataContext;
using DigitalHub.Models;
using DigitalHub.Services;

namespace DigitalHub.Repository
{
    public class QuestionRepository : IQuestionService
    {
        private readonly MyDataContext _myDataContext;
        public QuestionRepository(MyDataContext myDataContext)
        {
            _myDataContext = myDataContext;
        }
        public Assessments_Questions GetQuestion(int id)
        {
            return _myDataContext.Assessments_Questions.Where(x => x.Id == id).First();
        }
    }
}