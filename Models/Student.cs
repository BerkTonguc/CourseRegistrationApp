using System.ComponentModel.DataAnnotations;

namespace CourseApp.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Please enter you name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Pleaseenter your email address.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your mobile phone number.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please make your choice.")]
        public bool? Confirm { get; set; }
    }
}