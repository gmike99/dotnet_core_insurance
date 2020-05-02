using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities
{
    public class InsuranceForm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }

        [Required]
        public String DestinationState { get; set; }

        [Required]
        public String PlannedArrivalDate { get; set; }

        [Required]
        public String PlannedDepartureDate { get; set; }

        [Required]
        public Int64 DaysInCountry { get; set; }

        [Required]
        public String InsurancePlan { get; set; }

        public ICollection<Application> Applications { get; set; }
    }
}
