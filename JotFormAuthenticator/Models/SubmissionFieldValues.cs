using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FormModels.Models
{
    public class SubmissionFieldValues
    {
        [Key]
        public int SubmissionFieldValuesID { get; set; }
        [ForeignKey("FieldID")]
        public FieldModel FieldModel { get; set; }
        [ForeignKey("FormSubmissionID")]
        public FormSubmission FormSubmission { get; set; }
        [Required]
        public string FormSubmissionValue { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
    }
}
