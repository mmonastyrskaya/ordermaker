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
    class MethodsOrder
    {
        public static bool CheckLabel(Context context, int label)
        {
            bool check = true;
            Entities.Table table;

            try
            {
                table = context.Tables.First(t => t.TableLabel == label);
            }
            catch (Exception e)
            {
                check = false;
                //string error = "Проверьте правильность введенного логина.";
            }

            if (label == 110) { check = true; }//временно

            return check;
        }

        public static Entities.Table GetTableByLabel(Context context, int label)
        {
            //Entities.Table t = new Entities.Table();
            var table = (from r in context.Tables
                         where r.TableLabel == label
                         select r).First();           

            return table;
        }

        public static Entities.Bludo GetBludoByName(Context context, string name)
        {
            //Entities.Table t = new Entities.Table();
            var bludo = (from r in context.Bludos
                         where r.BludoName == name
                         select r).First();

            return bludo;
        }
        ////public static bool CheckLabel(Context context, int label)
        //{
        //    bool check = true;
        //    Entities.Table table;

        //    try
        //    {
        //        table = context.Tables.First(t => t.TableLabel == label);
        //    }
        //    catch (Exception e)
        //    {
        //        check = false;
        //        //string error = "Проверьте правильность введенного логина.";
        //    }

        //    if (label == 110) { check = true; }//временно

        //    return check;
        //}

        public static List<Entities.Bludo> GetBludosTableID(Context context, int id_table)
        {
            List<Entities.Bludo> listBluda = new List<Entities.Bludo>();
            var order = (from r in context.OrdersInTime
                         where r.TableID == id_table
                         select r).OrderByDescending(o => o.OrderID).First();
            foreach (Entities.BludoInOrder bludo in order.BludoInOrders)
            {
                listBluda.Add(bludo.Bludo);
            }

            return listBluda;
        }

        public static double GetSumByTableID(Context context, int id_table)
        {
            double sum = 0;

            var order = (from r in context.OrdersInTime
                         where r.TableID == id_table
                         select r).OrderByDescending(o => o.OrderID).First();
            foreach (Entities.BludoInOrder bludo in order.BludoInOrders)
            {
                sum += System.Convert.ToDouble(bludo.Bludo.BludoPrice) * bludo.BludoAmount;
            }
            //List<Entities.BludoInOrder> listBludaInOrder = new List<Entities.BludoInOrder>();
            
            //var bluda = from r in context.BludosInOrder
            //            select r;

            //var bludas = from r in context.Bludos
            //             select r;
            
            //foreach (Entities.BludoInOrder singleBludoIO in bluda)
            //{
            //    Entities.BludoInOrder bio = new Entities.BludoInOrder();
            //    bio.BludoID = singleBludoIO.BludoID;
            //    bio.OrderID = singleBludoIO.OrderID;
            //    bio.BludoAmount = singleBludoIO.BludoAmount;

            //    foreach (Entities.Bludo singleBludo in bludas)
            //    {
            //        Entities.Bludo b = new Entities.Bludo();
            //        b.BludoID = singleBludo.BludoID;
            //        b.BludoPrice = singleBludo.BludoPrice;

            //        if (b.BludoID == bio.BludoID) { sum += (double)b.BludoPrice*bio.BludoAmount; }
            //    }

            //    if (bio.OrderID == order.OrderID) { listBludaInOrder.Add(bio); }
            //}

            List<Entities.Bludo> listBluda = new List<Entities.Bludo>();            

            return sum;
        }
    }
}
