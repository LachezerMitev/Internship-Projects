using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Account
{
    public class AccountParam : BaseParamNamed
    {
        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string LastName { get; set; }

        public string Type { get; set; }

        public long UserId { get; set; }

        public long AccountStatusId { get; set; }

        public long AccountTypeId { get; set; }
    }
}
