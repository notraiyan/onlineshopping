using OnLineShopping.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnLineShopping.Controllers.WebApi
{
    public class LoginApiController : ApiController
    {
        ILogin iLogin;
        LoginApiController()
        {
            iLogin = new LoginRepository();
        }
        public IHttpActionResult LoginInfo(LoginViewModel LoginView)
        {
            return Ok(iLogin.LoginInfo(LoginView));
        }
    }
}
