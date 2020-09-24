using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExemploWebAPI.Models
{
    public class Client
    {
        public string Name { get; set; }

        public Client(string name)
        {
            this.Name = name;
        }
    }
}