using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PracticalWebAPI.Validators
{
    public class CountryStatePairAttribute : ValidationAttribute
    {
        private string Country;
        private string State;

        public CountryStatePairAttribute(string state, string country) {
            this.State = state;
            this.Country = country;
            this.ErrorMessage = "ERROR: State \"{0}\" in Country \"{1}\" is invalid!";
        }

        public string FormatErrorMessage(string name, string stateVal)
        {
            return string.Format(ErrorMessageString, name, stateVal);
        }

        protected ValidationResult IsValid() { return new ValidationResult("NOT WORKING WELL!"); }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
        ///    string state = (string)value;
        //    var statesList = new StatesList();
        //    var states = statesList.dict();
        //    foreach (KeyValuePair<string, string> item in states)
        //    {
        //        if (item.Key == state)
        //        {
        //            return ValidationResult.Success;
        //        }
        //    }
            var state = (string)value;
            return new ValidationResult(FormatErrorMessage(validationContext.DisplayName, state));
        }



    }
}