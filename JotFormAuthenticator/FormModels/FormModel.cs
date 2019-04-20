using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FormModels.Models
{
    public class FormModel
    {
        [Key]
        public long FormID { get; set; }
        [Required]
        public string FormName { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Created { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Updated { get; }

        public ICollection<FieldModel> Fields { get; set; }
        public ICollection<FormSubmission> FormSubmissions { get; set; }
    }
}
