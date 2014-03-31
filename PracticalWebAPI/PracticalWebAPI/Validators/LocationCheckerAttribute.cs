using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using PracticalWebAPI.Models;

namespace PracticalWebAPI.Validators
{
    public class LocationCheckerAttribute : ValidationAttribute
    {
        public LocationCheckerAttribute()
        {
            this.ErrorMessage = "ERROR: {0}:{1} is not a US State.";
        }

        public string FormatErrorMessage(string name, string stateVal)
        {
            return string.Format(ErrorMessageString, name, stateVal);
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string state = (string)value;
            var statesList = new StatesList();
            var states = statesList.dict();
            foreach (KeyValuePair<string, string> item in states)
            {
                if (item.Key == state)
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult(FormatErrorMessage(validationContext.DisplayName, state));
        }

    }
}