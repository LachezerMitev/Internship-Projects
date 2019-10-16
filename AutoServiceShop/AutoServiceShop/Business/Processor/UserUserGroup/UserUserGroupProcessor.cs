using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoServiceShop.Dataaccess.Dao.UserUserGroup;
using AutoServiceShop.Business.Processor.Converter.UserUserGroup;

namespace AutoServiceShop.Business.Processor.UserUserGroup
{
    class UserUserGroupProcessor : IUserUserGroupProcessor
    {
        UserUserGroupDao UserUserGroupDao { get; set; }

        UserUserGroupParamConverter UserUserGroupParamConverter { get; set; }
        UserUserGroupResultConverter UserUserGroupResultConverter { get; set; }

        public UserUserGroupResult Create(UserUserGroupParam param)
        {
            throw new NotImplementedException();
        }

        public List<UserUserGroupResult> Create(List<UserUserGroupParam> param)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public void Delete(List<long> idList)
        {
            throw new NotImplementedException();
        }

        public UserUserGroupResult Find(long id)
        {
            throw new NotImplementedException();
        }

        public List<UserUserGroupResult> Find()
        {
            throw new NotImplementedException();
        }

        public void Update(long id, UserUserGroupParam param)
        {
            throw new NotImplementedException();
        }

        public void Update(List<UserUserGroupParam> param)
        {
            throw new NotImplementedException();
        }
    }
}
