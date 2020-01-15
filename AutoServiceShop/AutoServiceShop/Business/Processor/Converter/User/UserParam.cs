using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.User
{
<<<<<<< Updated upstream
    class UserParam : BaseParamNamed
=======
    public class UserParam : BaseParam<long>
>>>>>>> Stashed changes
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
