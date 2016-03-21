using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Linq;


namespace WpfApplication4.Requests
{
    class MethodsWaiter
    {
        public static void InsertBludoInOrder(Context context, Entities.BludoInOrder bludoIO)
        {
            //foreach (var b in context.Bludos.Where(b => b.BludoID == bludoIO.BludoID))
            //{
            //    var bID = b.BludoID;

            //    foreach (var o in context.OrdersInTime.Where(o => o.OrderID == bludoIO.OrderID))
            //    {
            //        var oID = o.OrderID;

            //        context.BludosInOrder.Add(new Entities.BludoInOrder { BludoID = bID, BludoAmount = bludoIO.BludoAmount, BludoStatus = bludoIO.BludoStatus, OrderID = oID, OrderTime = DateTime.Now });
            //        context.SaveChanges();
            //    }
            //}
            context.BludosInOrder.Add(bludoIO);
            context.SaveChanges();
        }

        public static Entities.OrderInTime InsertOrderInTime(Context context, Entities.OrderInTime orderIT)
        {
            Entities.OrderInTime order = new Entities.OrderInTime { TableID = orderIT.TableID, WaiterID = orderIT.WaiterID };
            context.OrdersInTime.Add(order);
            context.SaveChanges();
            return order;
        }


        public static void UpdateBludoInOrder(Context context, Entities.BludoInOrder bludo)
        {
            var bludoio = (from c in context.BludosInOrder
                       where (c.BludoID == bludo.BludoID)&&(c.OrderID == bludo.OrderID)
                       select c).First();

            bludoio.BludoStatus = bludo.BludoStatus;            
        }

        public static Entities.Waiter GetWaiterByLogin(Context context, string login)
        {
            //Entities.Waiter w = new Entities.Waiter();
            var waiter = (from r in context.Waiters
                         where r.WaiterLogin == login
                         select r).First();
           
            return waiter;
        }
    }
}
