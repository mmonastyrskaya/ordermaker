using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject.Entities
{
    class Table
    {
        [Key, Column(Order = 0)]
        public int TableID { get; set; }
        public string TableLocation { get; set; }
        [Required]
        public int TableLabel { get; set; }
        public int TablePlaces { get; set; }

        public virtual ICollection<OrderInTime> OrdersInTime { get; set; }
    }
}
