using OnLineShopping.Models;
using OnLineShopping.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineShopping.Controllers.WebApi
{
    public class LoginRepository : ILogin
    { 
        public int LoginInfo(LoginViewModel LoginView)
        {
            int result = 1;
            using (var db = new OnLineShoppingEntities())
            {
                T_Sys_Registration_Info isExist = db.T_Sys_Registration_Info.Where(d => d.UserName == LoginView.UserName && d.Password==LoginView.Password).FirstOrDefault();
                if (isExist != null)
                {
                    result = 2;
                }
            }
            return result;
        }
    }
}