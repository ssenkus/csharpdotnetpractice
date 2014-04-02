using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using PracticalWebAPI.Models;

namespace PracticalWebAPI.Infrastructure
{
    public class CountryValidatorAttribute : ValidationAttribute
    {
        public CountryValidatorAttribute()
        {
            ErrorMessage = "ERROR, want US & CA only.";

        }

        public override bool IsValid(object value)
        {
            Client client = value as Client;
            if (client == null)
            {

                return false;
            }
            else
            {
                bool US = client.country == "US";
                bool stateSet = !String.IsNullOrEmpty(client.state);
                if (!US || stateSet)
                {


                    return false;

                }
                else
                {
                    return true;
                }
            }
        }

    }
}