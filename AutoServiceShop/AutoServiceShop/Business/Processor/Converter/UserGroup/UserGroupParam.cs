using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.UserGroup
{
    class UserGroupParam : BaseParamNamed
    {
        public long UserGroupStatusId { get; set; }
        public string UserGroupStatusName { get; set; }
    }
}
