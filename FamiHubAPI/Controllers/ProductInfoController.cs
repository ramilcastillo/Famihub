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
    public class ProductInfoController : ApiController
    {
        /// <summary>
        /// This API is used to get product information by barcode
        /// </summary>
        /// <param name="id">1234567890123</param>
        /// <returns>Product info</returns>
        [ResponseType(typeof(FamiHub.BusinessLayer.Warehouse.Products.ProductInfo))]
        public HttpResponseMessage Get(string id)
        {
            try
            {
                var _result = FamiHub.BusinessLayer.Warehouse.Products.GetProductInfo(id);
                if (_result != null)
                    return Request.CreateResponse(HttpStatusCode.OK, _result);
                else
                    return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
            }
        }
    }
}