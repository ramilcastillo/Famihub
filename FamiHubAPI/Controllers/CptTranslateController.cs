using FamiHubAPI.Filters;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace FamiHubAPI.Controllers
{
    [IdentityBasicAuthentication]
    [Authorize]
    public class CptTranslateController : ApiController
    {
        /// <summary>
        /// This method is used to get the translation of a form component in FamiHub
        /// </summary>
        /// <returns>Component translation object</returns>
        [ResponseType(typeof(FamiHub.Models.Core.FormTranslation))]
        public HttpResponseMessage Post(FamiHub.BusinessLayer.General.LocalizationRequests.ComponentTranslationRequest model)
        {
            var result = FamiHub.BusinessLayer.General.Localization.TranslateCpt(model.Form, model.Component, model.Language, model.CurrentLabel);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}