using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WpfApplication4
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OrderService" in both code and config file together.
    public class OrderService : IOrderService
    {
        public List<Entities.Bludo> GetAllBludos()
        {
            List<Entities.Bludo> listBludos = new List<Entities.Bludo>();
            using (TeamProjectEntities6 entities = new TeamProjectEntities6())
            {
                var bludos = from r in entities.Bludo
                             select r;
                foreach (Bludo singleBludo in bludos)
                {
                    Entities.Bludo b = new Entities.Bludo();
                    b.BludoID = singleBludo.id;
                    b.BludoName = singleBludo.name_Bludo;
                    b.BludoPrice = decimal.Parse(singleBludo.price_Bludo.ToString());
                    b.BludoWeight = double.Parse(singleBludo.weight_Bludo.ToString());
                    b.BludoCategory = singleBludo.category_Bludo;                    
                    //b.BludoTime = int.Parse(singleBludo.time_Bludo.ToString());

                    listBludos.Add(b);
                }
            }
            return listBludos; 
        }

        public List<Entities.BludoInOrder> GetAllBludosInOrder()
        {
            List<Entities.BludoInOrder> listBludosIO = new List<Entities.BludoInOrder>();
            using (TeamProjectEntities6 entities = new TeamProjectEntities6())
            {
                var bludosIO = from r in entities.BludoInOrder
                             select r;
                foreach (BludoInOrder singleBludoIO in bludosIO)
                {
                    Entities.BludoInOrder bo = new Entities.BludoInOrder();
                    bo.OrderID = singleBludoIO.id;
                    bo.BludoID = int.Parse(singleBludoIO.id_Bludo.ToString());
                    bo.BludoAmount = int.Parse(singleBludoIO.number_Bludo.ToString());
                    bo.BludoStatus = singleBludoIO.status;
                    bo.OrderTime = DateTime.Parse(singleBludoIO.ordertime.ToString());

                    listBludosIO.Add(bo);
                }
            }
            return listBludosIO; 
        }

        public List<Entities.OrderInTime> GetAllOrdersInTime()
        {
            List<Entities.OrderInTime> listOrdersIT = new List<Entities.OrderInTime>();
            using (TeamProjectEntities6 entities = new TeamProjectEntities6())
            {
                var ordersIT = from r in entities.OrderInTime
                             select r;
                foreach (OrderInTime singleOrderIT in ordersIT)
                {
                    Entities.OrderInTime ot= new Entities.OrderInTime();
                    ot.OrderID = singleOrderIT.id;
                    ot.TableID = int.Parse(singleOrderIT.id_Table.ToString());
                    ot.WaiterID = int.Parse(singleOrderIT.id_Waiter.ToString());                   

                    listOrdersIT.Add(ot);
                }
            }
            return listOrdersIT; 
        }

        public List<Entities.Table> GetAllTables()
        {
            List<Entities.Table> listTables = new List<Entities.Table>();
            using (TeamProjectEntities6 entities = new TeamProjectEntities6())
            {
                var tables = from r in entities.Table                     
                             select r;
                foreach (Table singleTable in tables)
                {
                    Entities.Table t = new Entities.Table();
                    t.TableID = singleTable.id;
                    t.TableLabel = int.Parse(singleTable.label_Table);
                    t.TableLocation = singleTable.location_Table;
                    t.TablePlaces = (int)singleTable.places_Table;

                    listTables.Add(t);
                }
            }
            return listTables;            
        }

        public List<Entities.Waiter> GetAllWaiters()
        {
            List<Entities.Waiter> listWaiters = new List<Entities.Waiter>();
            using (TeamProjectEntities6 entities = new TeamProjectEntities6())
            {
                var waiters = from r in entities.Waiter
                             select r;
                foreach (Waiter singleWaiter in waiters)
                {
                    Entities.Waiter w = new Entities.Waiter();
                    w.WaiterID = singleWaiter.id;
                    w.WaiterName = singleWaiter.name_Waiter;
                    w.WaiterSurname = singleWaiter.surname_Waiter;

                    listWaiters.Add(w);
                }
            }
            return listWaiters; 
        }
    }
}
