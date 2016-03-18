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
    class Bludo
    {
        [DataMember]
        public int id_Bludo { get; set; }
        [DataMember]
        public string name_Bludo { get; set; }
        [DataMember]
        public double weight_Bludo { get; set; }
        [DataMember]
        public decimal price_Bludo { get; set; }
        [DataMember]
        public string category_Bludo { get; set; }
        [DataMember]
        public DateTime time_Bludo { get; set; }
    }
}
