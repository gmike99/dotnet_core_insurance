using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.OData.Edm;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class Application
    {
        [Key]
        public Int64 Id { get; set; }

        [Required]
        [ForeignKey(nameof(InsuranceClient))]
        public Int64 InsuranceClient { get; set; }

        [Required]
        public Date AppliedDate { get; set; }

        [Required]
        public String ApplicationStatus { get; set; }

        public ICollection<RiskDecision> RiskDecisions { get; set; }

        [Required] // One-To-One
        public InsuranceForm InsuranceForm { get; set; }
    }
}
