using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProjectSalesApp.Model_Entity
{
    class Sale : BaseModel
    {
        [Required]
        [Range(0.01, Double.MaxValue)]
        public decimal Amount { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public virtual SalesPerson Person { get; set; }  //virtual allows EF to track when this gets changed

        [Required]
        public int PersonId { get; set; }  //This naming convention will allow EF to track them automatically

        public virtual SalesRegion Region { get; set; }  //virtual allows EF to track when this gets changed

        [Required]
        public int RegionId { get; set; }  //This naming convention will allow EF to track them automatically

        [Required]
        public SalesStatuses Status { get; set; }

    }
}
