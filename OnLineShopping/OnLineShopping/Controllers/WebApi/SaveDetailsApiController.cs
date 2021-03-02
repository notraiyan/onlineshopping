using OnLineShopping.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnLineShopping.Controllers.WebApi
{
    public class SaveDetailsApiController : ApiController
    {
        ISaveDetails isaveDetails;
        SaveDetailsApiController()
        {
            isaveDetails = new SaveDetailsRepository();
        }
       
        public IHttpActionResult InsertMasterTranInfo(MasterTranViewModel MTranView)
        {
            return Ok(isaveDetails.InsertMasterTranInfo(MTranView));
        }
    }
}
