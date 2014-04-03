using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PracticalWebAPI.Models;

namespace PracticalWebAPI.Controllers
{
    public class ClientController : ApiController
    {

        private static IList<Client> clients = new List<Client>()
        {
            new Client() {
                id = 0,
                firstName = "Steven",
                lastName = "Senkus",
                streetAddress = "123 Awesome St.",
                apartment = "Apt #808",
                city = "Portland",
                state = "OR",
                country = "US"
            },
            new Client() {
                id = 1,
                firstName = "Hello",
                lastName = "World",
                streetAddress = "Awesomestrasse 123",
                apartment =  null,
                city = "Berlin",
                state = null,
                country = "DE"
            }
        };

        public IEnumerable<Client> Get()
        {
            return clients;
        }

        public Client Get(int id)
        {
            return clients.First(c => c.id == id);
        }

        public void Delete(int id)
        {
            Client c = Get(id);
            clients.Remove(c);

        }

        public HttpResponseMessage Post(Client client)
        {
            int maxId = clients.Max(e => e.id);
            client.id = maxId + 1;
            clients.Add(client);
            var response = Request.CreateResponse<Client>(HttpStatusCode.Created, client);
            string uri = Url.Link("DefaultApi", new { id = client.id });
            response.Headers.Location = new Uri(uri);
            return response;

        }


    }
}
