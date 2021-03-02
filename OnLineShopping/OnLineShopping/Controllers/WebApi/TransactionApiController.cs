using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnLineShopping.Controllers.WebApi
{
    public class TransactionApiController : ApiController
    {
        ITransaction iTransaction;
        TransactionApiController()
        {
            iTransaction = new TransactionRepository();
        }
       public IHttpActionResult GetAllItem()
        {
            return Ok(iTransaction.GetAllItem());
        }
        public IHttpActionResult GetAllUnit()
        {
            return Ok(iTransaction.GetAllUnit());
        }
        public IHttpActionResult GetAllUser()
        {
            return Ok(iTransaction.GetAllUser());
        }
    }
}
