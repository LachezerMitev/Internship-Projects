using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Common
{
    interface IBaseStorage<T, TId>
    {
        void SaveInFile(string PathToFile, Dictionary<TId, T> Entities);    

        Dictionary<TId, T> GetDictionary();

        string GetPath();
    }
}
