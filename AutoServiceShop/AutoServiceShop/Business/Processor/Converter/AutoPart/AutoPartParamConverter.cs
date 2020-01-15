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
>>>>>>> Stashed changes

        public Data.Entity.AutoPart Convert(AutoPartParam param, Data.Entity.AutoPart oldentity)
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

        public override void ConvertSpecific(AutoPartParam param, Data.Entity.AutoPart entity)
        {
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
