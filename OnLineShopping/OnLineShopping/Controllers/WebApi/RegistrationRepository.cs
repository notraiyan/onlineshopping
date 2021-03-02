using OnLineShopping.Models;
using OnLineShopping.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineShopping.Controllers.WebApi
{
    public class RegistrationRepository: IRegistration
    {
        public int InsertORUpdateRegistrationInfo(RegistrationViewModel registrationView)
        {
            int result = 1;
            using (var db = new OnLineShoppingEntities())
            {
                T_Sys_Registration_Info oldregistration = db.T_Sys_Registration_Info.Where(d => d.UserId == registrationView.UserId).FirstOrDefault();
                if(oldregistration==null)
                {
                    oldregistration = new T_Sys_Registration_Info();
                    db.T_Sys_Registration_Info.Add(oldregistration);
                
                    result = 2;
                }
                
                oldregistration.UserName = registrationView.UserName;
                oldregistration.UserCreationDate = registrationView.UserCreationDate;
                oldregistration.Password = registrationView.Password;
                db.SaveChanges();
            }
                return result;
        }
        public int DeleteUser(int id)
        {
            int result = 0;
            using (var db = new OnLineShoppingEntities())
            {
                T_Sys_Registration_Info oldUser = db.T_Sys_Registration_Info.Where(d => d.UserId == id).FirstOrDefault();
                if (oldUser != null)
                {
                    db.T_Sys_Registration_Info.Remove(oldUser);
                    db.SaveChanges();
                    result = 1;
                }
            }
            return result;
        }
    }
}