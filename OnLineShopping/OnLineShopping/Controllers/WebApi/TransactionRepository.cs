using OnLineShopping.Models;
using OnLineShopping.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineShopping.Controllers.WebApi
{
    public class TransactionRepository:ITransaction
    {
       public List<ItemViewModel> GetAllItem()
        {
            List<ItemViewModel> allItem = new List<ItemViewModel>();
            using (var db = new OnLineShoppingEntities())
            {
                allItem = db.T_Sys_Item_Info.Select(s => new ItemViewModel
                {
                    ItemId=s.ItemId,
                    ItemModel=s.ItemModel,
                    ItemName=s.ItemName
                }).ToList();
                  
            }
                return allItem;
        }
        public List<UnitViewModel> GetAllUnit()
        {
            List<UnitViewModel> allUnit = new List<UnitViewModel>();
            using (var db = new OnLineShoppingEntities())
            {
                allUnit = db.T_Sys_Unit_Info.Select(a => new UnitViewModel
                {
                    UnitId = a.UnitId,
                    UnitName = a.UnitName
                }).ToList();

            }
            return allUnit;
        }
        public List<RegistrationViewModel> GetAllUser()
        {
            List<RegistrationViewModel> allUser = new List<RegistrationViewModel>();
            using (var db = new OnLineShoppingEntities())
            {
                allUser = db.T_Sys_Registration_Info.Select(b => new RegistrationViewModel
                {
                    UserId = b.UserId,
                    UserName = b.UserName,
                    Password = b.Password,
                    UserCreationDate = b.UserCreationDate
                }).ToList();

            }
            return allUser;
        }
    }
}