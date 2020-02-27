using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Issue
{
    class IssueStorage
    {
        public static List<Data.Entity.Issue> IssueList = new List<Data.Entity.Issue>();
        public static Dictionary<long, Data.Entity.Issue> IssueDictionary = new Dictionary<long, Data.Entity.Issue>();

        static IssueStorage()
        {
            Data.Entity.Issue Issue1 = new Data.Entity.Issue
            {

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

            };
            Data.Entity.Issue Issue8 = new Data.Entity.Issue
            {

            };
            Data.Entity.Issue Issue9 = new Data.Entity.Issue
            {

            };
            Data.Entity.Issue Issue10 = new Data.Entity.Issue
            {

            };

            IssueList.Add(Issue1);
            IssueList.Add(Issue2);
            IssueList.Add(Issue3);
            IssueList.Add(Issue4);
            IssueList.Add(Issue5);
            IssueList.Add(Issue6);
            IssueList.Add(Issue7);
            IssueList.Add(Issue8);
            IssueList.Add(Issue9);
            IssueList.Add(Issue10);

            IssueDictionary.Add(Issue1.Id, Issue1);
            IssueDictionary.Add(Issue2.Id, Issue2);
            IssueDictionary.Add(Issue3.Id, Issue3);
            IssueDictionary.Add(Issue4.Id, Issue4);
            IssueDictionary.Add(Issue5.Id, Issue5);
            IssueDictionary.Add(Issue6.Id, Issue6);
            IssueDictionary.Add(Issue7.Id, Issue7);
            IssueDictionary.Add(Issue8.Id, Issue8);
            IssueDictionary.Add(Issue9.Id, Issue9);
            IssueDictionary.Add(Issue10.Id, Issue10);

        }
    }
}
