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
        public List<Bludo> GetAllBludos()
        {
            return null;
        }

        public List<BludoInOrder> GetAllBludosInOrder()
        {
            return null;
        }

        public List<OrderInTime> GetAllOrdersInTime()
        {
            return null;
        }

        public List<Table> GetAllTables()
        {
            //List<Entities.Table> listTables = new List<Entities.Table>();
            //using (TeamProjectEntities entities = new TeamProjectEntities())
            //{
            //    var tables = from r in entities.                         
            //                 select r;
            //    foreach (referat1DataSet.dbo_TableRow singleTable in tables)
            //    {
            //        Entities.Table t = new Entities.Table();
            //        t.TableID = singleTable.id_Table;
            //        //t.label_Table = singleTable.label_Table;
            //        //t.location_Table = singleTable.location_Table;
            //        //t.places_Table = singleTable.places_Table;

            //        listTables.Add(t);
            //    }
            //}
            //return listTables;
            return null;
        }

        public List<Waiter> GetAllWaiters()
        {
            return null;
        }
    }
}
