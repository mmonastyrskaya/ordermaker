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

            foreach (Entities.Bludo bludo in bludos)
            {
                context.Bludos.AddOrUpdate(b => b.BludoID,
                new Entities.Bludo
                {
                    BludoID = bludo.BludoID,
                    BludoName = bludo.BludoName,
                    BludoCategory = bludo.BludoCategory,
                    BludoPrice = bludo.BludoPrice,
                    BludoTime = bludo.BludoTime,
                    BludoWeight = bludo.BludoWeight
                });
                context.SaveChanges();
            }
            

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
