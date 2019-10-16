using AutoServiceShop.Business.Processor.Converter.UserGroupStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.UserGroupStatus
{
    interface IUserGroupStatusProcessor
    {
        UserGroupStatusResult Create(UserGroupStatusParam param);
        List<UserGroupStatusResult> Create(List<UserGroupStatusParam> param);

        void Update(long id, UserGroupStatusParam param);
        void Update(List<UserGroupStatusParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        UserGroupStatusResult Find(long id);
        List<UserGroupStatusResult> Find();
    }
}
