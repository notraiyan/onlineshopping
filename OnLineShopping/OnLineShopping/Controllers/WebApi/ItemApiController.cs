using OnLineShopping.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnLineShopping.Controllers.WebApi
{
    public class ItemApiController : ApiController
    {
        IItem IItem;
        ItemApiController()
        {
            IItem = new ItemRepository();
        }
        public IHttpActionResult InsertORUpdateItemInfo(ItemViewModel ItemView)
        {
            return Ok(IItem.InsertORUpdateItemInfo(ItemView));
        }
        public IHttpActionResult DeleteItem(int id)
        {
            return Ok(IItem.DeleteItem(id));
        }
      
    }
}
