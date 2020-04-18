using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities
{
    public class InsuranceContract
    {
        [Key]
        public Int64 Id { get; set; }

        [Required]
        public String DocumentScanUrl { get; set; }

        [Required]
        [ForeignKey(nameof(InsuranceCompany))]
        public Int64 InsuranceCompanyId { get; set; }

        [Required]
        [ForeignKey(nameof(InsuranceClient))]
        public Int64 InsuranceClientId { get; set; }
    }
}
