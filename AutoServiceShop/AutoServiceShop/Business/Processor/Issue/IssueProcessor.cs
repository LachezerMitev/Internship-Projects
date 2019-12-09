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
        private IIssueParamConverter _issueParamConverter;
        public IIssueParamConverter IssueParamConverter
        {
            set => _issueParamConverter = value;
            get
            {
                if (_issueParamConverter == null)
                {
                    _issueParamConverter = new IssueParamConverter();
                    return _issueParamConverter;
                }
                else
                {
                    return _issueParamConverter;
                }
            }
        }

        private IIssueResultConverter _issueResultConverter;
        public IIssueResultConverter IssueResultConverter
        {
            set => _issueResultConverter = value;
            get
            {
                if (_issueResultConverter == null)
                {
                    _issueResultConverter = new IssueResultConverter();
                    return _issueResultConverter;
                }
                else
                {
                    return _issueResultConverter;
                }
            }
        }

        private IIssueDao _issueDao;
        public IIssueDao IssueDataObject
        {
            set => _issueDao = value;
            get
            {
                if (_issueDao == null)
                {
                    _issueDao = new IssueDao();
                    return _issueDao;
                }
                else
                {
                    return _issueDao;
                }
            }
        }


        public IssueResult Create(IssueParam param)
        {

            Data.Entity.Issue entity = _issueParamConverter.Convert(param, null);

            _issueDao.Save(entity);

            return _issueResultConverter.Convert(entity);
        }

        public List<IssueResult> Create(List<IssueParam> param)
        {
            List<Data.Entity.Issue> entities = new List<Data.Entity.Issue>();
            foreach (var item in param)
            {
                entities.Add(_issueParamConverter.Convert(item, null));
            }
            _issueDao.Save(entities);
            List<IssueResult> result = new List<IssueResult>();
            foreach (var item in entities)
            {
                result.Add(_issueResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            _issueDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.Issue> entity = new List<Data.Entity.Issue>();
            foreach (var id in idList)
            {
                entity.Add(_issueDao.Find(id));
            }
            foreach (var id in idList)
            {
                _issueDao.Delete(id);
            }
        }

        public IssueResult Find(long id)
        {
            try
            {
                Data.Entity.Issue entity = _issueDao.Find(id);
                IssueResult result = _issueResultConverter.Convert(entity);
                return result;
            }
            catch
            {
                return null;
            }

        }

        public List<IssueResult> Find()
        {
            List<Data.Entity.Issue> Issues = _issueDao.Find();
            List<IssueResult> results = new List<IssueResult>();
            foreach (var item in Issues)
            {
                results.Add(_issueResultConverter.Convert(item));
            }
            return results;
        }

        public List<IssueResult> FindByField(string field, string value)
        {
            List<Data.Entity.Issue> Issues = _issueDao.FindByField(field, value);
            List<IssueResult> results = new List<IssueResult>();
            foreach (var item in Issues)
            {
                results.Add(_issueResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, IssueParam param)
        {
            Data.Entity.Issue oldEntity = _issueDao.Find(id);
            Data.Entity.Issue newEntity = _issueParamConverter.Convert(param, oldEntity);
            _issueDao.Update(newEntity);
        }

        public void Update(List<IssueParam> param)
        {
            List<Data.Entity.Issue> entity = new List<Data.Entity.Issue>();
            foreach (var item in param)
            {
                Data.Entity.Issue oldEntity = _issueDao.Find(item.Id);
                Data.Entity.Issue newEntity = _issueParamConverter.Convert(item, oldEntity);
                _issueDao.Update(newEntity);
            }
        }
    }
}
