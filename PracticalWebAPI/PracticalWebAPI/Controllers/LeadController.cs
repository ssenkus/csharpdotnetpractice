using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PracticalWebAPI.Models;

namespace PracticalWebAPI.Controllers
{
    public class LeadController : ApiController
    {

        public static IList<Lead> leads = new List<Lead>() {
            new Lead() {
                Id = 10000,
                FirstName = "Hello",
                LastName = "World",
                Email = "hello@world.xxx",
                Country = "US",
                State = "OR"
            },
            new Lead() {
                Id = 20000,
                FirstName = "Derp",
                LastName = "Dingalong",
                Email = "derp@derp.com",
                Country = "DP",
                State = null
            },
            new Lead() {
                Id = 90000,
                FirstName = "Ling",
                LastName = "Xiohung",
                Email = "lxi@lxi.gov",
                Country = "CH",
                State = null
            },
        };

        public IEnumerable<Lead> Get() 
        {
            return leads.ToList();
        
        }

        public Lead Get(int id) {
            return leads.First(l => l.Id == id);
        }

        public void Post(Lead lead)
        {

            if (ModelState.IsValid)
            {
                leads.Add(lead);
                //Get(lead.Id);
            }
            else
            {
                var errors = ModelState.Where(e => e.Value.Errors.Count > 0)
                    .Select(e => new
                    {
                        Name = e.Key,
                        Message = e.Value.Errors.First().ErrorMessage,
                        Exception = e.Value.Errors.First().Exception
                    }).ToList();

            }
        }

    }
}
