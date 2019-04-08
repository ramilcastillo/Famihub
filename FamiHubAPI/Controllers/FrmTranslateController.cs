using FamiHubAPI.Filters;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace FamiHubAPI.Controllers
{
    [IdentityBasicAuthentication]
    [Authorize]
    public class FrmTranslateController : ApiController
    {
        /// <summary>
        /// This method is used to get the translation of a form in FamiHub
        /// </summary>
        /// <returns>List of component translation object</returns>
        [ResponseType(typeof(IList<FamiHub.Models.Core.FormTranslation>))]
        public HttpResponseMessage Post(FamiHub.BusinessLayer.General.LocalizationRequests.FormTranslationRequest model)
        {
            var result = FamiHub.BusinessLayer.General.Localization.GetFormTranslationsByForm(model.Form, model.Language);
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}