﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Account
{
    class AccountResult : BaseResultNamed
    {
        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string LastName { get; set; }

        public long UserId { get; set; }

        public string Username { get; set; }

        public long AccountStatusId { get; set; }

        public string AccountStatusName { get; set; }

    }
}
