using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ModelDemo.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Name  required")]
 [Display(Name = "Stud Id")]
 public int StudId { get; set; }
        [Required(ErrorMessage = "Name  required")]
        [Display(Name = "Student Name")]
        [MaxLength(40, ErrorMessage = "Name must have less than 40 characters")]
        [MinLength(2)]
        public string? Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? EmailId { get; set; }
        [Required]
        public double MArks { get; set; }
        [Required]
        [Range(18, 60)]
        public int Age { get; set; }
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage
        = "Password does not match")]
        [DataType(DataType.Password)]
        public string? ConfirmPassword
        {
            get;
            set;
        }

       
    }
}
