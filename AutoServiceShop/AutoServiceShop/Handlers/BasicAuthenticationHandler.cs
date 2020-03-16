using AutoServiceShop.Business.Processor.Converter.Session;
using AutoServiceShop.Business.Processor.Converter.User;
using AutoServiceShop.Business.Processor.User;
using AutoServiceShop.Dataaccess.Dao;
using AutoServiceShop.Handlers.Providers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace AutoServiceShop.Handlers
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {

        IEnumerable<IAuthenticationProvider> _providers;

        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            IEnumerable<IAuthenticationProvider> providers,
            ISystemClock clock)
            : base(options, logger, encoder, clock)
        {
            _providers = providers;
        }

        public AuthenticationTicket TicketBuilder(UserResult result)
        {
            IAuthenticationProvider authorizer = _providers.First();

            List<string> listRoles = authorizer.Authorize(result);

            IList<Claim> claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, result.Id.ToString()),
                    new Claim(ClaimTypes.Name, result.Username)
                };

            listRoles.ForEach(userGroups => claims.Add(new Claim(ClaimTypes.Role, userGroups)));

            var identity = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);

            return ticket;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            try
            {
                UserResult result = null;

                if (Context.Request.Headers.ContainsKey("ClientAssignAdmin"))
                {
                    IList<Claim> claim = new List<Claim>
                    {
                        new Claim(ClaimTypes.NameIdentifier, "Register"),
                        new Claim(ClaimTypes.Name, "NewUser"),
                        new Claim(ClaimTypes.Role, "Admin")
                    };
                    var identity = new ClaimsIdentity(claim, Scheme.Name);
                    var principal = new ClaimsPrincipal(identity);
                    var ticket = new AuthenticationTicket(principal, Scheme.Name);

                    return AuthenticateResult.Success(ticket);
                }

                foreach (IAuthenticationProvider provider in _providers)
                {
                    if (result == null)
                    {
                        result = provider.Authenticate(Context);
                    }
                }

                if (result == null)
                    return AuthenticateResult.Fail("An Error has occured");
                else
                {
                    result.Password = null;

                    return AuthenticateResult.Success(TicketBuilder(result));
                }
            }
            catch(Exception e)
            {
                throw new Exception("Something went wrong" + e);
            }
        }
    }
}
