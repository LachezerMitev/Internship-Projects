using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Entity
{
    class Account : NamedPersistent
    {
        public string FirstName { get; set; }

        [JsonIgnore]
        public string Surname { get; set; }

        public string LastName { get; set; }

        [JsonIgnore]
        public string Type { get; set; }


    }
}
