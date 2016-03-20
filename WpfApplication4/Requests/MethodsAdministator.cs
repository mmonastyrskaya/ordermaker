using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Linq;

namespace WpfApplication4.Requests
{
    class MethodsAdmininstrator
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
        }

        public static void InsertTable(Context context, Entities.Table table)
        {
            context.Tables.Add(table);
            context.SaveChanges();
        }

        public static void InsertWaiter(Context context, Entities.Waiter waiter)
        {
            context.Waiters.Add(waiter);
            context.SaveChanges();
        }

        public static void InsertBludo(Context context, Entities.Bludo bludo)
        {
            context.Bludos.Add(bludo);
            context.SaveChanges();
        }

        public static void DeleteTable(Context context, Entities.Table table)
        {
            context.Tables.Add(table);
            context.SaveChanges();
        }

        public static void DeleteWaiter(Context context, Entities.Waiter waiter)
        {
            //try
            //{
            context.Waiters.Remove(waiter);
            context.SaveChanges();
            //}
            //catch (InvalidOperationException ex)
            //{
            //}

        }

        public static void DeleteBludo(Context context, Entities.Bludo bludo)
        {
            try
            {
                context.Bludos.Remove(bludo);
                context.SaveChanges();
            }
            catch (InvalidOperationException ex)
            {
            }

        }

        public static void UpdateTable(Context context, Entities.Table table)
        {
            context.Tables.AddOrUpdate(
                    t => t.TableID,
                    new Entities.Table { TableID = table.TableID, TableLabel = table.TableLabel, TableLocation = table.TableLocation, TablePlaces = table.TablePlaces }
                    );
            context.SaveChanges();
        }

        public static void UpdateWaiter(Context context, Entities.Waiter waiter)
        {
            context.Waiters.AddOrUpdate(
                    w => w.WaiterID,
                    new Entities.Waiter { WaiterID = waiter.WaiterID, WaiterName = waiter.WaiterName, WaiterSurname = waiter.WaiterSurname, WaiterLogin = waiter.WaiterLogin, WaiterPassword = waiter.WaiterPassword }
                    );
            context.SaveChanges();
        }

        public static void UpdateBludo(Context context, Entities.Bludo bludo)
        {
            context.Bludos.AddOrUpdate(
                   b => b.BludoID,
                   new Entities.Bludo { BludoID = bludo.BludoID, BludoName = bludo.BludoName, BludoCategory = bludo.BludoCategory, BludoPrice = bludo.BludoPrice, BludoWeight = bludo.BludoWeight, BludoTime = DateTime.Parse((bludo.BludoTime).ToString()) }
                   );
            context.SaveChanges();
        }

        public static List<Entities.Bludo> GetAllBludos(Context context)
        {
            List<Entities.Bludo> listBludos = new List<Entities.Bludo>();
            var bludos = from r in context.Bludos
                         select r;
            foreach (Entities.Bludo singleBludo in bludos)
            {
                listBludos.Add(singleBludo);
            }
            return listBludos;
        }

        public static List<Entities.Table> GetAllTabless(Context context)
        {
            List<Entities.Table> listTables = new List<Entities.Table>();
            var tables = from r in context.Tables
                         select r;
            foreach (Entities.Table singleTable in tables)
            {
                listTables.Add(singleTable);
            }
            return listTables;
        }

        public static List<Entities.Waiter> GetAllWaiters(Context context)
        {
            List<Entities.Waiter> listWaiters = new List<Entities.Waiter>();
            var waiters = from r in context.Waiters
                          select r;
            foreach (Entities.Waiter singleWaiter in waiters)
            {
                listWaiters.Add(singleWaiter);
            }
            return listWaiters;
        }
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
