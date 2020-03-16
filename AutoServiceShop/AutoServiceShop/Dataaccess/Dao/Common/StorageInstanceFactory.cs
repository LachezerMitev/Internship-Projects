using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Common
{
    public static class StorageInstanceFactory<T>
    {
        public static T Instance => Activator.CreateInstance<T>();
    }
}
