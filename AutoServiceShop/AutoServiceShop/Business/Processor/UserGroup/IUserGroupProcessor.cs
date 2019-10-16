using AutoServiceShop.Business.Processor.Converter.UserGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.UserGroup
{
    interface IUserGroupProcessor
    {
        UserGroupResult Create(UserGroupParam param);
        List<UserGroupResult> Create(List<UserGroupParam> param);

        void Update(long id, UserGroupParam param);
        void Update(List<UserGroupParam> param);

        void Delete(long id);
        void Delete(List<long> idList);

        UserGroupResult Find(long id);
        List<UserGroupResult> Find();
    }
}
