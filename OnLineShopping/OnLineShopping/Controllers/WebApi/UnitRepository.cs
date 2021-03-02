using OnLineShopping.Models;
using OnLineShopping.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnLineShopping.Controllers.WebApi
{
    public class UnitRepository : IUnit
    {
        public int InsertORUpdateUnitInfo(UnitViewModel UnitView)
        {
            int result = 1;
            using (var db = new OnLineShoppingEntities())
            {
                T_Sys_Unit_Info oldregistration = db.T_Sys_Unit_Info.Where(d => d.UnitId == UnitView.UnitId).FirstOrDefault();
                if (oldregistration == null)
                {
                    oldregistration = new T_Sys_Unit_Info();
                    db.T_Sys_Unit_Info.Add(oldregistration);

                    result = 2;
                }
                //oldregistration.UnitId = UnitView.UnitId;
                oldregistration.UnitName = UnitView.UnitName;
                
                db.SaveChanges();
            }
            return result;
        }
        public int DeleteItem(int id)
        {
            int result = 0;
            using (var db = new OnLineShoppingEntities())
            {
                T_Sys_Unit_Info oldUnit = db.T_Sys_Unit_Info.Where(d => d.UnitId == id).FirstOrDefault();
                if (oldUnit != null)
                {
                    db.T_Sys_Unit_Info.Remove(oldUnit);
                    db.SaveChanges();
                    result = 1;
                }
            }
            return result;
        }
    }
}