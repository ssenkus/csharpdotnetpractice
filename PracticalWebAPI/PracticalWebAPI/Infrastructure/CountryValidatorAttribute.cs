using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using PracticalWebAPI.Models;
using System.Diagnostics;

namespace PracticalWebAPI.Infrastructure
{
    public class CountryValidatorAttribute : ValidationAttribute
    {
        public CountryValidatorAttribute()
        {
            ErrorMessage = "DEFAULT ERROR MESSAGE";

        }


        public override bool IsValid(object value)
        {
            Debug.WriteLine(" IsValid?");
            Client client = value as Client;
            if (client == null)
            {
                // nothing sent
                this.ErrorMessage = "Client is null";
                return false;
            }
            else
            {
                // data has been sent
                bool US = client.country == "US";
                bool stateSet = !String.IsNullOrEmpty(client.state);
                Debug.WriteLine("US?", US.ToString());
                Debug.WriteLine("stateSet?", stateSet.ToString());

                if (!US && !stateSet)
                {
                    Debug.WriteLine("International countries do not have states yet, so all good");
                    return true;

                }
                else if (!US && stateSet)
                {
                    Debug.WriteLine(String.Format("US?: {0} && stateSet: {1}", client.country, client.state));
                    ErrorMessage = "Non-US countries should not have states";
                    return false;

                }
                else if (US && stateSet)
                {

                    Debug.WriteLine(String.Format("US?: {0} && stateSet: {1}", client.country, client.state));
                    return true;

                }
                else if (US && !stateSet)
                {
                    Debug.WriteLine("US && no state!  Bad news...");
                    ErrorMessage = "US && no state!  Bad news...";
                    return false;

                }
                return false;
            }
        }

    }
}