using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Common
{
    abstract class BaseStorage<T>
    { 
        public static string PathToFile { get; set; }

        public static List<T> ListEntities { get; set; }
        
        // Method for saving the changes in a file
        public static void SaveInFile()
        {
            // Removing all the contents of the file 
            File.WriteAllText(PathToFile, string.Empty);

            // Converting all the objects in our list to Json format
            string jsonString = JsonConvert.SerializeObject(ListEntities, Formatting.Indented);

            // Saving the json string to the file 
            File.WriteAllText(PathToFile, jsonString);
        }
    }
}
