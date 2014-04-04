using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PracticalWebAPI.Models;

namespace PracticalWebAPI.Controllers
{

    public class CatController : ApiController
    {

        private static IList<Cat> cats = new List<Cat>()
        {
            new Cat() {
                id = 0,
                name = "Grumpy",
                age = 4,
                breed = "Dwarfcat"
            },
            new Cat() {
                id = 1,
                name = "Henry",
                age = 6,
                breed = "Siamese"
            },
            new Cat() {
                id = 2,
                name = "Numnum",
                age = 5,
                breed = "Fatcat"
            }

        };

        public IEnumerable<Cat> Get()
        {
            return cats;
        }

        public Cat Get(int id)
        {
            return cats.First(e => e.id == id);
        }


        
    }
}
