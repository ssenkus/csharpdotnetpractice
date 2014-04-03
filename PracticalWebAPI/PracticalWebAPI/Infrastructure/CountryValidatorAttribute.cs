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
            Debug.WriteLine("IsValid?");
            Client client = value as Client;
            if (client.country == null)
            {
                // nothing sent
                this.ErrorMessage = "Client is null";
                return false;
            }
            else
            {

                bool stateSet = !String.IsNullOrEmpty(client.state);

                switch (client.country)
                {
                    case "US":
                        // US validation - state must be set and abbr. should be in the dictionary keys
                        Dictionary<string, string> states = new StatesList().dict();

                        // empty state?  DENIED
                        if (client.state == null)
                        {
                            ErrorMessage = "US && no state!  Bad news...";
                            return false;
                        }
                        // state abbr. not found in dictionary key? DENIED
                        else if (!states.ContainsKey(client.state))
                        {
                            Debug.WriteLine(String.Format("US?: {0} && stateSet: {1}", client.country, client.state));
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    default:
                        // INTERNATIONAL
                        // Non-US and has a state?  DENIED
                        if (client.state != null)
                        {
                            Debug.WriteLine(String.Format("US?: {0} && stateSet: {1}", client.country, client.state));
                            ErrorMessage = "Non-US countries should not have states";
                            return false;
                        }
                        else
                        {
                            Debug.WriteLine("International countries do not have a states option set yet, so all good");
                            return true;
                        }
                }
            }
        }

    }
}