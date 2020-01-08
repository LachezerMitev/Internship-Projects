using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Entity
{
    public class Account : NamedPersistent
    {
        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string LastName { get; set; }

        [ForeignKey("User")]
        public long UserId { get; set; }

        public User User { get; set; }

        [ForeignKey("AccountStatus")]
        public long AccountStatusId { get; set; }

        public AccountStatus AccountStatus { get; set; }

        [ForeignKey("AccountType")]
        public long AccountTypeId { get; set; }

        public AccountType AccountType { get; set; }
    }
}
