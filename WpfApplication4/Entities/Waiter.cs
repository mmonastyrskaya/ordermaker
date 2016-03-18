using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject.Entities
{
    class Waiter
    {
        [Key, Column(Order = 0)]
        public int WaiterID { get; set; }
        [Required]
        public string WaiterName { get; set; }
        [Required]
        public string WaiterSurname { get; set; }
        [Required]
        public string WaiterLogin { get; set; }
        [Required]
        public string WaiterPassword { get; set; }

        public virtual ICollection<OrderInTime> OrdersInTime { get; set; }
    }
}
