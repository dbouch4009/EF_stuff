using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProjectSalesApp.Interfaces
{
    interface IActive
    {
        [Required]
        bool IsActive { get; set; }
    }
}
