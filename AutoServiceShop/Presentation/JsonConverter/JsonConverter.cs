using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AutoServiceShop.Presentation.JsonConverter
{
    class JsonConverter
    {
        public static string ObjToJson(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
