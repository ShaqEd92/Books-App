using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System;

namespace Stacks.Models
{
    public class Reader
    {
        [Key]
        public int ReaderID { get; set; }

        [Display(Name = "First Name")]
        [Letters]
        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Letters]
        [Required]
        [MinLength(2)]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required]
        [StrongPassword]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password { get; set; }

        [NotMapped]
        [Display(Name = "Confirm Password")]
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Confirmed password must match with password entered")]
        [MinLength(8)]
        public string ConfirmPassword { get; set; }

        public List<Read> BooksRead { get; set; }

        public List<ReadList> ReadingList { get; set; }

        public List<Favorite> MyFaves { get; set; }

        public List<Comment> MyComments { get; set; }
    }


    // VALIDATIONS

    public class LettersAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
                return new ValidationResult("Must enter name.");
            else
            {
                string word = value.ToString();
                bool numbers = word.Any(char.IsDigit);
                if (numbers == false)
                    return ValidationResult.Success;
                return new ValidationResult("Name fields must be non-numeric.");
            }
        }
    }

    public class StrongPasswordAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
                return new ValidationResult("Must enter a password.");
            else
            {
                string password = value.ToString();
                var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
                bool letter = password.Any(char.IsLetter);
                bool number = password.Any(char.IsDigit);
                if (letter == true && number == true && hasSymbols.IsMatch(password))
                    return ValidationResult.Success;
                return new ValidationResult("Your password must contain at least one letter, one number and one special character.");
            }
        }
    }
}
