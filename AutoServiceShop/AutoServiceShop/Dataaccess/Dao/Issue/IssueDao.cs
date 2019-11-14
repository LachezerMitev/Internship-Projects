using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;

namespace AutoServiceShop.Dataaccess.Dao.Issue
{
    class IssueDao : IIssueDao
    {
        public void Delete(long id)
        {
            Data.Entity.Issue entity = Find(id);
            Delete(entity);
        }

        public void Delete(Data.Entity.Issue entity)
        {
            IssueStorage.IssueList.Remove(entity);
            IssueStorage.IssueDictionary.Remove(entity.Id);
        }

        public void Delete(List<long> idList)
        {
            idList.ForEach(x => Delete(x));
        }

        public List<Data.Entity.Issue> Find()
        {
            return IssueStorage.IssueList;
        }

        public Data.Entity.Issue Find(long id)
        {
            return IssueStorage.IssueList
                .Where(x => x.Id.Equals(id))
                .Single();
        }

        public Data.Entity.Issue Save(Data.Entity.Issue entity)
        {

            IssueStorage.IssueList.Add(entity);
            IssueStorage.IssueDictionary.Add(entity.Id, entity);

            return entity;
        }

        public List<Data.Entity.Issue> Save(List<Data.Entity.Issue> entity)
        {
            entity.ForEach(x => IssueStorage.IssueList.Add(x));

            entity.ForEach(x => IssueStorage.IssueDictionary.Add(x.Id, x));

            return entity;
        }

        public Data.Entity.Issue Update(Data.Entity.Issue entity)
        {
            Delete(entity.Id);
            Save(entity);
            return entity;
        }

        public List<Data.Entity.Issue> Update(List<Data.Entity.Issue> entity)
        {
            entity.ForEach(x => Update(x));
            return entity;
        }
    }
}
