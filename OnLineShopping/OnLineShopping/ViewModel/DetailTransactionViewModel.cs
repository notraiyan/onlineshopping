using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineShopping.ViewModel
{
    public class DetailTransactionViewModel
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int UnitId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public int UserId { get; set; }
        public int TransactionId { get; set; }
      
    }
}