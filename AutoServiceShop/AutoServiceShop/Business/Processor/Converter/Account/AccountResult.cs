using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Account
{
    public class AccountResult : BaseResultNamed
    {
        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string LastName { get; set; }

        public string Type { get; set; }

        public long UserId { get; set; }

        public string UserName { get; set; }

        public long AccountStatusId { get; set; }

        public string AccountStatusName { get; set; }

        public long AccountTypeId { get; set; }

        public string AccountTypeName { get; set; }
    }
}
