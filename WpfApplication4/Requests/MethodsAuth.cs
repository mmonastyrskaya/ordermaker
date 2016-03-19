using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication4.Requests
{
    class MethodsAuth
    {
        public static bool Check(Context context, string login, string password)
        {
            bool check = false;
            Entities.Waiter waiter;

            try 
            { 
                waiter = context.Waiters.First(w => w.WaiterLogin == login);
                if (waiter.WaiterPassword == password)
                {
                    check = true;
                }
                
            }
            catch (ArgumentNullException e)
            {
                //string error = "Проверьте правильность введенного логина.";
            }

            return check;
 
            
            //foreach (var w in context.Waiters.Where(w => w.Waiter == supplier))
            //{
            //    var sID = s.SupplierID;
            //    foreach (var o in context.Offers.Where(o => o.SupplierID == sID))
            //    {
            //        o.Price *= percent;
            //    }
            //}
        }
    }
}
