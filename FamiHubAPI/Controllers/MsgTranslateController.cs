using FamiHubAPI.Filters;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace FamiHubAPI.Controllers
{
    [IdentityBasicAuthentication]
    [Authorize]
    public class MsgTranslateController : ApiController
    {
        /// <summary>
        /// This method is used to get the translation of a message in FamiHub
        /// </summary>
        /// <returns>Message translation object</returns>
        [ResponseType(typeof(FamiHub.Models.Core.MessageTranslation))]
        public HttpResponseMessage Post(FamiHub.BusinessLayer.General.LocalizationRequests.MessageTranslationRequest model)
        {
            var result = FamiHub.BusinessLayer.General.Localization.Translate(model.Message, model.Language, model.Group);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}