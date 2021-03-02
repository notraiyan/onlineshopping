using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineShopping.ViewModel
{
    public class MasterTranViewModel
    {
        public int TransactionId { get; set; }
        public string CustomerName { get; set; }
        public string VoucherNo { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal GrossAmount { get; set; }
        public int UserId { get; set; }
        public List<DetailTransactionViewModel> ItemDetailList { set; get; }

    }
}