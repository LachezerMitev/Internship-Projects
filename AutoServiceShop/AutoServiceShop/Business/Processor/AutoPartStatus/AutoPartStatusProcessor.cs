using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.AutoPartStatus;
using AutoServiceShop.Business.Processor.Converter.AutoPartStatus;
using AutoServiceShop.Business.Processor.Common;

namespace AutoServiceShop.Business.Processor.AutoPartStatus
{
    public class AutoPartStatusProcessor
        : BaseProcessor<IAutoPartStatusParamConverter, IAutoPartStatusResultConverter, AutoPartStatusParam, AutoPartStatusResult, IAutoPartStatusDao, long, Data.Entity.AutoPartStatus>, IAutoPartStatusProcessor
    {
<<<<<<< Updated upstream
        IAutoPartStatusDao AutoPartStatusDao = new AutoPartStatusDao();

        IAutoPartStatusParamConverter AutoPartStatusParamConverter = new AutoPartStatusParamConverter();
        IAutoPartStatusResultConverter AutoPartStatusResultConverter = new AutoPartStatusResultConverter();

        public AutoPartStatusResult Create(AutoPartStatusParam param)
        {
            Data.Entity.AutoPartStatus entity = AutoPartStatusParamConverter.Convert(param, null);
            AutoPartStatusDao.Save(entity);

            return AutoPartStatusResultConverter.Convert(entity);
        }

        public List<AutoPartStatusResult> Create(List<AutoPartStatusParam> param)
        {
            List<Data.Entity.AutoPartStatus> entities = new List<Data.Entity.AutoPartStatus>();
            foreach (var item in param)
            {
                entities.Add(AutoPartStatusParamConverter.Convert(item, null));
            }
            AutoPartStatusDao.Save(entities);
            List<AutoPartStatusResult> result = new List<AutoPartStatusResult>();
            foreach (var item in entities)
            {
                result.Add(AutoPartStatusResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            AutoPartStatusDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.AutoPartStatus> entity = new List<Data.Entity.AutoPartStatus>();
            foreach (var id in idList)
            {
                entity.Add(AutoPartStatusDao.Find(id));
            }
            foreach (var id in idList)
            {
                AutoPartStatusDao.Delete(id);
            }
        }

        public AutoPartStatusResult Find(long id)
        {
            Data.Entity.AutoPartStatus entity = AutoPartStatusDao.Find(id);
            AutoPartStatusResult result = AutoPartStatusResultConverter.Convert(entity);
            return result;
        }

        public List<AutoPartStatusResult> Find()
        {
            List<Data.Entity.AutoPartStatus> entity = AutoPartStatusDao.Find();
            List<AutoPartStatusResult> results = new List<AutoPartStatusResult>();
            foreach (var item in entity)
            {
                results.Add(AutoPartStatusResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, AutoPartStatusParam param)
        {
            Data.Entity.AutoPartStatus oldEntity = AutoPartStatusDao.Find(id);
            Data.Entity.AutoPartStatus newEntity = AutoPartStatusParamConverter.Convert(param, null);
            AutoPartStatusDao.Update(newEntity);
        }

        public void Update(List<AutoPartStatusParam> param)
=======
        public AutoPartStatusProcessor(IAutoPartStatusDao dao, IAutoPartStatusParamConverter paramConverter, IAutoPartStatusResultConverter resultConverter) : base(dao, paramConverter, resultConverter)
>>>>>>> Stashed changes
        {
        }
    }
}
