using EFProjectSalesApp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProjectSalesApp.Model_Entity
{
    class SalesPerson : BaseModel, IActive
    {
        [Required]
        [StringLength(100)]  //Data Annotations
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]  //Data Annotations
        public string LastName { get; set; }
        public bool IsActive { get; set; }

        public virtual ObservableListSource<Sale> Sales { get; set; }
    }
}
