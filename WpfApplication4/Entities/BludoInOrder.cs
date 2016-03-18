using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication4.Entities
{
    public class BludoInOrder
    {
        [Key, Column(Order = 0)]
        public int BludoID { get; set; }
        [Key, Column(Order = 1)]
        public int OrderID { get; set; }
        [Required]
        public int BludoAmount { get; set; }
        public DateTime OrderTime { get; set; }
        public string BludoStatus { get; set; }

        [ForeignKey("BludoID")]
        public virtual Bludo Bludo { get; set; }
        [ForeignKey("OrderID")]
        public virtual OrderInTime OrderInTime { get; set; }
    }
}
