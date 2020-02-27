using AutoServiceShop.AuthorizationAttributes.Controllers;
using AutoServiceShop.Business.Processor.Converter.Model;
using AutoServiceShop.Business.Processor.Model;
using AutoServiceShop.Controllers.CommonController;
using AutoServiceShop.Dataaccess.Dao.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Controllers.ModelController
{
    [ApiController]
    [Route("api/[controller]")]
    [AuthorizationModel]
    public class ModelController
        : BaseController<IModelProcessor, IModelParamConverter, IModelResultConverter, ModelParam, ModelResult, IModelDao, long, Data.Entity.Model>, IModelController
    {
        public ModelController(IModelProcessor processor) : base(processor)
        {
        }
    }
}
