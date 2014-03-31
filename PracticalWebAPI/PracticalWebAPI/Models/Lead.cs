using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using PracticalWebAPI.Validators;

namespace PracticalWebAPI.Models
{
    public class Lead
    {
        [Range(0,999999)]
        public int Id { get; set; }

        public string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        
        [Required]
        [MaxLength(2, ErrorMessage="COUNTRY should only be max 2 characters.  You're fugging up, ya know!")]

        

        [LocationChecker]
        public string State { get; set;  }

        public string Country { get; set; }

    }
}