using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FormModels.Models
{
    public class EntityBase
    {
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public DateTime UpdatedBy { get; set; }
        public DateTime Deleted { get; set; }
        public DateTime DeletedBy { get; set; }
    }
}
