using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalHub.Models
{
    public class Assessment_enrols
    {
        public int Id { get; set; }

        [ForeignKey("User_id")]
        public User? User { get; set; }

        [ForeignKey("assessment_id")]
        public Assessments? Assessments { get; set; }
        public int Result { get; set; }
        public int Score { get; set; }
    }
}