using AutoServiceShop.Dataaccess.Dao.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Issue
{
    class IssueStorage : BaseStorage<Data.Entity.Issue, long>
    {
        public static List<Data.Entity.Issue> List = new List<Data.Entity.Issue>();
        public static Dictionary<long, Data.Entity.Issue> Dictionary = new Dictionary<long, Data.Entity.Issue>();

        static IssueStorage()
        {
            string json = File.ReadAllText(@"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\Issues.json");

            List = JsonConvert.DeserializeObject<List<Data.Entity.Issue>>(json);

            Dictionary = List.ToDictionary(x => x.Id, x => x);
        }

        public override Dictionary<long, Data.Entity.Issue> GetDictionary() => Dictionary;

        public override string GetPath() => @"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\Issues.json";
    }
}
