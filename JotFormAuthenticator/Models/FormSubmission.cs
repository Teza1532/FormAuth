using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FormModels.Models
{
    public class FormSubmission
    {
        [Key]
        public int SubmissionID { get; set; }
        [ForeignKey("FormID")]
        public FormModel Form { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Created { get; }
        public string CreatedBy { get; set; }
        public bool Accepted { get; set; }
        public DateTime Reviewed { get; set; }
        public string ReviewedBy { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Deleted { get; set; }

        public ICollection<SubmissionFieldValues> SubmissionFieldValues { get; set; }
    }
}
