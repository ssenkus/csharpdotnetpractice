using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PracticalWebAPI.Infrastructure;

namespace PracticalWebAPI.Models
{
    [CountryValidator]
    public class Client
    {

        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string streetAddress { get; set; }
        public string apartment { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string state { get; set; }



    }
}