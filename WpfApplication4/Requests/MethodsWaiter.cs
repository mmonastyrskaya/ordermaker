using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication4.Requests
{
    class MethodsWaiter
    {
        public static void InsertBludoInOrder(Context context, Entities.BludoInOrder bludoIO)
        {
            foreach (var b in context.Bludos.Where(b => b.BludoID == bludoIO.BludoID))
            {
                var bID = b.BludoID;

                foreach (var o in context.OrdersInTime.Where(o => o.OrderID == bludoIO.OrderID))
                {
                    var oID = o.OrderID;

                    context.BludosInOrder.Add(new Entities.BludoInOrder { BludoID = bID, BludoAmount = bludoIO.BludoAmount, BludoStatus = bludoIO.BludoStatus, OrderID = oID, OrderTime = DateTime.Now }
                );
                }
            }
        }
    }
}
