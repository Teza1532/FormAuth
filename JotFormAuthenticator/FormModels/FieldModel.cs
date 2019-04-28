using JotFormAuthenticator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JotFormAuthenticator.Models
{
    public class FieldModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FieldID { get; set; }
        public int FieldParentFieldID { get; set; }
        [Required]
        public string FieldName { get; set; }
        [Required]
        public string FieldValue { get; set; }
        [Required]
        [ForeignKey("FormSubmission")]
        public FormModel Form { get; set; }
    }
}
