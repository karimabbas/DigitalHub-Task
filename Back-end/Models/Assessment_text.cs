using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalHub.Models
{
    public class Assessment_text
    {
        public int Id { get; set; }

        [ForeignKey("question_id")]
        public Assessments_Questions? Assessments_Questions { get; set; }
        public string? Answer {get;set;}
        public int Orer {get;set;}

    }
}