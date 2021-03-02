using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace OnLineShopping.ViewModel
{
    
    public class ItemViewModel
    {
      
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemModel { get; set; }
    }
}