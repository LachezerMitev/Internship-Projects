using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Common
{
    public abstract class BaseStorage<T, TId> : IBaseStorage<T, TId>
    {
        // Method for saving the changes in a file
        public void SaveInFile( string PathToFile, Dictionary<TId, T> Entities)
        {
            // Removing all the contents of the file 
            File.WriteAllText(PathToFile, string.Empty);

            // Converting all the objects in our list to Json format
            string jsonString = JsonConvert.SerializeObject(Entities, Formatting.Indented);

            // Saving the json string to the file 
            File.WriteAllText(PathToFile, jsonString);
        }

        public abstract Dictionary<TId, T> GetDictionary();

        public abstract string GetPath();

    }
}
