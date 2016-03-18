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
            //List<Entities.Table> listTables = new List<Entities.Table>();
            //using (referat1DataSet referats = new referat1DataSet())
            //{

            //    var tables = from r in referats.dbo_Table
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

            //OrderService s = new OrderService();
            //List<Entities.Table> tables = s.GetAllTables();

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

            foreach (Entities.Table table in tables)
            {
                context.Tables.AddOrUpdate(t => t.TableID,
                new Entities.Table
                {
                    TableID = table.TableID,
                    TableLabel = table.TableLabel,
                    TableLocation = table.TableLocation,
                    TablePlaces = table.TablePlaces
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
