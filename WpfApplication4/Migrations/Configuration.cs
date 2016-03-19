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
             
            //using (var sr = new StreamReader(@"D:\Suppliers\Suppliers\source.csv"))
            //{
            //    // Skip headers
            //    sr.ReadLine();
            //    while (!sr.EndOfStream)
            //    {

            //        var line = sr.ReadLine();
            //        var items = line.Split(';');
            //        var dName = items[0];
            //        var sName = items[2];

            //foreach (Entities.Waiter waiter in waiters)
            //{
            //context.Waiters.AddOrUpdate(w =>w.WaiterID,
            //new Entities.Waiter
            //{
            //    WaiterID = 2,
            //    WaiterName = "",
            //    WaiterSurname = "",
            //    WaiterLogin = "",
            //    WaiterPassword = ""
            //});
            //context.SaveChanges();
            //}

            //context.Bludos.AddOrUpdate(b => b.BludoID,
            //    new Entities.Bludo
            //    {
            //        //BludoID = bludos[0].BludoID,
            //        //BludoName = bludos[0].BludoName,
            //        //BludoCategory = bludos[0].BludoCategory,
            //        //BludoPrice = bludos[0].BludoPrice,
            //        ////BludoTime = bludo.BludoTime,
            //        //BludoWeight = bludos[0].BludoWeight 
            //        BludoID = 1,
            //        BludoName = "Test",
            //        BludoCategory = "Test",
            //        BludoPrice = 10.0m,
            //        //BludoTime = bludo.BludoTime,
            //        BludoWeight = 100
            //    });
            //context.SaveChanges();

            //        context.Suppliers.AddOrUpdate(s => s.Name,
            //            new Supplier
            //            {
            //                Name = items[2],
            //                Address = items[3]
            //            });
            //        context.SaveChanges();

            //        context.Offers.AddOrUpdate(o => o.Price,
            //            new Offer
            //            {
            //                Price = decimal.Parse(items[4], CultureInfo.InvariantCulture),
            //                DeviceID = context.Devices.First(d => d.Name == dName),
            //                SupplierID = context.Suppliers.First(s => s.Name == sName),
            //            });
            //        context.SaveChanges();
            //    }
            //}
        }
    }
}
