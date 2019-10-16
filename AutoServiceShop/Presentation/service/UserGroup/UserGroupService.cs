using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoServiceShop.Business.Processor.Converter.UserGroup;
using AutoServiceShop.Business.Processor.UserGroup;
using AutoServiceShop.Data.Common;

namespace AutoServiceShop.Presentation.service.UserGroup
{
    class UserGroupService : IUserGroupService
    {
        UserGroupProcessor UserGroupProcessor { get; set; }

        public ApiResponse Create(UserGroupParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Create(List<UserGroupParam> param)
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

        public ApiResponse Update(long id, UserGroupParam param)
        {
            throw new NotImplementedException();
        }

        public ApiResponse Update(List<UserGroupParam> param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(UserGroupParam param)
        {
            throw new NotImplementedException();
        }

        public void ValidateParameters(List<UserGroupParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
