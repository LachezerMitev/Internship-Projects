using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.AutoPart;
using AutoServiceShop.Business.Processor.Converter.AutoPart;

namespace AutoServiceShop.Business.Processor.AutoPart
{
    class AutoPartProcessor : IAutoPartProcessor
    {
        IAutoPartDao AutoPartDao = new AutoPartDao();

        IAutoPartParamConverter AutoPartParamConverter = new AutoPartParamConverter();
        IAutoPartResultConvert AutoPartResultConverter = new AutoPartResultConverter();

        public AutoPartResult Create(AutoPartParam param)
        {
            Data.Entity.AutoPart entity = AutoPartParamConverter.Convert(param);
            AutoPartDao.Save(entity);

            return AutoPartResultConverter.Convert(entity);
        }

        public List<AutoPartResult> Create(List<AutoPartParam> param)
        {
            List<Data.Entity.AutoPart> entities = new List<Data.Entity.AutoPart>();
            foreach (var item in param)
            {
                entities.Add(AutoPartParamConverter.Convert(item));
            }
            AutoPartDao.Save(entities);
            List<AutoPartResult> result = new List<AutoPartResult>();
            foreach (var item in entities)
            {
                result.Add(AutoPartResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            AutoPartDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.AutoPart> entity = new List<Data.Entity.AutoPart>();
            foreach (var id in idList)
            {
                entity.Add(AutoPartDao.Find(id));
            }
            foreach (var id in idList)
            {
                AutoPartDao.Delete(id);
            }
        }

        public AutoPartResult Find(long id)
        {
            Data.Entity.AutoPart entity = AutoPartDao.Find(id);
            AutoPartResult result = AutoPartResultConverter.Convert(entity);
            return result;
        }

        public List<AutoPartResult> Find()
        {
            List<Data.Entity.AutoPart> accounts = AutoPartDao.Find();
            List<AutoPartResult> results = new List<AutoPartResult>();
            foreach (var item in accounts)
            {
                results.Add(AutoPartResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, AutoPartParam param)
        {
            Data.Entity.AutoPart oldEntity = AutoPartDao.Find(id);
            Data.Entity.AutoPart newEntity = AutoPartParamConverter.Convert(param);
            AutoPartDao.Update(newEntity);
        }

        public void Update(List<AutoPartParam> param)
        {
            List<Data.Entity.AutoPart> entity = new List<Data.Entity.AutoPart>();
            foreach (var item in param)
            {
                Data.Entity.AutoPart oldEntity = AutoPartDao.Find(item.Id);
                Data.Entity.AutoPart newEntity = AutoPartParamConverter.Convert(item);
                AutoPartDao.Update(newEntity);
            }
        }
    }
}
