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

        public string Surname { get; set; }

        public string LastName { get; set; }

        public string Type { get; set; }

        public virtual User User { get; set; }

<<<<<<< Updated upstream
        public AccountStatus AccountStatus { get; set; }
=======
        [ForeignKey("AccountStatus")]
        public long AccountStatusId { get; set; }

        public virtual AccountStatus AccountStatus { get; set; }

        [ForeignKey("AccountType")]
        public long AccountTypeId { get; set; }

        public virtual AccountType AccountType { get; set; }
>>>>>>> Stashed changes
    }
}
