using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PracticalWebAPI.Validators
{
    public class LocationCheckerAttribute : ValidationAttribute
    {
        public LocationCheckerAttribute(string country) {
            this.Country = country;
            // this class still needs to be written!  not done!
        }

        public string Country { get; set; }

        public override string FormatErrorMessage(string name)
        {
            return string.Format(ErrorMessageString, name, this.Country);
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string cnt = (string)value;





            return base.IsValid(value, validationContext);
        }

    }
}