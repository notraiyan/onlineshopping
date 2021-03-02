using OnLineShopping.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnLineShopping.Controllers.WebApi
{
    public class RegistrationApiController : ApiController
    {
        IRegistration iRegistration;
        RegistrationApiController()
        {
            iRegistration = new RegistrationRepository();
        }
        public IHttpActionResult  InsertORUpdateRegistrationInfo(RegistrationViewModel registrationView)
        {
            return Ok(iRegistration.InsertORUpdateRegistrationInfo(registrationView));
        }
        public IHttpActionResult DeleteUser(int id)
        {
            return Ok(iRegistration.DeleteUser(id));
        }
    }
}
