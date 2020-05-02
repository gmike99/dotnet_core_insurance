using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class InsuranceClient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }

        [Required]
        public String FullName { get; set; }

        [Required]
        public String Email { get; set; }

        [Required]
        public Int64 Age { get; set; }

        [Required]
        public String MaritalStatus { get; set; }

        [Required]
        public String Nationality { get; set; }

        [Required]
        public String Citizenship { get; set; }

        [Required]
        public String Residency { get; set; }

        [Required]
        public String Address { get; set; }

        public ICollection<Application> Applications { get; set; }

        public ICollection<InsuranceContract> InsuranceContracts { get; set; }
    }
}
