﻿using System;
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
        IAutoPartDao AutoPartDao = new AutoPartDao();
        IAutoPartStatusDao AutoPartStatusDao = new AutoPartStatusDao();

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

            entity.AutoPartsStatus = AutoPartStatusDao.Find(param.AutoPartStatusId);
            entity.Price = param.Price;
            entity.Quantity = param.Quantity;

            return entity;
        }
    }
}
