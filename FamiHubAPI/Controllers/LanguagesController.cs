using FamiHubAPI.Filters;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace FamiHubAPI.Controllers
{
    [IdentityBasicAuthentication]
    [Authorize]
    public class LanguagesController : ApiController
    {
        /// <summary>
        /// This method is used to get the translation of a form component in FamiHub
        /// </summary>
        /// <returns>Component translation object</returns>
        [ResponseType(typeof(Tuple<string, string>))]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, FamiHub.BusinessLayer.General.Localization.GetLanguages());
        }
    }
}