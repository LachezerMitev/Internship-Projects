using AutoServiceShop.Business.Processor.Converter.Common;
using AutoServiceShop.Data.Entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceShop.Business.Processor.Converter.Session
{
    public class SessionResultConverter : BaseResultConverter<SessionAPI, SessionResult>, ISessionResultConverter
    {
        public override void ConvertSpecific(SessionAPI param, SessionResult result)
        {
            /*
             * A possable solution to the Client authorization
             * ---------------------------------------------------
             * SessionResult
             * {
             *      Claimsprincipal Claims { get; set;}  <= Add this field to the SessionAPI
             * }
             * ---------------------------------------------------
             * result.Claims = httpContext.User as ClaimPrincipal;  <=  Get's the current user's Principal that containes a Dictionary<ClaimType, ClaimValue>
             * ---------------------------------------------------
             * 
             * We can return this to the client where the LogIn Controller can assign them to the root calues of the Token
             * (I.E.    Base64(token:Claims) => AAWDREF4-ASDW4S-ASDW4-AS7DW3-1W468SA7:User, Worker, Manager)
             * 
             * Client side we can have an authorization filter simillar to the API where it checks the page's Role values
             * 
             * Roles will be implemented the same way as in the API i.e. externaly in the appsettings.json file or other
             */
        }
    }
}
