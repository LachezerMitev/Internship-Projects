using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.UserGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Presentation.service.UserGroup
{
    interface IUserGroupService
    {
        ApiResponse FindByPK(long id);
        ApiResponse ListAll();

        ApiResponse Create(UserGroupParam param);
        ApiResponse Create(List<UserGroupParam> param);

        ApiResponse Update(long id, UserGroupParam param);
        ApiResponse Update(List<UserGroupParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(UserGroupParam param);
        void ValidateParameters(List<UserGroupParam> param);
    }
}
