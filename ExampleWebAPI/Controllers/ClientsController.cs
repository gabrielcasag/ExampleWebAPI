using ExemploWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;

namespace ExemploWebAPI.Controllers
{
    public class ClientsController : ApiController
    {

        private static List<Client> clientsList = new List<Client>();

        [HttpGet]
        public List<Client> listClients()
        {
            return clientsList;
        }

        [HttpPost]
        public void insertClient(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                clientsList.Add(new Client(name));
            }

        }

        [HttpDelete]
        public void removeClient(string name)
        {
            var idToDelete = clientsList.IndexOf(clientsList.First(x => x.Name.Equals(name)));

            clientsList.RemoveAt(idToDelete);
        }

    }
}
