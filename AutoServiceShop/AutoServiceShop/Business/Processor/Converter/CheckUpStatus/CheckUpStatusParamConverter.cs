using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.CheckUpStatus;

namespace AutoServiceShop.Business.Processor.Converter.CheckUpStatus
{
    class CheckUpStatusParamConverter : BaseParamConverter<CheckUpStatusParam, Data.Entity.CheckUpStatus>, ICheckUpStatusParamConverter
    {
        ICheckUpStatusDao CheckUpStatusDao = new CheckUpStatusDao();

        public override void ConvertSpecific(CheckUpStatusParam param, Data.Entity.CheckUpStatus entity) { }

        public override Data.Entity.CheckUpStatus GetResult(CheckUpStatusParam param)
        {
<<<<<<< Updated upstream
            Data.Entity.CheckUpStatus entity = null;
=======
            Data.Entity.CheckUpStatus entity = new Data.Entity.CheckUpStatus
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
