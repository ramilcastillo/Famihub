using System.Collections.Generic;
using System.Net;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace FamiHubAPI.Filters
{
    public class IdentityBasicAuthenticationAttribute : BasicAuthenticationAttribute
    {
        protected override async Task<IPrincipal> AuthenticateAsync(string userName, string password, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            bool isValid = FamiHub.BusinessLayer.General.Security.ApiAccess(userName, password);
            if (isValid)
            {
                var identity = new GenericIdentity(userName);
                var principal = new GenericPrincipal(identity, null);
                Thread.CurrentPrincipal = principal;
                if (HttpContext.Current != null)
                {
                    HttpContext.Current.User = principal;
                }

                return new ClaimsPrincipal(identity);
            }
            return null;

        }


    }
}