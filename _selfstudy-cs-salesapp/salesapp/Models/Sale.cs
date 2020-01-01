using System;
using System.ComponentModel.DataAnnotations;

namespace SalesApp.Models
{
    class Sale : BaseModel
    {
        // Sale properties
        [Required]
        [Range(0, double.MaxValue)]
        public decimal Amount { get; set; }

        [Required]
        public DateTime Date { get; set; }

        // A sale will have a sales person
        public virtual SalesPerson Person { get; set; }

        [Required]
        public int PersonId { get; set; }

        // A sale will occur in a particular region
        public virtual SalesRegion Region { get; set; }

        [Required]
        public int RegionId { get; set; }
    }
}
