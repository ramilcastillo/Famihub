using FamiHubAPI.DAL;
using FamiHubAPI.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace FamiHubAPI.Controllers
{
    [IdentityBasicAuthentication]
    [Authorize]
    public class LoyaltyCardBalanceController : ApiController
    {
        /// <summary>
        /// This API is used for get balance from database using Card number
        /// api/LoyaltyCardBalance/45789802015
        /// </summary>
        /// <param name="id"></param>
        /// <returns>customer object as JSON format</returns>
        // GET api/LoyaltyCardBalance/45789802015
        [ResponseType(typeof(ViewModels.LoyaltyCardBalance))]
        public HttpResponseMessage Get(string id)
        {
            try
            {
                FamiHub.Models.Customers.Customer customer = FamiHub.BusinessLayer.Loyalty.Card.GetCustomerByCardNumber(id);
                if (customer != null)
                {
                    var _result = new ViewModels.LoyaltyCardBalance
                    {
                        CardNumber = id,
                        Balance = Generic.CheckBalance(customer)
                    };
                    return Request.CreateResponse(HttpStatusCode.OK, _result);

                }
                else { return Request.CreateResponse(HttpStatusCode.NotFound); }

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

    }
}