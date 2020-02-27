using AutoServiceShop.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Session
{
    public interface ISessionDao
    {
        SessionAPI CreateSession(SessionAPI entity);

        public SessionAPI Find(string token);

        void RemoveSession(SessionAPI entity);

        List<SessionAPI> GetSessions();
    }
}
