using System;
using System.ComponentModel.DataAnnotations;

namespace ValidationMessageValidationSummaryTagHelper_Demo.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please choose gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please choose date of birth")]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateofBirth { get; set; }

        [Required(ErrorMessage = "Please enter address")]
        [StringLength(255)]
        public string Address { get; set; }
    }
}
