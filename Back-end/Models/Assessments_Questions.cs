using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalHub.Models
{
    public class Assessments_Questions
    {
        public int Id { get; set; }
        public string? Question { get; set; }
        public string? Type { get; set; }
        public ICollection<Assessment_Questions_Relation>? Assessment_Questions_Relations { get; set; }

    }
}