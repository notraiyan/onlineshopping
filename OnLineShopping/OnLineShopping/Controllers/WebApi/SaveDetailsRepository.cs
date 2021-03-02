using OnLineShopping.Models;
using OnLineShopping.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineShopping.Controllers.WebApi
{
    public class SaveDetailsRepository : ISaveDetails
    {
        public int InsertMasterTranInfo(MasterTranViewModel MTranView)
        {
            int result = 1;
            using (var db = new OnLineShoppingEntities())
            {
                T_Tran_Master_Transaction mtran = db.T_Tran_Master_Transaction.Where(d => d.TransactionId == MTranView.TransactionId).FirstOrDefault();
                if (mtran == null)
                { 
                    mtran = new T_Tran_Master_Transaction();
                    db.T_Tran_Master_Transaction.Add(mtran);
                    result = 2;
                }
                mtran.TransactionId = MTranView.TransactionId;
                mtran.CustomerName = MTranView.CustomerName;
                mtran.VoucherNo = MTranView.VoucherNo;
                mtran.TransactionDate = MTranView.TransactionDate;
                mtran.GrossAmount = MTranView.GrossAmount;
                mtran.UserId = MTranView.UserId;
                db.SaveChanges();
                if(MTranView.ItemDetailList.Count>0)
                {
                   
                    foreach (DetailTransactionViewModel detailtransactionmodel in MTranView.ItemDetailList)
                    {
                        T_Tran_Detail_Transaction t_Tran_Detail_Transaction = db.T_Tran_Detail_Transaction.Where(d => d.Id == detailtransactionmodel.Id).FirstOrDefault();
                        if (t_Tran_Detail_Transaction==null)
                        {
                            t_Tran_Detail_Transaction = new T_Tran_Detail_Transaction();
                            db.T_Tran_Detail_Transaction.Add(t_Tran_Detail_Transaction);
                        }
                      
                       t_Tran_Detail_Transaction.ItemId = detailtransactionmodel.ItemId;
                       t_Tran_Detail_Transaction.UnitId = detailtransactionmodel.UnitId;
                       t_Tran_Detail_Transaction.Quantity = detailtransactionmodel.Quantity;
                       t_Tran_Detail_Transaction.UnitPrice = detailtransactionmodel.UnitPrice;
                       t_Tran_Detail_Transaction.TotalPrice = detailtransactionmodel.TotalPrice;
                       t_Tran_Detail_Transaction.UserId = detailtransactionmodel.UserId;
                       t_Tran_Detail_Transaction.TransactionId = mtran.TransactionId;
                        db.SaveChanges();
                    }
                   // mtran.GrossAmount = MTranView.GrossAmount;
                 
                }
            }
            return result;
        }
    }
}