using AutoServiceShop.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoServiceShop.Dataaccess.Dao.Session
{
    public class SessionDao : ISessionDao
    {
        private readonly AutoServiceShopContext _context;

        public SessionDao(AutoServiceShopContext context)
        {
            _context = context;
        }
        public SessionAPI CreateSession(SessionAPI entity)
        {
            _context.Entry(entity).State = EntityState.Added;

            _context.Set<SessionAPI>().Add(entity);

            _context.SaveChanges();

            return entity;
        }

        public SessionAPI Find(string token)
        {
            List<SessionAPI> entity = _context.Set<SessionAPI>().ToList();

            return entity.Where
                (x => x.GetType().GetProperty("Token").GetValue(x, null).ToString()
                .Equals(token, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
        }

        public List<SessionAPI> GetSessions()
        {
            return _context.Set<SessionAPI>().ToList();
        }

        public void RemoveSession(SessionAPI entity)
        {
            entity = Find(entity.Token);

            _context.Set<SessionAPI>().Remove(entity);
            _context.SaveChanges();
        }
    }
}
