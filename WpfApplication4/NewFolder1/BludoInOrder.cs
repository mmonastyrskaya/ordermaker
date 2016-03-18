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
    class BludoInOrder
    {
        [DataMember]
        public int id_Bludo { get; set; }
        [DataMember]
        public int id_Order { get; set; }
        [DataMember]
        public int number_Bludo { get; set; }
        [DataMember]
        public DateTime ordertime{ get; set; }
        [DataMember]
        public string status { get; set; }
    }
}
