using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShopClient.Data.Entity
{
    public class User : Persistent
    {
        [DisplayName("User name")]
        [Required(ErrorMessage = "This field is Required!")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "This field is Required!")]
        public string Password { get; set; }
    }
}
