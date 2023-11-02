using System.ComponentModel.DataAnnotations;

namespace form_asp_net_app.Models
{
    public enum City { Krakau = 1, Warsaw = 2, London = 3, Paris = 4, Berlin = 5 }

    public class User
    {
        [Required(ErrorMessage = "Name field is required")]
        [MinLength(2, ErrorMessage = "Name must contain at least 2 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname field is required")]
        [MinLength(2, ErrorMessage = "Surname must contain at least 2 characters")]
        public string Surname { get; set; }

        [Range(10, 80, ErrorMessage = "Age must be between 10 and 80")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Email address field is required")]
        [EmailAddress(ErrorMessage = "Email address is not valid")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Phone field is not valid")]
        public string Phone { get; set; }

        public City City { get; set; }

        [Required(ErrorMessage = "Password field is required")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[a-zA-Z\\d]{8,}$", ErrorMessage = "Password must contain at least one upper/lower letter, one number and be longer than 8 charaters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Repeat password field is required")]
        [Compare(nameof(Password), ErrorMessage = "Passwords don't match")]
        public string RepeatPassword { get; set; }
    }
}
