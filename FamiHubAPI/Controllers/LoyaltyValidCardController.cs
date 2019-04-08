using FamiHubAPI.DAL;
using FamiHubAPI.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Results;


namespace FamiHubAPI.Controllers
{
    [IdentityBasicAuthentication]
    [Authorize]
    public class LoyaltyValidCardController : ApiController
    {


        /// <summary>
        /// This API is used for for Check the Card is valid or not
        /// pi/card/45789802015
        /// </summary>
        /// <param name="id">45789802015</param>
        /// <returns>true/false as JSON format</returns>

        // GET api/LoyaltyValidCard/45789802015
        [ResponseType(typeof(ViewModels.LoyaltyValidCard))]
        public HttpResponseMessage Get(string id)
        {
            try
            {
                ViewModels.LoyaltyValidCard _result = new ViewModels.LoyaltyValidCard
                {
                    Valid = FamiHub.BusinessLayer.Loyalty.Card.IsValidCardNumber(id),
                    CardNumber = id
                };
                return Request.CreateResponse(HttpStatusCode.OK, _result);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

    }
}
