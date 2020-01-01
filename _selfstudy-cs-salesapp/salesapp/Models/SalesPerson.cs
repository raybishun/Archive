using SalesApp.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SalesApp.Models
{
    class SalesPerson : BaseModel, IActive
    {
        [Required]
        public bool Active { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }


        // A sales person will be assigned a sales region
        public virtual SalesRegion Region { get; set; }

        [Required]
        public int RegionId { get; set; }

        // A sales person can have multiple sales
        public virtual ObservableListSource<Sale> Sales { get; set; }
    }
}
