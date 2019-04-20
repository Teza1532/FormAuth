//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace FormModels.Models
//{
//    public class FieldModel
//    {
//        [Key]
//        [DatabaseGenerated(DatabaseGeneratedOption.None)]
//        public int FieldID { get; set; }
//        public int FieldParentFieldID { get; set; }
//        [Required]
//        public string FieldName { get; set; }
//        [Required]
//        public string FieldValue { get; set; }
//        [Required]
//        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//        public DateTime Added { get; }
//        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
//        public DateTime Deleted { get; }
//        [Required]
//        [ForeignKey("FormID")]
//        public FormModel Form { get; set; }

//        public ICollection<SubmissionFieldValues> SubmissionFieldValues { get; set; }
//    }
//}
