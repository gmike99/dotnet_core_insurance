using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class Application
    {
        [Key]
        public Int64 Id { get; set; }

        [Required]
        public String AppliedDate { get; set; }

        [Required]
        public String ApplicationStatus { get; set; }

        [Required]
        [ForeignKey(nameof(InsuranceClient))]
        public Int64 InsuranceClientId { get; set; }

        [Required]
        [ForeignKey(nameof(InsuranceForm))]
        public Int64 InsuranceFormId { get; set; }

        public ICollection<RiskDecision> RiskDecisions { get; set; }
    }
}
