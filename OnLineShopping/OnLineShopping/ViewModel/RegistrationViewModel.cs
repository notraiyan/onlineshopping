using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineShopping.ViewModel
{
    public class RegistrationViewModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> UserCreationDate { get; set; }
    }
}