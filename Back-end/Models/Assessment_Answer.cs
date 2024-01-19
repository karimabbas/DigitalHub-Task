using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalHub.Models
{
    public class Assessment_Answer
    {
        public int Id { get; set; }
        public byte Score { get; set; }
        public string? Answer { get; set; }

        [ForeignKey("question_id")]
        public Assessments_Questions? Assessments_Questions { get; set; }

        [ForeignKey("assessment_id")]
        public Assessments? Assessments { get; set; }

        [ForeignKey("user_id")]
        public User? User { get; set; }

    }
}