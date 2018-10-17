using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProjectSalesApp.Model_Entity
{
    class BaseModel
    {
        [Key] //unique identifier for each entry
        [Required]
        public int id { get; set; }

        public string CreatedByUser { get; set; }

        public DateTime CreatedDate { get; set; }

        public string UpdatedByUser { get; set; }

        public DateTime UpdatedDate { get; set; }

        


    }
}
