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

<<<<<<< Updated upstream
            };

            Data.Entity.Issue Issue2 = new Data.Entity.Issue
            {

            };

            Data.Entity.Issue Issue3 = new Data.Entity.Issue
            {

            };
            Data.Entity.Issue Issue4 = new Data.Entity.Issue
            {

            };
            Data.Entity.Issue Issue5 = new Data.Entity.Issue
            {

            };
            Data.Entity.Issue Issue6 = new Data.Entity.Issue
            {

            };
            Data.Entity.Issue Issue7 = new Data.Entity.Issue
            {
=======
            Dictionary = JsonConvert.DeserializeObject<Dictionary<long, Data.Entity.Issue>>(json);
        }
>>>>>>> Stashed changes

        public override Dictionary<long, Data.Entity.Issue> GetDictionary() => Dictionary;

        public override string GetPath() => @"C:\Users\Lathe\source\repos\AutoServiceShop\AutoServiceShop\DataBase\Issues.json";
    }
}
