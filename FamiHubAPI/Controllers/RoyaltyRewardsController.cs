using FamiHubAPI.Filters;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace FamiHubAPI.Controllers
{
    [IdentityBasicAuthentication]
    [Authorize]
    public class RoyaltyRewardsController : ApiController
    {
        /// <summary>
        /// This function is for getting the loyalty rewards for current day
        /// </summary>
        /// <returns> loyalty rewards list is returned </returns>
        // GET api/LoyaltyRewards/45789802015

        [ResponseType(typeof(FamiHub.Models.Customers.LoyaltyRewards))]
        public HttpResponseMessage Get()
        {
            IList<FamiHub.Models.Customers.LoyaltyRewards> allRewards = FamiHub.Crud.GetAll<FamiHub.Models.Customers.LoyaltyRewards>();

            List<FamiHub.Models.Customers.LoyaltyRewards> todaysRewardsList = null;
            todaysRewardsList = new List<FamiHub.Models.Customers.LoyaltyRewards>();

            foreach (FamiHub.Models.Customers.LoyaltyRewards reward in allRewards)
            {
                if ((reward.ValidFromDate.Date >= DateTime.Now.Date) && (reward.ValidToDate.Date <= DateTime.Now.Date))
                {
                    todaysRewardsList.Add(reward);
                }
            }

            if (todaysRewardsList != null && todaysRewardsList.Count != 0)
                return Request.CreateResponse(HttpStatusCode.OK, todaysRewardsList);
            else
                return Request.CreateResponse(HttpStatusCode.NotFound);
        }
    }
}