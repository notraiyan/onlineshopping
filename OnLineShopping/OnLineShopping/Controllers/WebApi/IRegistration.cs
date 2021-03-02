using OnLineShopping.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineShopping.Controllers.WebApi
{
    interface IRegistration
    {
        int InsertORUpdateRegistrationInfo(RegistrationViewModel registrationView);
        int DeleteUser(int id);
    }
}
