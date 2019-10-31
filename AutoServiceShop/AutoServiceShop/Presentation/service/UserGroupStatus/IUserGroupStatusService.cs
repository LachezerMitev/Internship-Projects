using AutoServiceShop.Data.Common;
using AutoServiceShop.Business.Processor.Converter.UserGroupStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Presentation.service.UserGroupStatus
{
    interface IUserGroupStatusService
    {
        ApiResponse FindByPK(long id);
        ApiResponse ListAll();

        ApiResponse Create(UserGroupStatusParam param);
        ApiResponse Create(List<UserGroupStatusParam> param);

        ApiResponse Update(long id, UserGroupStatusParam param);
        ApiResponse Update(List<UserGroupStatusParam> param);

        ApiResponse DeleteById(long id);
        ApiResponse Delete(List<long> idList);

        void ValidateParameters(UserGroupStatusParam param);
        void ValidateParameters(List<UserGroupStatusParam> param);
    }
}
