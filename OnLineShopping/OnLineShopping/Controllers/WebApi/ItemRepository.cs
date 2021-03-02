using OnLineShopping.Models;
using OnLineShopping.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineShopping.Controllers.WebApi
{
    public class ItemRepository : IItem
    {
        

        public int InsertORUpdateItemInfo(ItemViewModel ItemView)
        {
            int result = 1;
            using (var db = new OnLineShoppingEntities())
            {
                T_Sys_Item_Info oldItem = db.T_Sys_Item_Info.Where(d => d.ItemId==ItemView.ItemId).FirstOrDefault();
                if (oldItem == null)
                {
                    oldItem = new T_Sys_Item_Info();
                    db.T_Sys_Item_Info.Add(oldItem);
                    result = 2;
                }
                oldItem.ItemId = ItemView.ItemId;
                oldItem.ItemName = ItemView.ItemName;
                oldItem.ItemModel = ItemView.ItemModel;
                db.SaveChanges();

            }
            return result;
        }
     
        public int DeleteItem(int id)
        {
            int result = 0;
            using (var db = new OnLineShoppingEntities())
            {
                T_Sys_Item_Info oldItem = db.T_Sys_Item_Info.Where(d => d.ItemId == id).FirstOrDefault();
                if(oldItem !=null)
                {
                    db.T_Sys_Item_Info.Remove(oldItem);
                    db.SaveChanges();
                    result = 1;
                }
            }
            return result;
        }
    }
}