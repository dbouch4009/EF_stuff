using EFProjectSalesApp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProjectSalesApp.Model_Entity
{
    [Table("SalesPeople")]  //optional attribute to change table name
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

        [Required]
        [Range(0.01, Double.MaxValue)]
        [Column("Target")]  //optional attribute to change column name
        public decimal SalesTarget { get; set; }

        public string FullName
        {
            get
            {
                return string.Format(this.FirstName + " " + this.LastName);
            }
        }
    }
}
