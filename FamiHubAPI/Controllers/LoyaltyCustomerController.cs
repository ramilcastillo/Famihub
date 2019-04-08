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
    public class LoyaltyCustomerController : ApiController
    {
        /// <summary>
        /// This function is for getting the customer object 
        /// using the customer Guid (id).
        /// </summary>
        /// <param name="id">621941c5-870c-4927-8c32-451f0cbb89db</param>
        /// <returns>customer object is returned </returns>
        // GET api/LoyaltyCustomer/45789802015

        [ResponseType(typeof(FamiHub.Models.Customers.Customer))]
        public HttpResponseMessage Get(Guid id)
        {
            FamiHub.Models.Customers.Customer customer = FamiHub.Crud.GetById<FamiHub.Models.Customers.Customer, Guid>(id);
            if (customer != null)
                return Request.CreateResponse(HttpStatusCode.OK, customer);
            else
                return Request.CreateResponse(HttpStatusCode.NotFound);
        }
        /// <summary>
        /// This API is used for Create/Update customer.
        /// If you send Customer object with ID=null and it will create new customer
        /// and if you send customer object with Id having guid value then it will update the 
        /// existing customer.
        /// </summary>
        /// <param name="model">Customer object</param>
        /// <returns>customer object as JSON format</returns>
        [ResponseType(typeof(FamiHub.Models.Customers.Customer))]
        public HttpResponseMessage Post(FamiHub.Models.Customers.Customer model)
        {
            try
            {
                FamiHub.Models.Customers.Customer customer = FamiHub.BusinessLayer.Customers.Crud.Put(model);
                return Request.CreateResponse(HttpStatusCode.OK, customer);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
    }
}