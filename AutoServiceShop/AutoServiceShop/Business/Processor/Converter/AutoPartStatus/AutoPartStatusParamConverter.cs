using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.AutoPartStatus;

namespace AutoServiceShop.Business.Processor.Converter.AutoPartStatus
{
    class AutoPartStatusParamConverter : BaseParamConverter<AutoPartStatusParam, Data.Entity.AutoPartStatus>, IAutoPartStatusParamConverter
    {
<<<<<<< Updated upstream
        IAutoPartStatusDao AutoPartStatusDao = new AutoPartStatusDao();

        public Data.Entity.AutoPartStatus Convert(AutoPartStatusParam param, Data.Entity.AutoPartStatus oldentity)
        {
            Data.Entity.AutoPartStatus entity = null;

            if (oldentity != null)
            {
                entity = oldentity;
            }
            else
            {
                entity = new Data.Entity.AutoPartStatus
                {
                    Code = param.Code,
                    Id = param.Id,
                    Description = param.Description,
                    Name = param.Name
                };
            }
=======

        public override void ConvertSpecific(AutoPartStatusParam param, Data.Entity.AutoPartStatus entity) { }

        public override Data.Entity.AutoPartStatus GetResult(AutoPartStatusParam param)
        {
            Data.Entity.AutoPartStatus entity = new Data.Entity.AutoPartStatus
            {
                Code = param.Code,
                Id = param.Id,
                Active = param.Active
            };
>>>>>>> Stashed changes

            return entity;
        }
    }
}
