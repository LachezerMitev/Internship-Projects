using AutoServiceShop.Business.Processor.Converter.Session;
using AutoServiceShop.Data.Entity;
using AutoServiceShop.Dataaccess.Dao.Session;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Session
{
    public class SessionProcessor : IsessionProcessor
    {
        private readonly ISessionDao _dao;

        private readonly ISessionParamConverter _paramConverter;

        private readonly ISessionResultConverter _resultConverter;

        public SessionProcessor (ISessionDao dao, ISessionParamConverter paramConverter, ISessionResultConverter resultConverter)
        {
            _dao = dao;
            _paramConverter = paramConverter;
            _resultConverter = resultConverter;
        }
        public SessionResult CreateSession(HttpContext httpContext, SessionParam param)
        {
            SessionAPI entity = _paramConverter.Convert(param, null);

            entity = _dao.CreateSession(entity);

            return _resultConverter.Convert(entity);

        }

        public SessionResult FindSession(string token)
        {
            SessionAPI entity = _dao.Find(token);
            SessionResult result = _resultConverter.Convert(entity);

            return result;
        }

        public List<SessionResult> GetSessions()
        {
            List<SessionAPI> entities = _dao.GetSessions();

            List<SessionResult> results = new List<SessionResult>();

            foreach (SessionAPI item in entities)
            {
                results.Add(_resultConverter.Convert(item));
            }

            return results;
        }

        public void RemoveSession(HttpContext httpContext, SessionParam param)
        {
            SessionAPI entity = _paramConverter.Convert(param, null);

            _dao.RemoveSession(entity);
        }
    }
}
