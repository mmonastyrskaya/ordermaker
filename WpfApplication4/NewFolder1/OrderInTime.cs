using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication4
{
    [DataContract]
    class OrderInTime
    {
        [DataMember]
        public int id_Order { get; set; }
        [DataMember]
        public int id_Waiter { get; set; }
        [DataMember]
        public int id_Table { get; set; }
    }
}
