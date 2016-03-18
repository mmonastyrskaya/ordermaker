using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication4.Entities
{
    public class Bludo
    {
        [Key, Column(Order = 0)]
        public int BludoID { get; set; }
        [Required]
        public string BludoName { get; set; }
        [Required]
        public double BludoWeight { get; set; }
        [Required]
        public decimal BludoPrice { get; set; }
        [Required]
        public string BludoCategory { get; set; }
        public DateTime BludoTime { get; set; }

        public virtual ICollection<BludoInOrder> BludoInOrders { get; set; }
    }
}
