using OnLineShopping.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnLineShopping.Controllers.WebApi
{
    public class UnitApiController : ApiController
    {
        IUnit IUnit;
        UnitApiController()
        {
            IUnit = new UnitRepository();
        }
        public IHttpActionResult InsertORUpdateUnitInfo(UnitViewModel UnitView)
        {
            return Ok(IUnit.InsertORUpdateUnitInfo(UnitView));
        }
        public IHttpActionResult DeleteItem(int id)
        {
            return Ok(IUnit.DeleteItem(id));
        }
       
    }
}
