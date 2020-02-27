using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.Issue;
using AutoServiceShop.Business.Processor.Converter.Issue;

namespace AutoServiceShop.Business.Processor.Issue
{
    class IssueProcessor : IIssueProcessor
    {
<<<<<<< Updated upstream
        IIssueDao IssueDao = new IssueDao();

        IIssueParamConverter IssueParamConverter = new IssueParamConverter();
        IIssueResultConverter IssueResultConverter = new IssueResultConverter();

        public IssueResult Create(IssueParam param)
        {
            Data.Entity.Issue entity = IssueParamConverter.Convert(param, null);
            IssueDao.Save(entity);

            return IssueResultConverter.Convert(entity);
        }

        public List<IssueResult> Create(List<IssueParam> param)
        {
            List<Data.Entity.Issue> entities = new List<Data.Entity.Issue>();
            foreach (var item in param)
            {
                entities.Add(IssueParamConverter.Convert(item, null));
            }
            IssueDao.Save(entities);
            List<IssueResult> result = new List<IssueResult>();
            foreach (var item in entities)
            {
                result.Add(IssueResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            IssueDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.Issue> entity = new List<Data.Entity.Issue>();
            foreach (var id in idList)
            {
                entity.Add(IssueDao.Find(id));
            }
            foreach (var id in idList)
            {
                IssueDao.Delete(id);
            }
        }

        public IssueResult Find(long id)
        {
            Data.Entity.Issue entity = IssueDao.Find(id);
            IssueResult result = IssueResultConverter.Convert(entity);
            return result;
        }

        public List<IssueResult> Find()
        {
            List<Data.Entity.Issue> entity = IssueDao.Find();
            List<IssueResult> results = new List<IssueResult>();
            foreach (var item in entity)
            {
                results.Add(IssueResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, IssueParam param)
        {
            Data.Entity.Issue oldEntity = IssueDao.Find(id);
            Data.Entity.Issue newEntity = IssueParamConverter.Convert(param, null);
            IssueDao.Update(newEntity);
        }

        public void Update(List<IssueParam> param)
=======
        public IssueProcessor(IIssueDao dao, IIssueParamConverter paramConverter, IIssueResultConverter resultConverter) : base(dao, paramConverter, resultConverter)
>>>>>>> Stashed changes
        {
            List<Data.Entity.Issue> entity = new List<Data.Entity.Issue>();
            foreach (var item in param)
            {
                Data.Entity.Issue oldEntity = IssueDao.Find(item.Id);
                Data.Entity.Issue newEntity = IssueParamConverter.Convert(item, null);
                IssueDao.Update(newEntity);
            }
        }
    }
}
