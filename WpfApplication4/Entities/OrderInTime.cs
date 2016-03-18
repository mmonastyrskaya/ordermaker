using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject.Entities
{
    class OrderInTime
    {
        [Key, Column(Order = 0)]
        public int OrderID { get; set; }
        [ForeignKey("Waiter"), Column(Order = 1)]
        public int WaiterID { get; set; }
        [ForeignKey("Table"), Column(Order = 2)]
        public int TableID { get; set; }

        public virtual Waiter Waiter { get; set; }
        public virtual Table Table { get; set; }

        public virtual ICollection<BludoInOrder> BludoInOrders { get; set; }
    }
}
