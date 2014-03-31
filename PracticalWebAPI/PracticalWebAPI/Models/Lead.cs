using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using PracticalWebAPI.Validators;
using System.Diagnostics;

namespace PracticalWebAPI.Models
{
    public class Lead : IValidatableObject
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string State { get; set; }

        [Required]
        [MaxLength(2, ErrorMessage = "COUNTRY should only be max 2 characters.  You're fugging up, ya know!")]
        public string Country { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {

            if (this.Id < 10000 || this.Id > 99999)
            {
                yield return new ValidationResult("ID must be in the range of 10000-99999");
            }

            if (String.IsNullOrEmpty(this.FirstName))
            {
                yield return new ValidationResult("First Name is required");
            }
            if (String.IsNullOrEmpty(this.LastName))
            {
                yield return new ValidationResult("Last Name is required");
            }

            if (this.LastName.Length > 20)
            {
                yield return new ValidationResult("Last Name is too long");
            }


            // Re-using DataAnnotation [EmailAddress] programmatically
            // Debug.WriteLine(String.Format("Email Validates: {0} - {1}",this.Email.ToString(), new EmailAddressAttribute().IsValid(this.Email).ToString()));
            if (new EmailAddressAttribute().IsValid(this.Email) == false) {
                yield return new ValidationResult("The email address provided is invalid");
            }

            //if (new CountryStatePairAttribute(this.Country, this.State).IsValid(this.State) == false) 
            //{
            //    yield return new ValidationResult("sdfsdfsdfsdf");
            //}

        }


    }
}