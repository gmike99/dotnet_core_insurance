using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class InsuranceClient
    {
        [Key]
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
