using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalHub.Models
{
    public class Assessment_Questions_Relation
    {
        public int Id { get; set; }

        [ForeignKey("assesment_id")]
        public Assessments? Assessments { get; set; }

        [ForeignKey("question_id")]
        public Assessments_Questions? Assessments_Questions { get; set; }
    }
}