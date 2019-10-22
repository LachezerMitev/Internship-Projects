using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.UserGroupStatus;
using AutoServiceShop.Business.Processor.UserGroupStatus;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.UserGroupStatus
{
    class UserGroupStatusService : IUserGroupStatusService
    {
        IUserGroupStatusProcessor UserGroupStatusProcessor { get; set; }

        public ApiResponse Create(UserGroupStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<UserGroupStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public ApiResponse DeleteById(long id)
        {
            throw new NotImplementedException();
        }

        public ApiResponse FindByPK(long id)
        {
            throw new NotImplementedException();
        }

        public ApiResponse ListAll()
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(long id, UserGroupStatusParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<UserGroupStatusParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(UserGroupStatusParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<UserGroupStatusParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
