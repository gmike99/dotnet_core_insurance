using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Entities
{
    public class InsuranceCompany
    {
        [Key]
        public Int64 Id { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public String State { get; set; }

        public Int64 NumEmployees { get; set; }

        [Required]
        public String Specialty { get; set; }

        public ICollection<Application> Applications { get; set; }

        public ICollection<InsuranceContract> InsuranceContracts { get; set; }
    }
}
