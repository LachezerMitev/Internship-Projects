using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Issue
{
    interface IIssueDao
    {
        Data.Entity.Issue Save(Data.Entity.Issue entity);
        List<Data.Entity.Issue> Save(List<Data.Entity.Issue> entity);

        Data.Entity.Issue Update(Data.Entity.Issue entity);
        List<Data.Entity.Issue> Update(List<Data.Entity.Issue> entity);

        void Delete(long id);
        void Delete(Data.Entity.Issue entity);
        void Delete(List<long> idList);

        List<Data.Entity.Issue> Find();
        Data.Entity.Issue Find(long id);
        List<Data.Entity.Issue> FindByField(string field, string value);
    }
}
