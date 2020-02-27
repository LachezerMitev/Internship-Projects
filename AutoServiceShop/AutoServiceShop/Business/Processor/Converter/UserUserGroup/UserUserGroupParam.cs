using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.UserUserGroup
{
<<<<<<< Updated upstream
    class UserUserGroupParam : BaseParamNamed
=======
    public class UserUserGroupParam : BaseParam<long>
>>>>>>> Stashed changes
    {
        
        public long UserId { get; set; }
        public string Username { get; set; }
    }
}
