using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace DigitalHub.Dtos
{
    public class AnswerResponseDto
    {
        public string Question { get; set; }
        public string? Type { get; set; }
        public string? Answer { get; set; }
    }
}