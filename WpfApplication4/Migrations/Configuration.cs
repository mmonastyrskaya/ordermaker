namespace WpfApplication4.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WpfApplication4.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WpfApplication4.Context context)
        {
            OrderService s = new OrderService();

            List<Entities.Bludo> bludos = s.GetAllBludos();
            List<Entities.BludoInOrder> bludosio = s.GetAllBludosInOrder();
            List<Entities.OrderInTime> orders = s.GetAllOrdersInTime();
            List<Entities.Table> tables = s.GetAllTables();
            List<Entities.Waiter> waiters = s.GetAllWaiters();

            foreach (Entities.Table table in tables)
            {
                context.Tables.AddOrUpdate(
                    t => t.TableID,
                    new Entities.Table { TableID = table.TableID, TableLabel = table.TableLabel, TableLocation = table.TableLocation, TablePlaces = table.TablePlaces }
                    );
            }

            //foreach (Entities.OrderInTime order in orders)
            //{
            //    context.OrdersInTime.AddOrUpdate(
            //        o => o.OrderID,
            //        new Entities.OrderInTime { OrderID = order.OrderID, TableID = order.TableID, WaiterID = order.WaiterID }
            //        );
            //}

            //foreach (Entities.Bludo bludo in bludos)
            //{
            //    context.Bludos.AddOrUpdate(
            //        b => b.BludoID,
            //        new Entities.Bludo { BludoID = bludo.BludoID, BludoName = bludo.BludoName, BludoCategory = bludo.BludoCategory, BludoPrice = bludo.BludoPrice, BludoWeight = bludo.BludoWeight }
            //        );
            //}

            //foreach (Entities.Waiter waiter in waiters)
            //{
            //    context.Waiters.AddOrUpdate(
            //        w => w.WaiterID,
            //        new Entities.Waiter { WaiterID = waiter.WaiterID, WaiterName = waiter.WaiterName, WaiterSurname = waiter.WaiterSurname, WaiterLogin = "", WaiterPassword = "" }
            //        );
            //}

            //foreach (Entities.BludoInOrder bio in bludosio)
            //{
            //    context.BludosInOrder.AddOrUpdate(
            //        bo => bo.BludoID,
            //        new Entities.BludoInOrder { BludoID = bio.BludoID, BludoAmount = bio.BludoAmount, BludoStatus = bio.BludoStatus, OrderID = bio.OrderID, OrderTime = bio.OrderTime}
            //        );
            //}
        }
    }
}
