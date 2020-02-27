using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.Make;
using AutoServiceShop.Business.Processor.Converter.Make;

namespace AutoServiceShop.Business.Processor.Make
{
    class MakeProcessor : IMakeProcessor
    {
<<<<<<< Updated upstream
        IMakeDao MakeDao = new MakeDao();

        IMakeParamConverter MakeParamConverter = new MakeParamConverter();
        IMakeResultConverter MakeResultConverter = new MakeResultConverter();

        public MakeResult Create(MakeParam param)
        {
            Data.Entity.Make entity = MakeParamConverter.Convert(param, null);
            MakeDao.Save(entity);

            return MakeResultConverter.Convert(entity);
        }

        public List<MakeResult> Create(List<MakeParam> param)
        {
            List<Data.Entity.Make> entities = new List<Data.Entity.Make>();
            foreach (var item in param)
            {
                entities.Add(MakeParamConverter.Convert(item, null));
            }
            MakeDao.Save(entities);
            List<MakeResult> result = new List<MakeResult>();
            foreach (var item in entities)
            {
                result.Add(MakeResultConverter.Convert(item));
            }
            return result;
        }

        public void Delete(long id)
        {
            MakeDao.Delete(id);
        }

        public void Delete(List<long> idList)
        {
            List<Data.Entity.Make> entity = new List<Data.Entity.Make>();
            foreach (var id in idList)
            {
                entity.Add(MakeDao.Find(id));
            }
            foreach (var id in idList)
            {
                MakeDao.Delete(id);
            }
        }

        public MakeResult Find(long id)
        {
            Data.Entity.Make entity = MakeDao.Find(id);
            MakeResult result = MakeResultConverter.Convert(entity);
            return result;
        }

        public List<MakeResult> Find()
        {
            List<Data.Entity.Make> entity = MakeDao.Find();
            List<MakeResult> results = new List<MakeResult>();
            foreach (var item in entity)
            {
                results.Add(MakeResultConverter.Convert(item));
            }
            return results;
        }

        public void Update(long id, MakeParam param)
        {
            Data.Entity.Make oldEntity = MakeDao.Find(id);
            Data.Entity.Make newEntity = MakeParamConverter.Convert(param, null);
            MakeDao.Update(newEntity);
        }

        public void Update(List<MakeParam> param)
=======
        public MakeProcessor(IMakeDao dao, IMakeParamConverter paramConverter, IMakeResultConverter resultConverter) : base(dao, paramConverter, resultConverter)
>>>>>>> Stashed changes
        {
            List<Data.Entity.Make> entity = new List<Data.Entity.Make>();
            foreach (var item in param)
            {
                Data.Entity.Make oldEntity = MakeDao.Find(item.Id);
                Data.Entity.Make newEntity = MakeParamConverter.Convert(item, null);
                MakeDao.Update(newEntity);
            }
        }
    }
}
