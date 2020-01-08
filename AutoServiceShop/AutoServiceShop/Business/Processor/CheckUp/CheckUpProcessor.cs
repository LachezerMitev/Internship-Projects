using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.CheckUp;
using AutoServiceShop.Business.Processor.Converter.CheckUp;
using AutoServiceShop.Business.Processor.Common;

namespace AutoServiceShop.Business.Processor.CheckUp
{
    public class CheckUpProcessor
        : BaseProcessor<ICheckUpParamConverter, ICheckUpResultConverter, CheckUpParam, CheckUpResult, ICheckUpDao, long, Data.Entity.CheckUp>, ICheckUpProcessor
    {
<<<<<<< Updated upstream
        ICheckUpDao CheckUpDao = new CheckUpDao();

        ICheckUpParamConverter CheckUpParamConverter = new CheckUpParamConverter();
        ICheckUpResultConverter CheckUpResultConverter = new CheckUpResultConverter();

        public CheckUpResult Create(CheckUpParam param)
        {
            Data.Entity.CheckUp entity = CheckUpParamConverter.Convert(param, null);
            CheckUpDao.Save(entity);

            return CheckUpResultConverter.Convert(entity);
        }

        public List<CheckUpResult> Create(List<CheckUpParam> param)
        {
            List<Data.Entity.CheckUp> entities = new List<Data.Entity.CheckUp>();
            foreach (var item in param)
            {
                entities.Add(CheckUpParamConverter.Convert(item, null));
            }
            CheckUpDao.Save(entities);
            List<CheckUpResult> result = new List<CheckUpResult>();
            foreach (var item in entities)
            {
                result.Add(CheckUpResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            CheckUpDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.CheckUp> entity = new List<Data.Entity.CheckUp>();
            foreach (var id in idList)
            {
                entity.Add(CheckUpDao.Find(id));
            }
            foreach (var id in idList)
            {
                CheckUpDao.Delete(id);
            }
        }

        public CheckUpResult Find(long id)
        {
            Data.Entity.CheckUp entity = CheckUpDao.Find(id);
            CheckUpResult result = CheckUpResultConverter.Convert(entity);
            return result;
        }

        public List<CheckUpResult> Find()
        {
            List<Data.Entity.CheckUp> entity = CheckUpDao.Find();
            List<CheckUpResult> results = new List<CheckUpResult>();
            foreach (var item in entity)
            {
                results.Add(CheckUpResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, CheckUpParam param)
        {
            Data.Entity.CheckUp oldEntity = CheckUpDao.Find(id);
            Data.Entity.CheckUp newEntity = CheckUpParamConverter.Convert(param, null);
            CheckUpDao.Update(newEntity);
        }

        public void Update(List<CheckUpParam> param)
        {
            List<Data.Entity.CheckUp> entity = new List<Data.Entity.CheckUp>();
            foreach (var item in param)
            {
                Data.Entity.CheckUp oldEntity = CheckUpDao.Find(item.Id);
                Data.Entity.CheckUp newEntity = CheckUpParamConverter.Convert(item, null);
                CheckUpDao.Update(newEntity);
            }
        }
=======
>>>>>>> Stashed changes
    }
}
