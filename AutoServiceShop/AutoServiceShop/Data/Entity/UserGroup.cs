﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Data.Entity
{
    class UserGroup : NamedPersistent
    {
        public UserGroupStatus UserGroupStatus { get; set; }
    }
}
