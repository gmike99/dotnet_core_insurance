using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Entities
{
    public class InsuranceForm
    {
        [Key]
        public Int64 Id { get; set; }

        [Required]
        public String DestinationState { get; set; }

        [Required]
        public Date PlannedArrivalDate { get; set; }

        [Required]
        public Date PlannedDepartureDate { get; set; }

        [Required]
        public Int64 DaysInCountry { get; set; }

        [Required]
        public String InsurancePlan { get; set; }

        [Required] // One-To-One
        public Application Application { get; set; }
    }
}
