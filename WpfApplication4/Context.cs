using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WpfApplication4
{
    class Context : DbContext
    {
        public Context()
            : base("TPDB")
        {
        }

        public DbSet<Entities.Bludo> Bludos { get; set; }
        public DbSet<Entities.BludoInOrder> BludosInOrder { get; set; }
        public DbSet<Entities.OrderInTime> OrdersInTime { get; set; }
        public DbSet<Entities.Table> Tables { get; set; }
        public DbSet<Entities.Waiter> Waiters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //    modelBuilder.Entity<Entities.Bludo>().Property(b => b.BludoName).IsRequired();
            //    modelBuilder.Entity<Entities.Bludo>().Property(b => b.BludoCategory).IsRequired();
            //    modelBuilder.Entity<Entities.Bludo>().Property(b => b.BludoPrice).IsRequired();
            //    modelBuilder.Entity<Entities.Bludo>().Property(b => b.BludoWeight).IsRequired();
            //    modelBuilder.Entity<Entities.Bludo>().HasKey(b => b.BludoID);

            //    modelBuilder.Entity<Entities.BludoInOrder>().Property(bo => bo.BludoAmount).IsRequired();
            //    modelBuilder.Entity<Entities.BludoInOrder>().Property(bo => bo.BludoID).IsRequired();
            //    //modelBuilder.Entity<Entities.BludoInOrder>().HasFo
            //    //    .HasForeignKey(bo => new{bo.});

            //    modelBuilder.Entity<Entities.OrderInTime>().Property(ot => ot.TableID).IsRequired();
            //    modelBuilder.Entity<Entities.OrderInTime>().Property(ot => ot.WaiterID).IsRequired();
            //    modelBuilder.Entity<Entities.BludoInOrder>().HasForeignKey(bo => bo.OrderID);

            //    modelBuilder.Entity<Entities.Table>().Property(t => t.TableLabel).IsRequired();

            //    modelBuilder.Entity<Entities.Waiter>().Property(w => w.WaiterName).IsRequired();
            //    modelBuilder.Entity<Entities.Waiter>().Property(w => w.WaiterSurname).IsRequired();
            //    modelBuilder.Entity<Entities.Waiter>().Property(w => w.WaiterLogin).IsRequired();
            //    modelBuilder.Entity<Entities.Waiter>().Property(w => w.WaiterPassword).IsRequired();
        }
    }
}
