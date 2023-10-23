
using System.ComponentModel.DataAnnotations;
namespace ModelDemo.Models
{
    public class Employee:IValidatableObject
    {
        [Required(ErrorMessage = "EmId is required")]
        [Display(Name = "Emp Id")]
        public int EmId { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Employee Name")]
        [MaxLength(40, ErrorMessage = "Name must have less than 40 character")]
        [MinLength(2)]

        public string? Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? EmailId { get; set; }

        [Required]
        public Double Salary { get; set; }
        [Required]
        [Range(18, 60)]
        public int Age { get; set; }
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

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
           
            
                var PName = new[] { "Dob" };
                if (Dob > DateTime.Now)
                {
                    yield return new ValidationResult("Date of birth can not be in future", PName);
                }
                if (Dob < DateTime.Now.AddYears(-100))
                {
                    yield return new ValidationResult("Date of birth can not be in too past", PName);
                }

            }
        }
}
