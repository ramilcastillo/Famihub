using FamiHubAPI.DAL;
using FamiHubAPI.Filters;
using FamiHubAPI.ViewModels;
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
    public class LoyaltyCardTransactionController : ApiController
    {
        // GET api/<controller>/5
        /// <summary>
        /// This method is used to get all transactions
        /// for that particular card
        /// </summary>
        /// <param name="id">45789802015</param>
        /// <returns>list of transactions</returns>
        /// / GET api/LoyaltyCardBalance/45789802015
        [ResponseType(typeof(IEnumerable<FamiHub.Models.Customers.LoyaltyTransaction>))]
        public HttpResponseMessage Get(string id)
        {
            FamiHub.Models.Customers.Customer customer = FamiHub.BusinessLayer.Loyalty.Card.GetCustomerByCardNumber(id);
            IEnumerable<FamiHub.Models.Customers.LoyaltyTransaction> _transList = FamiHub.BusinessLayer.Loyalty.Transactions.GetAllTransactions(customer);

            if (_transList != null && _transList.Count() > 0)
                return Request.CreateResponse(HttpStatusCode.OK, _transList);
            else
                return Request.CreateResponse(HttpStatusCode.NotFound);

        }

        /// <summary>
        /// This API is used for Top up balance.
        /// </summary>
        /// <param name="PartnerId">992dea3e-ac06-4f82-a205-a92600b00313</param>
        /// <param name="Points">899</param>
        /// <param name="Comments">testingapi</param>
        /// <returns>updated balance as JSON format</returns>
        // POST api/values
        [ResponseType(typeof(ViewModels.LoyaltyCardBalance))]
        public HttpResponseMessage Post(string id, LoyaltyCardTransaction model)
        {
            try
            {
                if (model != null)
                {
                    FamiHub.Models.Customers.Customer customer = FamiHub.BusinessLayer.Loyalty.Card.GetCustomerByCardNumber(id);
                    FamiHub.Models.Customers.LoyaltyPartner partner = FamiHub.BusinessLayer.Loyalty.Card.GetLoyaltyPartnerById(model.PartnerId);
                    if (customer != null && partner != null)
                    {
                        FamiHub.BusinessLayer.Loyalty.Transactions.AddPoints(customer, partner, model.Points, model.Comments);
                        var _result = new ViewModels.LoyaltyCardBalance
                        {
                            CardNumber = id,
                            Balance = Generic.CheckBalance(customer)
                        };
                        return Request.CreateResponse(HttpStatusCode.OK, _result);
                    }
                    else { return Request.CreateResponse(HttpStatusCode.NotFound); }
                }
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }

    }
}