using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.AutoPart;
using AutoServiceShop.Dataaccess.Dao.AutoPartStatus;

namespace AutoServiceShop.Business.Processor.Converter.AutoPart
{
    class AutoPartParamConverter : BaseParamConverter<AutoPartParam, Data.Entity.AutoPart>, IAutoPartParamConverter
    {
<<<<<<< Updated upstream
        IAutoPartDao AutoPartDao = new AutoPartDao();
        IAutoPartStatusDao AutoPartStatusDao = new AutoPartStatusDao();
=======
        private IAutoPartDao _autoPartDao;
        public IAutoPartDao AutoPartDao
        {
            set { _autoPartDao = value; }

            get
            {
                if (_autoPartDao == null)
                {
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
                    return _autoPartStatusDao;
                }
                else
                {
                    return _autoPartStatusDao;
                }
            }
        }
>>>>>>> Stashed changes

        public override void ConvertSpecific(AutoPartParam param, Data.Entity.AutoPart entity)
        {
<<<<<<< Updated upstream
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

            entity.AutoPartsStatus = AutoPartStatusDao.Find(param.AutoPartStatusId);
            entity.Price = param.Price;
            entity.Quantity = param.Quantity;
=======
            entity.AutoPartStatus = _autoPartStatusDao.Find(param.AutoPartStatusId);
        }

        public override Data.Entity.AutoPart GetResult(AutoPartParam param)
        {
            Data.Entity.AutoPart entity = new Data.Entity.AutoPart
            {
                Code = param.Code,
                Id = param.Id,
            };
>>>>>>> Stashed changes

            return entity;
        }
    }
}
