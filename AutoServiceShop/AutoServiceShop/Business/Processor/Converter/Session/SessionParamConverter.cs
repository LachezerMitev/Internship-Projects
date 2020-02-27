using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Session;
using AutoServiceShop.Dataaccess.Dao.User;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Session
{

    public class SessionParamConverter : BaseParamConverter<SessionParam, SessionAPI>, ISessionParamConverter
    {
        private readonly IUserDao _userDao;
        private readonly ISessionDao _sessionDao;

        public SessionParamConverter(IUserDao userDao, ISessionDao sessionDao)
        {
            _userDao = userDao;
            _sessionDao = sessionDao;
        }

        public override void ConvertSpecific(SessionParam param, SessionAPI entity)
        {
        }

        public override SessionAPI GetResult(SessionParam param)
        {
            SessionAPI entity = new SessionAPI
            {
                Code = param.Code,
                Id = param.Id,
            };

            return entity;
        }
    }
}
