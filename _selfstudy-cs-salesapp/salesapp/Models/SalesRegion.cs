using SalesApp.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SalesApp.Models
{
    class SalesRegion : BaseModel, IActive
    {
        [Required]
        public bool Active { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(3)]
        public string Code { get; set; }

        public virtual ObservableListSource<SalesPerson> People { get; set; }

        public virtual ObservableListSource<Sale> Sales { get; set; }
    }
}
