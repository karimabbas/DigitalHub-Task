using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalHub.Models
{
    public class Assessment_True_False
    {
        public int Id { get; set; }
        public bool Is_true { get; set; }
        [ForeignKey("question_id")]
        public Assessments_Questions? Assessments_Questions { get; set; }
    }
}