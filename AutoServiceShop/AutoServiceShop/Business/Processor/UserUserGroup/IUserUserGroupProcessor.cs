using AutoServiceShop.Business.Processor.Converter.UserUserGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.UserUserGroup
{
    interface IUserUserGroupProcessor
    {
        UserUserGroupResult Create(UserUserGroupParam param);
        List<UserUserGroupResult> Create(List<UserUserGroupParam> param);

        void Update(long id, UserUserGroupParam param);
        void Update(List<UserUserGroupParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        UserUserGroupResult Find(long id);
        List<UserUserGroupResult> Find();
    }
}
