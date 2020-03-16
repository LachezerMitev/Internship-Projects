using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShopClient.Data.Entity
{
    public class Account : NamedPersistent
    {
        [DisplayName("First Name")]
        [Required(ErrorMessage = "This field is Required!")]
        public string FirstName { get; set; }

        [DisplayName("Surname")]
        [Required(ErrorMessage = "This field is Required!")]
        public string Surname { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "This field is Required!")]
        public string LastName { get; set; }

        public long UserId { get; set; }

        public long AccountStatusId { get; set; }

        public long AccountTypeId { get; set; }
    }
}
