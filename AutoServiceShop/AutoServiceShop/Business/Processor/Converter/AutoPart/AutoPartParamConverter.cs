using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.AutoPart;
using AutoServiceShop.Dataaccess.Dao.AutoPartStatus;

namespace AutoServiceShop.Business.Processor.Converter.AutoPart
{
    class AutoPartParamConverter : IAutoPartParamConverter
    {
        private IAutoPartDao _autoPartDao;
        public IAutoPartDao AutoPartDao
        {
            set { _autoPartDao = value; }

            get
            {
                if (_autoPartDao == null)
                {
                    _autoPartDao = new AutoPartDao();
                    return _autoPartDao;
                }
                else
                {
                    return _autoPartDao;
                }
            }
        }

        private IAutoPartStatusDao _autoPartStatusDao;
        public IAutoPartStatusDao AutoPartStatusDaopublic
        {
            set { _autoPartStatusDao = value; }

            get
            {
                if (_autoPartStatusDao == null)
                {
                    _autoPartStatusDao = new AutoPartStatusDao();
                    return _autoPartStatusDao;
                }
                else
                {
                    return _autoPartStatusDao;
                }
            }
        }

        public Data.Entity.AutoPart Convert(AutoPartParam param, Data.Entity.AutoPart oldentity)
        {
            Data.Entity.AutoPart entity = null;

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.AutoPart
                {
                    Code = param.Code,
                    Id = param.Id,
                    Description = param.Description,
                    Name = param.Name
                };
            }

<<<<<<< Updated upstream
            entity.AutoPartsStatus = AutoPartStatusDao.Find(param.AutoPartStatusId);
            entity.Price = param.Price;
            entity.Quantity = param.Quantity;
=======
            ConverterStandart(param, entity);

            ConvertSpecific(param, entity);

            return entity;
        }

        public override Data.Entity.AutoPart ConvertSpecific(AutoPartParam param, Data.Entity.AutoPart entity)
        {
            entity.AutoPartsStatus = _autoPartStatusDao.Find(param.AutoPartStatusId);
>>>>>>> Stashed changes

            return entity;
        }
    }
}
